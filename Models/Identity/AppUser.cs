using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAppCoreDb.Interface;

namespace WebAppCoreDb.Models.Identity
{
    public class AppUser : IdentityUser,IEntity
    {
        public int Id { get; set; }

        public override string UserName { get; set; }

        public string Surrname { get; set; }
        public override bool EmailConfirmed { get; set; }
        public override string Email { get; set; }
        public override string PasswordHash { get; set; }

        public override int AccessFailedCount { get; set; }

        public override string ConcurrencyStamp { get; set; }

        public ICollection<Role> Roles;

        public Department Department;

        protected bool IsAdmin { get; set; } = false;

        public override string ToString()
        {
            return (UserName+Surrname).ToString();
        }
    }
}
