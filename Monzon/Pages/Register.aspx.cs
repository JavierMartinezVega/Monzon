
namespace Monzon.Pages
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Text.RegularExpressions;
    using BL.Model;

    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    Response.Redirect("Forbiden.aspx");
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
            bool valid = true;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                pnlUsernameError.Visible = true;
                valid = false;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                pnlNameError.Visible = true;
                valid = false;
            }

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                pnlSurnameError.Visible = true;
                valid = false;
            }


            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                pnlEmailError.Visible = true;
                valid = false;
            }
            else
            {
                if (!ValidEmail(txtEmail.Text))
                {
                    pnlEmailError.Visible = true;
                    valid = false;
                }
            }


            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                pnlPasswordError.Visible = true;
                valid = false;
            }


            if (txtPassword.Text != txtPasswordRepeat.Text)
            {
                pnlPasswordRepeatError.Visible = true;
                valid = false;
            }

            if (valid)
            {
                //POST USER
            }
        }
    }
}