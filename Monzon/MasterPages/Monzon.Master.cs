
namespace Monzon.MasterPages
{
    using System;
    using BL.Model;
    using BL.Repository;

    public partial class Monzon : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (LOGIN)Session["USER"];
            if (user != null)
            {
                txtLUser.Text = user.FIRST_NAME + " " + user.LAST_NAME;
                menuPublic.Visible = false;
                menuLogged.Visible = true;
                pnlUser.Visible = true;
                pnlAcceso.Visible = false;
            }
            else
            {
                menuPublic.Visible = true;
                menuLogged.Visible = false;
                pnlUser.Visible = false;
                pnlAcceso.Visible = true;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = !pnlLogin.Visible;
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            var user = LoginRepository.Instance.CheckUser(new LOGIN { LOGIN1 = txtUser.Text, PASSWORD = txtPass.Text });
            if (user != null)
            {
                Session["USER"] = user;
                Response.Redirect("Index.aspx");
            }
            else
            {
                pnlUser.Visible = true;
                pnlAcceso.Visible = false;
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
           Response.Redirect("Register.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["USER"] = null;
            Response.Redirect("Index.aspx");
        }

        protected void txtLUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("Map.aspx");
        }

        protected void btnGuild_Click(object sender, EventArgs e)
        {
            Response.Redirect("Guild.aspx");
        }

        protected void btnMembers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Members.aspx");
        }
        protected void btnRules_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rules.aspx");
        }

        protected void btnRequirements_Click(object sender, EventArgs e)
        {
            Response.Redirect("Requirements.aspx");
        }

        protected void btnCartanica_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cartanica.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}