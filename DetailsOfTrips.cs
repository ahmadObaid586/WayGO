using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Junior_project;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebSocketSharp;
using FileFormat.Words;
//using System.Reflection.Metadata;
using IronPdf;
using Font = iTextSharp.text.Font;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;

namespace WinGo
{

    public partial class DetailsOfTrips : UserControl
    {
        ViewLastTrips viewlasttripRef;
        int idtrip;
        string namecompany;
        List<Customer> customers = new List<Customer>();
        List<Trip> trips1 = new List<Trip>();
        public DetailsOfTrips()
        {
            InitializeComponent();
        }
        public async void GetIdValue(int id, List<Trip> trips, ViewLastTrips viewLastTrips ,string name)
        {
            viewlasttripRef = viewLastTrips;
            idtrip = id;
            namecompany = name;
            trips1 = trips;
            dGV_CustomerInfo.Rows.Clear();
            lbl_error.Text = " ";
            JObject get = new JObject();
            get = await ResttHelper.GetAll("trip/getCustomersInTrip/" + id);
            if (get != null)
            {
                lbl_error.Text = " ";
                customers = Customer.Read_Json_Customer(get);
                for (int i = 0; i < customers.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_CustomerInfo);  // this line was missing
                    row.Cells[0].Value = customers[i].phoneNumber;
                    row.Cells[1].Value = customers[i].firstName;
                    row.Cells[2].Value = customers[i].lastName;
                    row.Cells[3].Value = customers[i].gender;
                    dGV_CustomerInfo.Rows.Add(row);
                }
                dGV_CustomerInfo.AllowUserToAddRows = false;

            }
            else
            {
                MessageBox.Show("لايوجد أشخاص في هذه الرحلة. ");

            }

        }
        public async void GetIdValue(int id, List<Trip> trips)
        {
            idtrip = id;
            trips1 = trips;
            dGV_CustomerInfo.Rows.Clear();
            lbl_error.Text = " ";
            JObject get = new JObject();
            get = await ResttHelper.GetAll("trip/getCustomersInTrip/" + id);
            if (get != null)
            {
                lbl_error.Text = " ";
                customers = Customer.Read_Json_Customer(get);
                for (int i = 0; i < customers.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_CustomerInfo);  // this line was missing
                    row.Cells[0].Value = customers[i].phoneNumber;
                    row.Cells[1].Value = customers[i].firstName;
                    row.Cells[2].Value = customers[i].lastName;
                    row.Cells[3].Value = customers[i].gender;
                    dGV_CustomerInfo.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("لايوجد أشخاص في هذه الرحلة. ");
            }

        }
        private void btn_BackPage_Click(object sender, EventArgs e)
        {
            customers = new List<Customer>();
            this.SendToBack();
        }

        private async void btn_DeleteTrip_Click(object sender, EventArgs e)
        {
            bool del = await ResttHelper.Delete("trip/deleteOldTrip/", idtrip);
            if (del)

            {
                MessageBox.Show("تم حذف الرحلة.");
                viewlasttripRef.ViewLastTrip();
                this.SendToBack();
            }
            else
            {
                lbl_error.Text = "";
                MessageBox.Show("لم يتم الحذف");
            }
        }

