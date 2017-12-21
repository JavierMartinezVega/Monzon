
namespace Monzon.Pages
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Text.RegularExpressions;
    using BL.Model;
    using Utils;

    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    txtName.Text = user.FIRST_NAME + " " + user.LAST_NAME;
                    txtName.Enabled = false;
                    txtEmail.Text = user.EMAIL;
                    txtEmail.Enabled = false;
                }
                else
                {
                    txtName.Enabled = true;
                    txtEmail.Enabled = true;
                }
            }
        }

      

        private Boolean ValidEmail(String email)
        {
            const string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected void Unnamed13_Click(object sender, EventArgs e)
        {

            if (MailHelper.SendContactEmail(txtName.Text, txtEmail.Text, txtMessage.Text))
            {
                pnlError.Visible = false;
                pnlOk.Visible = true;
            }
            else
            {
                pnlError.Visible = true;
                pnlOk.Visible = false;
            }
        }
    }
}