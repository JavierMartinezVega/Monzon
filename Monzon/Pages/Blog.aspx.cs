
namespace Monzon.Pages
{
    using System;
    using System.Configuration;
    using System.Web.UI.WebControls;
    using BL.Model;
    using BL.Repository;

    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData(1);
        }

        private void LoadData(int page, int pageSize = 6)
        {
            var posts = PostRepository.Instance.GetDescendingDate(page, pageSize);
            pnlMore.Visible = posts.Count >= 6;

            int i = 0;

            foreach (var post in posts)
            {
                if (i == 4)
                {
                    break;
                }

                var panel = new Panel();

                var image = new Image { ImageUrl = "../Images/post/" + post.URL, Width=100 };

                var labelTitle = new Label { Text = post.TITLE };

                var labelText = new Label { Text = post.TEXT };

                var linkButton = new LinkButton { Text = "Read more...", PostBackUrl = "Post.aspx?id=" + post.UNIQUE_ID };

                panel.Controls.Add(image);
                panel.Controls.Add(labelTitle);
                panel.Controls.Add(labelText);
                panel.Controls.Add(linkButton);

                pnlPosts.Controls.Add(panel);
                i = i++;
            }
        }
        protected void Unnamed13_Click(object sender, EventArgs e)
        {
            Load3More();
        }

        private void Load3More()
        {
            
        }
    }
}