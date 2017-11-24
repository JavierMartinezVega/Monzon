
namespace Monzon.Pages
{
    using System;
    using System.Drawing;
    using System.Web.UI.WebControls;
    using BL.Model;
    using BL.Repository;

    public partial class Map : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    GetMembers();
                    GetPlaces();
                }
                else
                {
                    Response.Redirect("Forbiden.aspx");
                }
        }

        private void GetMembers()
        {
            var members = LoginRepository.Instance.GetMembers();
            this.pnlMap.Style.Add("position", "relative");

            foreach (var member in members)
            {
                Label boton = new Label {Width = member.LOGIN1.Length*7, Height = 12, Text = "     " + member.LOGIN1};
                boton.BorderColor = Color.White;
                boton.BorderWidth = 1;
                boton.Style.Add("text-align", "center");
                boton.Style.Add("Position", "absolute");
                boton.Style.Add("Top", member.X + "px");
                boton.Style.Add("Left", member.Y + "px");
                boton.BackColor = Color.SaddleBrown;
                boton.ForeColor = Color.White;
                boton.Font.Size = 8;
                pnlMap.Controls.Add(boton);
            }
        }

        private void GetPlaces()
        {
            var places = PlaceRepository.Instance.GetPlaces();
            this.pnlMap.Style.Add("position", "relative");

            foreach (var member in places)
            {
                Label boton = new Label { Width = (member.SUBTITLE.Length + member.NAME.Length) * 5, Height = 12, Text = "     " + member.NAME + " " + member.SUBTITLE };
                boton.BorderColor = Color.White;
                boton.BorderWidth = 1;
                boton.Style.Add("text-align", "center");
                boton.BorderStyle = BorderStyle.Outset;
                boton.Style.Add("Position", "absolute");
                boton.Style.Add("Top", member.X + "px");
                boton.Style.Add("Left", member.Y + "px");
                boton.BackColor = Color.DarkBlue;
                boton.ForeColor = Color.White;
                boton.Font.Size = 8;
                pnlMap.Controls.Add(boton);
            }
        }
    }
}