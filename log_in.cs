using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Junior_project;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        
        private void Log_in_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Log_in_Click_1(object sender, EventArgs e)
        {

            if (txtPassWord.Texts != "" && txtUserName.Texts != "")
            {
                Company com = new Company();
                com.userName = txtUserName.Texts;
                com.password = txtPassWord.Texts;
                var inputJson = JsonConvert.SerializeObject(com);
                JObject Check_Login = await ResttHelper.POST_Login("login", inputJson);
                   if(Check_Login != null ) 
                    {
                    HomePage m = new HomePage(Check_Login["companyName"].Value<String>() , this);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    lblError_1.Text = "كلمة المرور او اسم المستخدم حطأ";
                    }
            }


            else
            {
                lblError_1.Text = "يرجى ملئ كافة الحقول";

            }
        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
