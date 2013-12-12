using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SampleWinApp
{
    public partial class MailCompose : Form
    {
        public MailCompose()
        {
            InitializeComponent();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("");

            //SmtpClient mailClient = new SmtpClient();
            //mailClient.Credentials = "myusername@gmail.com";
            //mailClient.EnableSsl = true;

            //mailClient.Send(mail);


            //var client = new SmtpClient("smtp.gmail.com", 587)
            //{
            //    Credentials = new NetworkCredential("myusername@gmail.com", "mypwd"),
            //    EnableSsl = true
            //};


        }
    }
}
