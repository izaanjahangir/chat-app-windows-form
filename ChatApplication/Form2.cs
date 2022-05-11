using System;
using System.Net;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

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
            try
            {
                string accountSid = "";
                string authToken = "";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: MessageText,
                    from: new Twilio.Types.PhoneNumber("+19705288346"),
                    to: new Twilio.Types.PhoneNumber(toNumber)
                );

                Console.WriteLine(message.Sid);
                showMessage("Message sent successfully");
            }
            catch(Exception e)
            {
                showMessage(e.Message);
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
         
            SendSMS(masking, to, message, myApiKey);
      
            
        }

        private static void showMessage(String message) {
            MessageBox.Show(message);
        }
    }
}