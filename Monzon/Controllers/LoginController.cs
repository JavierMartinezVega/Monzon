

namespace Monzon.Controllers
{
    using System.Net;
    using System.Web.Http;
    using BL.Model;
    using BL.Repository;

    public class LoginController
    {
        /// <summary>
        /// Authenticates a Login.
        /// </summary>
        /// <param name="login">Login to be authenticated</param>
        /// <returns>Authenticated Login</returns>
        [Route("api/Login/Authenticate")]
        [AllowAnonymous]
        public LOGIN Authenticate(LOGIN login)
        {

            try
            {
                var loginAux = LoginRepository.Instance.CheckUser(login);

                if (loginAux == null)
                {
                    throw new HttpResponseException(HttpStatusCode.Unauthorized);
                }

                return loginAux;
            }
            catch 
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}