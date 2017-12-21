
namespace Monzon.Pages
{
    using System;
    using System.Configuration;
    using System.Web.UI.WebControls;
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
                LoadData(1);
        }
        protected void Unnamed13_Click(object sender, EventArgs e)
        {
            //Session["PAGE"] = (int)Session{ "PAGE"}
            //LoadData((int)Session["PAGE"] + 1);
        }

        private void LoadData(int page, int pageSize = 6)
        {
            var posts =  PostRepository.Instance.GetDescendingDate(page, pageSize);
            if (posts.Count >= 6)
            {
                pnlMore.Visible = true;
            }

            int i = 0;

            foreach (var post in posts)
            {
                if (i == 4)
                {
                    break;
                }

                var panel = new Panel();

                var image = new Image {ImageUrl = "../Images/post/" + post.URL};

                var labelTitle = new Label {Text = post.TITLE};

                var labelText = new Label {Text = post.TEXT};

                var linkButton = new LinkButton {Text = "Read more...", PostBackUrl = "Post.aspx?id=" + post.UNIQUE_ID};

                panel.Controls.Add(image);
                panel.Controls.Add(labelTitle);
                panel.Controls.Add(labelText);
                panel.Controls.Add(linkButton);

                pnlPosts.Controls.Add(panel);
                i = i++;
            }
        }

        private void link_Click(object sender, EventArgs e)
        {
            
        }
    }
}