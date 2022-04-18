using System;
using System.Net;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Form2 : Form
    {
        public User loggedInUser;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(loggedInUser == null)
            {
                showMessage("Please login first");
                openLoginForm();
                this.Hide();

                return;
            }

            this.hi_user_label.Text = "Hi " + loggedInUser.username;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            openLoginForm();
            this.Hide();
        }

        private void openLoginForm() {
            Form1 form1 = new Form1();
            form1.Show();
        }

        public static string SendSMS(string Masking, string toNumber, string MessageText, string MyApiKey)
        {
            String URI = "https://sendpk.com" +
            "/api/sms.php?" +
            "api_key=" + MyApiKey +
            "&sender=" + Masking +
            "&mobile=" + toNumber +
            "&message=" + Uri.UnescapeDataString(MessageText); // Visual Studio 10-15
       
            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                var httpWebResponse = ex.Response as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            showMessage("404:URL not found :" + URI);
                            break;
                           
                        case HttpStatusCode.BadRequest:
                            showMessage("400:Bad Request");
                            break;
                       
                        default:
                            showMessage( httpWebResponse.StatusCode.ToString());
                            break;
                    }
                }
            }
            return null;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Here");
            String to = this.to_textbox.Text;
            String message = this.message_textbox.Text;

            if (to.Trim().Length <= 0)
            {
                 showMessage("Please enter mobile number");
                return;
            }
            if (message.Trim().Length <= 0)
            {
                showMessage("Please enter some message");
                return;
            }
           
            string myApiKey = "";
           
            string masking = loggedInUser.username;
         
            string jsonResponse = SendSMS(masking, to, message, myApiKey);
            Console.Write(jsonResponse);
            showMessage("Message sent successfully");
            
        }

        private static void showMessage(String message) {
            MessageBox.Show(message);
        }
    }
}