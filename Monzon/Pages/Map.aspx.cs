
namespace Monzon.Pages
{
    using System;
    using System.Drawing;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using BL.Model;
    using BL.Repository;

    public partial class Map : System.Web.UI.Page
    {
        private int i = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    GetMembers();
                    //GetPlaces();
                    GetHives();
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
                var boton = new System.Web.UI.WebControls.Label();
                boton.Attributes.Add("onmouseover", "myFunction(" + i + ")");
                boton.Attributes.Add("onmouseout", "myFunction(" + i + ")");
                boton.Style.Add("background-image", "../Images/Map/person.svg");
                boton.Style.Add("Position", "absolute");
                boton.Style.Add("Top", member.X + "px");
                boton.Style.Add("Left", member.Y + "px");
                boton.Height = 36;
                boton.Width = 36;

                var div = new HtmlGenericControl("div") {ID = "myPopup" + i};
                div.Attributes.Add("class", "popuptext");
                div.InnerHtml = member.LOGIN1 + "</br>" + "X: " + member.X + " - Y: " + member.Y;
                boton.Controls.Add(div);

                pnlMap.Controls.Add(boton);
                i++;
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

        private void GetHives()
        {
            var hives = PlaceRepository.Instance.GetHives();
            this.pnlMap.Style.Add("position", "relative");

            foreach (var hive in hives)
            {
                var boton = new System.Web.UI.WebControls.Label();
                boton.Attributes.Add("onmouseover", "myFunction(" + i + ")");
                boton.Attributes.Add("onmouseout", "myFunction(" + i + ")");
                boton.Style.Add("background-image", "../Images/Map/hive.svg");
                boton.Style.Add("Position", "absolute");
                boton.Style.Add("Top", hive.X + "px");
                boton.Style.Add("Left", hive.Y + "px");
                boton.Height = 36;
                boton.Width = 36;

                var div = new HtmlGenericControl("div") { ID = "myPopup" + i };

                div.Attributes.Add("class", "popuptext");

                var hiveMembers = LoginRepository.Instance.GethiveMembers(hive.UNIQUE_ID);

                var html = string.Empty;
                var first = true;

                foreach (var hiveMember in hiveMembers)
                {
                    if (!first)
                    {
                        html = html + ", ";
                    }
                    html = html + hiveMember.LOGIN1;
                    first = false;
                }

                if (hiveMembers.Count > 0)
                {
                    html = html.Remove(0, html.Length - 2);
                }

                div.InnerHtml = hive.NAME + "</br><b>Members:</b> " + html + "</br>" + "X: " + hive.X + " - Y: " + hive.Y;
                boton.Controls.Add(div);

                pnlMap.Controls.Add(boton);
                i++;
            }
        }
    }
}