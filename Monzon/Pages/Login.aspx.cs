

namespace Monzon.Pages
{
    using System;
    using BL.Model;
    using BL.Repository;

    public partial class Login : System.Web.UI.Page
    {
        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            if (LoginRepository.Instance.CheckUser(new LOGIN {LOGIN1 = txtUser.Text, PASSWORD = txtPass.Text}) != null)
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                pnlFobiden.Visible = true;
            }
        }

        protected void btnPasswordRecovery_Click(object sender, EventArgs e)
        {
            Response.Redirect("PasswordRecovery.aspx");
        }
    }
}