
namespace Monzon.Pages
{
    using System;
    using BL.Repository;

    public partial class Places : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            gridPlaces.DataSource = PlaceRepository.Instance.GetPlaces();
            gridPlaces.DataBind();
        }
    }
}