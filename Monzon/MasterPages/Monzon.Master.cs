﻿
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
                pnlUser.Visible = true;
                pnlAcceso.Visible = false;
                btnProfile.Visible = true;

                if (user.PROFILE.BIZ_ID == "ADM" || user.PROFILE.BIZ_ID == "LED" || user.PROFILE.BIZ_ID == "R4")
                {
                    pnlMap.Visible = true;
                    pnlPlaces.Visible = true;
                }
                else
                {
                    pnlMap.Visible = false;
                    pnlPlaces.Visible = false;
                }
            }
            else
            {
                pnlUser.Visible = false;
                pnlAcceso.Visible = true;
                pnlProfile.Visible = false;
                pnlMap.Visible = false;
                pnlPlaces.Visible = false;
            }
        }

        protected void btnPlaces_Click(object sender, EventArgs e)
        {
            Response.Redirect("Places.aspx");
        }
       
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu2.Visible)
                this.pnlMenu2.Visible = false;
            else
            {
                this.pnlMenu2.Visible = true;
            }
        }

        protected void btnMenu3_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu2.Visible)
                this.pnlMenu2.Visible = false;
            else
            {
                this.pnlMenu2.Visible = true;
            }
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
                pnlFobiden.Visible = true;
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

        protected void btnBlog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Blog.aspx");
        }

        protected void btnGuild_Click(object sender, EventArgs e)
        {
            pnlSubGuild.Visible = !pnlSubGuild.Visible;
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