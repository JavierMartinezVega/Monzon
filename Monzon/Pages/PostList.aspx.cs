
namespace Monzon.Pages
{
    using System;
    using System.Configuration;
    using BL.Model;
    using BL.Repository;

    public partial class PostList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var user = (LOGIN)Session["USER"];

            if (user != null)
            {
                var adminId = new AppSettingsReader().GetValue("ADMIN_ID", typeof(string));

                if (user.PROFILE.BIZ_ID != adminId.ToString())
                    Response.Redirect("Forbiden.aspx");
            }
            else
            {
                Response.Redirect("Forbiden.aspx");
            }

            if (!IsPostBack)
                LoadData();
        }
        protected void Unnamed13_Click(object sender, EventArgs e)
        {
            //Session["PAGE"] = (int)Session{ "PAGE"}
            //LoadData((int)Session["PAGE"] + 1);
        }

        private void LoadData(int page  = 1, int pageSize = 5)
        {
            lstPost.DataSource = PostRepository.Instance.GetDescendingDate(page, pageSize);
            lstPost.DataBind();
        }
    }
}