        private void btn_Bus_INFO_Click(object sender, EventArgs e)
        {
            viewSub_Bus_Info.GetINFO(idtrip, trips1);
            viewSub_Bus_Info.BringToFront();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void DetailsOfTrips_Load(object sender, EventArgs e)
        {

        }

        public void viewSub_Bus_Info_Load(object sender, EventArgs e)
        {

        }

        private void dGV_CustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= dGV_CustomerInfo.Columns["col_More_INFO"].Index)
            {
                string name = customers[e.RowIndex].firstName;
                more_Informations_Customer.GetNameValue(name, customers);
                more_Informations_Customer.BringToFront();
            }
        }
        private async void btn_Print_Click_1(object sender, EventArgs e)
        { 
            // Create a document and specify a file path.
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Specify the folder name
            string folderName = "Report";

            // Combine the desktop path and folder name to create the full folder path
            string fullFolderPath = Path.Combine(desktopPath, folderName);

            // Check if the folder already exists
            if (!Directory.Exists(fullFolderPath))
            {
                // If the folder doesn't exist, create it
                Directory.CreateDirectory(fullFolderPath);
                Console.WriteLine("Folder created successfully.");
            }
            
            Document document = new Document();
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(fullFolderPath+"/"+ idtrip+".pdf", FileMode.Create));
            document.Open();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // Specify an Arabic font and use "Identity-H" encoding.
            BaseFont baseFont = BaseFont.CreateFont("C:\\Users\\Ahmad\\source\\repos\\WinGo\\WinGo\\font\\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            
            PdfPTable headerTable = new PdfPTable(1);
            headerTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            headerTable.HorizontalAlignment = Element.ALIGN_CENTER;
            headerTable.TotalWidth = document.PageSize.Width;
            //get trip 
            int indexTrip = 0;
            for(int i = 0; i < trips1.Count; i++) 
            {
                if(trips1[i].id == idtrip)
                    indexTrip = i;
            }
            // Add a header cell with Arabic text
            PdfPCell headerCell_namecompany = new PdfPCell(new Phrase(" شركة "+namecompany , new Font(baseFont, 16)));
            headerCell_namecompany.Border = PdfPCell.NO_BORDER;
            headerCell_namecompany.HorizontalAlignment= Element.ALIGN_CENTER;
            headerTable.AddCell(headerCell_namecompany);
            PdfPCell headerCell = new PdfPCell(new Phrase("مركز الانطلاق: " + trips1[indexTrip].from +"\n" + "الوجهة: " + trips1[indexTrip].to + "\n"  + "تاريخ الرحلة: " + trips1[indexTrip].date, new Font(baseFont, 14)));
            headerCell.Border = PdfPCell.NO_BORDER;
            headerCell.HorizontalAlignment = Element.ALIGN_LEFT;
            headerTable.AddCell(headerCell);


            PdfPCell emptyLine = new PdfPCell(new Phrase("______________________________________________", new Font(baseFont, 14)));
            emptyLine.Border = PdfPCell.NO_BORDER;
            emptyLine.HorizontalAlignment = Element.ALIGN_CENTER;
            headerTable.AddCell(emptyLine);

            // Add the header table to the document
            document.Add(headerTable);

            // Create a table with 9 columns.
            PdfPTable pdfPTable = new PdfPTable(9);
            pdfPTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            pdfPTable.HorizontalAlignment = Element.ALIGN_CENTER;
            float[] columnWidths = { 35f, 15f, 30f, 35f, 20f, 22f, 20f, 20f ,5f };
            pdfPTable.SetTotalWidth(columnWidths);
            // Add cell headers with Arabic text.
            PdfPCell num = new PdfPCell(new Phrase("N", new Font(baseFont, 12)));
            pdfPTable.AddCell(num);
            PdfPCell name = new PdfPCell(new Phrase("الاسم", new Font(baseFont, 12)));
            // name.Colspan = 1;
            pdfPTable.AddCell(name);
            PdfPCell lastname = new PdfPCell(new Phrase("الكنية", new Font(baseFont, 12)));
            pdfPTable.AddCell(lastname);
            PdfPCell fathername = new PdfPCell(new Phrase("اسم الأب", new Font(baseFont, 12)));
            pdfPTable.AddCell(fathername);
            PdfPCell mothername = new PdfPCell(new Phrase("اسم الأم", new Font(baseFont, 12)));
            pdfPTable.AddCell(mothername);
            PdfPCell iss = new PdfPCell(new Phrase("رقم الهوية", new Font(baseFont, 12)));
            pdfPTable.AddCell(iss);
            PdfPCell berthdate = new PdfPCell(new Phrase("تاريخ الميلاد", new Font(baseFont, 12)));
            pdfPTable.AddCell(berthdate);
            PdfPCell gender = new PdfPCell(new Phrase("الجنس", new Font(baseFont, 12)));
            pdfPTable.AddCell(gender);
            PdfPCell phone = new PdfPCell(new Phrase("رقم الهاتف", new Font(baseFont, 12)));
            pdfPTable.AddCell(phone);
            for (int i = 0; i < customers.Count; i++)
            {
                pdfPTable.AddCell(new PdfPCell(new Phrase((i+1).ToString(), new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].firstName, new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].lastName, new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].fatherName, new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].motherName, new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].iss, new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase("03/11/1998", new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].gender, new Font(baseFont, 11))));
                pdfPTable.AddCell(new PdfPCell(new Phrase(customers[i].phoneNumber, new Font(baseFont, 11))));
                document.Add(pdfPTable);
                pdfPTable = new PdfPTable(9);
                pdfPTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                pdfPTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPTable.SetTotalWidth(columnWidths);
            }
            document.Close();
            pdfWriter.Close();
            MessageBox.Show("save pdf at :" + fullFolderPath);

        }
    }
}


