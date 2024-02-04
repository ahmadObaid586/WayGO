using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Junior_project;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;
namespace WinGo
{
    public partial class TicketBooking : UserControl
    {
        JObject reservInfo = new JObject();
        int tripId;
        int ticktprice;
        int[,] resceiveArray;
        int[] Booked1D = new int[55];
        List<int> chear = new List<int>();
        private ClientWebSocket webSocket;

        int count = 0;
        public TicketBooking()
        {
            InitializeComponent();

        }
        public async void  GetId(int id , int price )
        {
            tripId = id;
            ticktprice = price;
            lbl_Ticket_price.Text =  ticktprice.ToString();
            int numRows = tlp_Resarivation_Seates.RowCount;
            int numCols = tlp_Resarivation_Seates.ColumnCount;
            resceiveArray = new int[numCols, numRows];
            for (int i = 0; i < resceiveArray.GetLength(0); i++)
            {
                for(int j = 0; j<resceiveArray.GetLength(1); j++)
                {
                    resceiveArray[i, j] = 0;
                }
            }
            reservInfo = await ResttHelper.GetAll("trip/getChear/" + tripId);
            List<int> ints= new List<int>();
            foreach (JObject data in reservInfo["chear"]) 
            {
                if (data["isBooked"].Value<string>() == "yes")
                {
                    ints.Add(1);
                }
                else
                {
                    ints.Add(0);
                }
            }

            int index = 0;
            lbl_SumOfPrices.Text = String.Empty;
            int indexOfChearBooked = 0;
            ///////////check num of bus chear //// take 45 chear or 35 chear 
            if (ints.Count == 35)
            {
                for (int row = 0; row < numRows ; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        if (col == 2 && row != 10 || col == 3 && row != 10)
                            continue; 
                        // Create a new PictureBox
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ints[indexOfChearBooked] == 0)
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\not recierve.png"; // Replace "yourImage" with the actual image you want to assign to the PictureBox 
                        }
                        else
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                            resceiveArray[col, row] = 1;
                        }
                        pictureBox.MouseClick += pictureBox_MouseClick;
                        //pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                        tlp_Resarivation_Seates.Controls.Add(pictureBox, col, row);
                        //lbl_tickt_price.Text += ticktprice.ToString();
                        lbl_SumOfPrices.Text = "0";
                        indexOfChearBooked++;
                    }
                }
            }
            if(ints.Count == 45)
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (col == 2 && row != 10)
                        continue;
                    // Create a new PictureBox
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (ints[indexOfChearBooked] == 0)
                    {
                        pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\not recierve.png"; // Replace "yourImage" with the actual image you want to assign to the PictureBox 
                    }
                    else
                    {
                        pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                        resceiveArray[col, row] = 1;
                    }
                    pictureBox.MouseClick += pictureBox_MouseClick;
                    //pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                    tlp_Resarivation_Seates.Controls.Add(pictureBox, col, row);
                    lbl_SumOfPrices.Text = "0";
                    indexOfChearBooked++;
                }
            }
        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void tlp_Resarivation_Seates_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tlp_Resarivation_Seates_Paint(object sender, PaintEventArgs e)
        {
              
            }

        private async void TicketBooking_Load(object sender, EventArgs e)
        {
        }
        
        private void btn_BackPage_Click_1(object sender, EventArgs e)
        {
            tlp_Resarivation_Seates.Controls.Clear();
            count = 0;
            this.SendToBack();
        }

        private async void btn_reservation_seats_Click(object sender, EventArgs e)
        { 
            int index = 0 ;
            string m = "";
            int counter = 0;
            // loop for get index of chear that reservation and cinvert to 1D array
            for (int i = 0; i < resceiveArray.GetLength(1); i++)
            {
                for (int j = 0; j < resceiveArray.GetLength(0); j++)
                {
                    if (j == 2 && i != 10)
                        continue;
                    else
                    {
                        Booked1D[index] = resceiveArray[j, i];
                        index++;
                    }
                }
            }

            // get just index of chear that booked from 1D array and save in IndexOfBooked1D
            for (int i = 0; i < Booked1D.Length; i++)
            {
                if (Booked1D[i] == 1)
                {
                    chear.Add(i);
                }
                
            }
            var inputjson = "{"+ "chear:"+JsonConvert.SerializeObject(chear)+"}";
            var tet = JsonConvert.SerializeObject(inputjson);
            bool check_ReservationChear;
            MessageBox.Show(inputjson);
            check_ReservationChear = await  ResttHelper.POST("trip/bookChear/"+tripId.ToString() , tet);
            if (check_ReservationChear == true)
            {
                pnl_Ticket.get_parameter(tripId, count, ticktprice, chear);
                btn_rest_Click();
                pnl_Ticket.BringToFront();
            }
            else
                MessageBox.Show("error");     
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (count < 5)
                if (sender is PictureBox pictureBox)
                {
                    count++;
                    int col = tlp_Resarivation_Seates.GetColumn(pictureBox);
                    int row = tlp_Resarivation_Seates.GetRow(pictureBox);
                    PictureBox NewpictureBox = new PictureBox();
                    NewpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    NewpictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                    NewpictureBox.MouseClick += pictureBox_MouseClick;
                    tlp_Resarivation_Seates.Controls.Remove(pictureBox);
                    tlp_Resarivation_Seates.Controls.Add(NewpictureBox, col, row);
                    resceiveArray[col, row] = 1;
                    lbl_SumOfPrices.Text = (ticktprice * count).ToString();

                }
                else
                    MessageBox.Show("لا يمكن حجز أكثر من خمس مقاعد");
    }

        private void tlp_Resarivation_Seates_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            count = 0;
            chear = new List<int>();
            int numRows = tlp_Resarivation_Seates.RowCount;
            int numCols = tlp_Resarivation_Seates.ColumnCount;
            for (int i = 0; i < resceiveArray.GetLength(0); i++)
            {
                for (int j = 0; j < resceiveArray.GetLength(1); j++)
                {
                    resceiveArray[i, j] = 0;
                }
            }
            tlp_Resarivation_Seates.Controls.Clear();
            List<int> ints = new List<int>();
            foreach (JObject data in reservInfo["chear"])
            {
                if (data["isBooked"].Value<string>() == "yes")
                {
                    ints.Add(1);
                }
                else
                {
                    ints.Add(0);
                }
            }
            int index = 0;
            lbl_SumOfPrices.Text = String.Empty;
            int indexOfChearBooked = 0;
            ///////////check num of bus chear //// take 45 chear or 35 chear 
            if (ints.Count == 35)
            {
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        if (col == 2 && row != 10 || col == 3 && row != 10)
                            continue;
                        // Create a new PictureBox
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ints[indexOfChearBooked] == 0)
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\not recierve.png"; // Replace "yourImage" with the actual image you want to assign to the PictureBox 
                        }
                        else
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                            resceiveArray[col, row] = 1;
                        }
                        pictureBox.MouseClick += pictureBox_MouseClick;
                        //pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                        tlp_Resarivation_Seates.Controls.Add(pictureBox, col, row);
                        lbl_SumOfPrices.Text = "0";
                        indexOfChearBooked++;
                    }
                }
            }
            if (ints.Count == 45)
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        if (col == 2 && row != 10)
                            continue;
                        // Create a new PictureBox
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ints[indexOfChearBooked] == 0)
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\not recierve.png"; // Replace "yourImage" with the actual image you want to assign to the PictureBox 
                        }
                        else
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                            resceiveArray[col, row] = 1;
                        }
                        pictureBox.MouseClick += pictureBox_MouseClick;
                        //pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                        tlp_Resarivation_Seates.Controls.Add(pictureBox, col, row);
                        lbl_SumOfPrices.Text = "0";
                        indexOfChearBooked++;
                    }
                }
                                                //////// OverLoad Function
        }private void btn_rest_Click()
        {
            count = 0;
            chear = new List<int>();
            int numRows = tlp_Resarivation_Seates.RowCount;
            int numCols = tlp_Resarivation_Seates.ColumnCount;
            for (int i = 0; i < resceiveArray.GetLength(0); i++)
            {
                for (int j = 0; j < resceiveArray.GetLength(1); j++)
                {
                    resceiveArray[i, j] = 0;
                }
            }
            tlp_Resarivation_Seates.Controls.Clear();
            List<int> ints = new List<int>();
            foreach (JObject data in reservInfo["chear"])
            {
                if (data["isBooked"].Value<string>() == "yes")
                {
                    ints.Add(1);
                }
                else
                {
                    ints.Add(0);
                }
            }
            int index = 0;
            lbl_SumOfPrices.Text = String.Empty;
            int indexOfChearBooked = 0;
            ///////////check num of bus chear //// take 45 chear or 35 chear 
            if (ints.Count == 35)
            {
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        if (col == 2 && row != 10 || col == 3 && row != 10)
                            continue;
                        // Create a new PictureBox
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ints[indexOfChearBooked] == 0)
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\not recierve.png"; // Replace "yourImage" with the actual image you want to assign to the PictureBox 
                        }
                        else
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                            resceiveArray[col, row] = 1;
                        }
                        pictureBox.MouseClick += pictureBox_MouseClick;
                        //pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                        tlp_Resarivation_Seates.Controls.Add(pictureBox, col, row);
                        lbl_SumOfPrices.Text = "0";
                        indexOfChearBooked++;
                    }
                }
            }
            if (ints.Count == 45)
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        if (col == 2 && row != 10)
                            continue;
                        // Create a new PictureBox
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ints[indexOfChearBooked] == 0)
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\not recierve.png"; // Replace "yourImage" with the actual image you want to assign to the PictureBox 
                        }
                        else
                        {
                            pictureBox.ImageLocation = "C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\images\\reserive.png";
                            resceiveArray[col, row] = 1;
                        }
                        pictureBox.MouseClick += pictureBox_MouseClick;
                        //pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                        tlp_Resarivation_Seates.Controls.Add(pictureBox, col, row);
                        lbl_SumOfPrices.Text = "0";
                        indexOfChearBooked++;
                    }
                }
        }

        private void pnl_Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}


