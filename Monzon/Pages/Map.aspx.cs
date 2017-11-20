
namespace Monzon.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Drawing;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Web.UI.WebControls;
    using BL.Model;
    using BL.Repository;
    using Models;

    public partial class Map : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    GetMembers();
                }
                else
                {
                    Response.Redirect("Forbiden.aspx");
                }
        }

      


        private List<MapMember> GetMembers()
        {
            var members = LoginRepository.Instance.GetMembers();
            var result = new List<MapMember>();
            this.pnlMap.Style.Add("position", "relative");

            int i = 0;

            foreach (var member in members)
            {
                Label boton = new Label {Width = member.LOGIN1.Length*10, Height = 10, Text = member.LOGIN1};
                boton.Style.Add("Position", "absolute");
                boton.Style.Add("Top", member.X + "px");
                boton.Style.Add("Left", member.Y + "px");
                if (i == 0)
                {
                    boton.BackColor = Color.DarkGreen;
                }
                else
                {
                    boton.BackColor = Color.OrangeRed;
                }
                boton.Font.Size = 8;
                pnlMap.Controls.Add(boton);
                i++;
            }

            return result;
        }
    }
}