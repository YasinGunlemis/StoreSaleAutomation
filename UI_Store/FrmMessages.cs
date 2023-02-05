using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Store
{
    public partial class FrmMessages : Form
    {
        public FrmMessages()
        {
            InitializeComponent();
        }

        private void FrmMessages_Load(object sender, EventArgs e)
        {

        }

        private void BttnSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("Email","Password");
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;
            message.To.Add(TxtEmail.Text);
            message.From = new MailAddress("Email");
            message.Subject = TxtSubject.Text;
            message.Body = RchMessage.Text;
            client.Send(message);

        }
    }
}
