using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 8,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is a FeedBack Page 
    @version = 1.0
*/
namespace GameTrackingSystem
{
    public partial class FeedBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is to send email to user and admin.
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("onetwo12shah@gmail.com");
                mail.To.Add(EmailTextBox.Text);
                mail.CC.Add("kotharivandit18@gmail.com");
                mail.CC.Add("josemathew.sm@gmail.com");
                mail.Subject = "Thank you.";
                mail.Body = CommentTextBox.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("onetwo12shah", "VANDIT189");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        /*
      * @method Unnamed_Click(Object,EventArgs)
      * @return {void}
      * */
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}