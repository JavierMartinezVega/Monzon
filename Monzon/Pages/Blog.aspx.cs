
namespace Monzon.Pages
{
    using System;
    using System.Configuration;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using BL.Model;
    using BL.Repository;

    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
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
                panel.Attributes.Add("class", "box");


                var imagePanel = new Panel();
                imagePanel.Attributes.Add("class", "image");

                var image = new Image { ImageUrl = "../Images/post/" + post.URL, Width=100 };
                imagePanel.Controls.Add(image);

                var panelContainer = new Panel();
                panelContainer.Attributes.Add("class", "container");

                var labelTitle = new HtmlGenericControl("div");
                labelTitle.Attributes.Add("class", "title");
                labelTitle.InnerHtml = post.TITLE;


                var labelText = new HtmlGenericControl("div");
                labelText.Attributes.Add("class", "content");
                labelText.InnerHtml = post.TEXT;

                //var linkButton = new LinkButton { Text = "Read more...", PostBackUrl = "Post.aspx?id=" + post.UNIQUE_ID };

                panelContainer.Controls.Add(labelTitle);
                panelContainer.Controls.Add(labelText);

                panel.Controls.Add(imagePanel);
                panel.Controls.Add(panelContainer);

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