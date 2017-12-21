
namespace Monzon.Pages
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Web.UI.WebControls;
    using BL.Model;
    using BL.Repository;

    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlEmail.Visible = false;
                btnEmail.Attributes.Remove("class");

                pnlApply.Visible = false;
                btnApply.Attributes.Remove("class");

                pnlPassword.Visible = false;
                btnPassword.Attributes.Remove("class");

                pnlPersonal.Visible = true;
                btnPersonal.Attributes.Add("class", "active");

                pnlActive.Visible = false;
                btnActive.Attributes.Remove("class");

                var user = (LOGIN)Session["USER"];

                LeaderData();
                //if (user != null)
                //{
                //    txtName.Text = user.FIRST_NAME;
                //    txtSurname.Text = user.LAST_NAME;
                //    txtPhone.Text = user.PHONE;
                //    txtEmailOld.Text = user.EMAIL;
                //}
                //else
                //{
                //    Response.Redirect("");
                //}
            }
        }

        protected void PasswordBtn_Click(object sender, EventArgs e)
        {
            pnlEmail.Visible = false;
            btnEmail.Attributes.Remove("class");

            pnlApply.Visible = false;
            btnApply.Attributes.Remove("class");

            pnlPassword.Visible = true;
            btnPassword.Attributes.Add("class", "active");

            pnlPersonal.Visible = false;
            btnPersonal.Attributes.Remove("class");

            pnlActive.Visible = false;
            btnActive.Attributes.Remove("class");
        }

        protected void EmailBtn_Click(object sender, EventArgs e)
        {
            pnlEmail.Visible = true;
            btnEmail.Attributes.Add("class", "active"); 

            pnlPassword.Visible = false;
            btnPassword.Attributes.Remove("class");

            pnlPersonal.Visible = false;
            btnPersonal.Attributes.Remove("class");

            pnlApply.Visible = false;
            btnApply.Attributes.Remove("class");

            pnlActive.Visible = false;
            btnActive.Attributes.Remove("class");
        }

        protected void ActiveBtn_Click(object sender, EventArgs e)
        {
            pnlEmail.Visible = false;
            btnEmail.Attributes.Remove("class");

            pnlApply.Visible = false;
            btnApply.Attributes.Remove("class");

            pnlPassword.Visible = false;
            btnPassword.Attributes.Remove("class");

            pnlPersonal.Visible = false;
            btnPersonal.Attributes.Add("class", "active");

            pnlActive.Visible = true;
            btnActive.Attributes.Add("class", "active");
        }
        
        protected void PersonalBtn_Click(object sender, EventArgs e)
        {
            pnlEmail.Visible = false;
            btnEmail.Attributes.Remove("class");

            pnlApply.Visible = false;
            btnApply.Attributes.Remove("class");

            pnlPassword.Visible = false;
            btnPassword.Attributes.Remove("class");

            pnlPersonal.Visible = true;
            btnPersonal.Attributes.Add("class", "active");

            pnlActive.Visible = false;
            btnActive.Attributes.Remove("class");
        }

        protected void ApplyBtn_Click(object sender, EventArgs e)
        {
            pnlEmail.Visible = false;
            btnEmail.Attributes.Remove("class");

            pnlPassword.Visible = false;
            btnPassword.Attributes.Remove("class");

            pnlPersonal.Visible = false;
            btnPersonal.Attributes.Remove("class");

            pnlApply.Visible = false;
            btnApply.Attributes.Add("class", "active");

            pnlActive.Visible = false;
            btnActive.Attributes.Remove("class");
        }


        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            var user = (LOGIN)Session["USER"];

            if (user != null)
            {
                using (var db = new MonzonEntities())
                {
                    var dbUser = db.LOGIN.FirstOrDefault(l => l.UNIQUE_ID == user.UNIQUE_ID);
                    //dbUser.FIRST_NAME = lblName.Text + " " + ;
                    //dbUser.LAST_NAME = txtSurname.Text;
                    //dbUser.PHONE = txtPhone.Text;

                    db.LOGIN.Attach(dbUser);
                    db.Entry(dbUser).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {
            //if (txtEmailNew.Text != txtEmailNewRepeat.Text)
            //{
            //    //LOS EMAILS NO COINCIDEN
            //    return;
            //}

            //if (!ValidEmail(txtEmailNew.Text))
            //{
            //    //NO ES UN MAIL VALIDO
            //}

            //var user = (LOGIN)Session["USER"];

            //if (user != null)
            //{
            //    using (var db = new MonzonEntities())
            //    {
            //        var dbUser = db.LOGIN.FirstOrDefault(l => l.UNIQUE_ID == user.UNIQUE_ID);
            //        dbUser.EMAIL = txtEmailNew.Text;
            //        db.LOGIN.Attach(dbUser);
            //        db.Entry(dbUser).State = EntityState.Modified;
            //        db.SaveChanges();
            //    }
            //}
        }

        private Boolean ValidEmail(String email)
        {
            const string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected void btnMessageLeader_Click(object sender, EventArgs e)
        {
            
        }
        
        protected void Unnamed13_Click(object sender, EventArgs e)
        {
            var user = (LOGIN)Session["USER"];

            if (user != null)
            {
                using (var db = new MonzonEntities())
                {
                    var dbUser = db.LOGIN.FirstOrDefault(l => l.UNIQUE_ID == user.UNIQUE_ID);

                    if (txtPasswordNew.Text == dbUser.PASSWORD)
                    {
                        if (txtPasswordNew.Text != txtPasswordNewRepeat.Text)
                        {
                            //LAS PASSWORD NUEVAS NO COINCIDEN
                        }
                        else
                        {
                            dbUser.PASSWORD = txtPasswordNew.Text;
                            db.LOGIN.Attach(dbUser);
                            db.Entry(dbUser).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        //LA PASSWORD ANTIGUA NO ES CORRECTA
                    }
                }
            }
        }

        private void LeaderData()
        {
            var leader = LoginRepository.Instance.GetLeader();
            lblUserData.Text = leader.LOGIN1;
            lblNameData.Text = leader.FIRST_NAME + " " + leader.LAST_NAME;
        }

        private void R4Data()
        {
            var r4Members = LoginRepository.Instance.GetR4Members();

            foreach (var r4 in r4Members)
            {
                var memberPanel = new Panel();

                var lUser = new Label {Text = "User: "};
                memberPanel.Controls.Add(lUser);

                var lUserData = new Label {Text = r4.LOGIN1};
                memberPanel.Controls.Add(lUserData);

                var lName = new Label { Text = "Name: " };
                memberPanel.Controls.Add(lName);

                var lNameData = new Label { Text = r4.FIRST_NAME + " " + r4.LAST_NAME };
                memberPanel.Controls.Add(lNameData);

            }
        }
    }
}