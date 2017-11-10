
namespace Monzon.Pages
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Text.RegularExpressions;
    using BL.Model;

    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = (LOGIN)Session["USER"];

                if (user != null)
                {
                    txtName.Text = user.FIRST_NAME + " " + user.LAST_NAME;
                    txtEmail.Text = user.EMAIL;
                }
            }
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

        protected void Unnamed13_Click(object sender, EventArgs e)
        {

            //SEND EMAIL


            //var user = (LOGIN)Session["USER"];

            //if (user != null)
            //{
            //    using (var db = new MonzonEntities())
            //    {
            //        var dbUser = db.LOGIN.FirstOrDefault(l => l.UNIQUE_ID == user.UNIQUE_ID);

            //        if (txtPasswordNew.Text == dbUser.PASSWORD)
            //        {
            //            if (txtPasswordNew.Text != txtPasswordNewRepeat.Text)
            //            {
            //                //LAS PASSWORD NUEVAS NO COINCIDEN
            //            }
            //            else
            //            {
            //                dbUser.PASSWORD = txtPasswordNew.Text;
            //                db.LOGIN.Attach(dbUser);
            //                db.Entry(dbUser).State = EntityState.Modified;
            //                db.SaveChanges();
            //            }
            //        }
            //        else
            //        {
            //            //LA PASSWORD ANTIGUA NO ES CORRECTA
            //        }
            //    }
            //}
        }
    }
}