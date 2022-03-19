using Microsoft.AspNetCore.Identity;
using WebAppCoreDb.Interface;

namespace WebAppCoreDb.Models.Identity
{
    public class Role:IdentityRole,IEntity
    {
        public int Id { get; set; }
        public override string Name { get; set; }

        public int AccessLevel { get; set; }

        public override string NormalizedName { get; set; }

        
    }
}