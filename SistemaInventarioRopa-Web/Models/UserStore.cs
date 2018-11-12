using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace SistemaInventarioRopa_Web.Models
{
    public class UserStore : IUserStore<Usuario>, IUserLoginStore<Usuario>, IUserPasswordStore<Usuario>, IUserSecurityStampStore<Usuario>
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        public void Dispose()
        {

        }



    }
}