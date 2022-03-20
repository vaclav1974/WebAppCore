using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UnitTests;
using WebAppCoreDb.Interface;

namespace WebAppCoreDb.Models.Identity
{
    public class AppUser : IdentityUser,IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Maximální délka 50 znaků!")]
        public override string UserName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Maximální délka 50 znaků!")]
        public string Surrname { get; set; }
        public override bool EmailConfirmed { get; set; }

        [DataType(DataType.EmailAddress)]
        public override string Email { get; set; }

        [DataType(DataType.Password)]
        public override string PasswordHash { get; set; }

        public override int AccessFailedCount { get; set; }
        [DataType(DataType.DateTime)]
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
