
namespace Monzon.Pages
{
    using System;
    using System.Drawing;
    using System.Globalization;
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
                    GetCrystal();
                    GetPlaces();
                    //GetHives();
                }
                else
                {
                    Response.Redirect("Forbiden.aspx");
                }
        }

        private void GetMembers()
        {
            var members = LoginRepository.Instance.GetMembers();
            //this.pnlMap.Style.Add("position", "relative");
            
            foreach (var member in members)
            {
                var boton = new System.Web.UI.WebControls.Label();
                boton.Attributes.Add("onmouseover", "myFunction(" + i + ")");
                boton.Attributes.Add("onmouseout", "myFunction(" + i + ")");
                boton.Style.Add("background-image", "../Images/Map/BigGreenPointer.png");
                boton.Style.Add("background-size", "36px");
                //boton.Style.Add("background-image", "../Images/Map/person.svg");
                boton.Style.Add("Position", "absolute");
                string top = ((((double) member.X/(double) 510)*100) + "%").Replace(",", ".");
                string left = ((((double)member.Y / (double)1022) * 100) + "%").Replace(",", ".");
                boton.Style.Add("Top", top);
                boton.Style.Add("Left", left);
                boton.Height = 36;
                boton.Width = 36;

                var div = new HtmlGenericControl("div") {ID = "myPopup" + i};
                div.Attributes.Add("class", "popuptextGreen");
                div.InnerHtml = member.LOGIN1 + "</br>" + "X: " + member.X + " - Y: " + member.Y;
                boton.Controls.Add(div);

                pnlMap.Controls.Add(boton);
                i++;
            }
        }

        private void GetCrystal()
        {
            this.pnlMap.Style.Add("position", "absolute");

            Label boton = new System.Web.UI.WebControls.Label();
            boton.Attributes.Add("onmouseover", "myFunction(" + i + ")");
            boton.Attributes.Add("onmouseout", "myFunction(" + i + ")");
            boton.Style.Add("background-image", "../Images/Map/Crystal.png");
            boton.Style.Add("Position", "absolute");
           
            boton.Width = 72;
            boton.Height = 72;

            boton.Style.Add("background-size", (double)boton.Width.Value + "px " + (double)boton.Height.Value + "px");
            boton.Style.Add("background-repeat", "no-repeat");

            boton.Style.Add("Top", "calc(50% - " + ((double)boton.Width.Value / (double)2) + "px)");
            boton.Style.Add("Left", "calc(50% - " + ((double)boton.Height.Value / (double)2) + "px)");
            //ton.Style.Add("Left", "50%");
            var div = new HtmlGenericControl("div") { ID = "myPopup" + i };
            div.Attributes.Add("class", "popuptextYellow");
            div.InnerHtml = "<b>THE CRYSTAL</b></br>" + "X: 253 - Y: 515";
            boton.Controls.Add(div);
           
            pnlMap.Controls.Add(boton);
            i++;
        }


        private void GetPlaces()
        {
            var places = PlaceRepository.Instance.GetPlaces();
            this.pnlMap.Style.Add("position", "relative");

            foreach (var member in places)
            {
                var boton = new System.Web.UI.WebControls.Label();
                boton.Attributes.Add("onmouseover", "myFunction(" + i + ")");
                boton.Attributes.Add("onmouseout", "myFunction(" + i + ")");

                if (member.PLACE_TYPE.BIZ_ID.Trim() == "MNS")
                {
                    boton.Style.Add("background-image", "../Images/Map/BigBluePointer.png");
                }
                else
                {
                    boton.Style.Add("background-image", "../Images/Map/BigRedPointer.png");
                }
                //boton.Style.Add("background-image", "../Images/Map/person.svg");
                boton.Style.Add("Position", "absolute");
                boton.Style.Add("background-size", "36px");
                string top = ((((double)member.X / (double)510) * 100) + "%").Replace(",", ".");
                string left = ((((double)member.Y / (double)1022) * 100) + "%").Replace(",", ".");
                boton.Style.Add("Top", top);
                boton.Style.Add("Left", left);
                boton.Height = 36;
                boton.Width = 36;

                var div = new HtmlGenericControl("div") { ID = "myPopup" + i };

                if (member.PLACE_TYPE.BIZ_ID.Trim() == "MNS")
                {
                    div.Attributes.Add("class", "popuptext");
                }
                else
                {
                    div.Attributes.Add("class", "popuptextRed");
                }
                
                div.InnerHtml = member.NAME + "</br>" + "X: " + member.X + " - Y: " + member.Y;
                boton.Controls.Add(div);

                pnlMap.Controls.Add(boton);
                i++;
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

        protected void pnlAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Place.aspx");
        }

        private int GetX(int axis)
        {
            return 0;
        }

        private int GetY(int axis)
        {
            return 0;
        }
    }
}