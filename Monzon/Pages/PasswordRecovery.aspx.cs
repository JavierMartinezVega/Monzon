
namespace Monzon.Pages
{
    using System;
    using BL.Model;
    using BL.Repository;

    public partial class PasswordRecovery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    lblEmail.Text = user.EMAIL;
                }
                else
                {
                    Response.Redirect("Forbiden.aspx");
                }
            }
        }

        protected void Unnamed13_Click(object sender, EventArgs e)
        {
            var user = (LOGIN)Session["USER"];

            if (user != null)
            {
                var random = System.Web.Security.Membership.GeneratePassword(8, 1);
                if (LoginRepository.Instance.PasswordRecovery(user, random))
                {
                    //OK MESSAGE
                }
                else
                {
                    //KO MESSAGE
                }
            }
            else
            {
                Response.Redirect("Forbiden.aspx");
            }
        }
    }
}