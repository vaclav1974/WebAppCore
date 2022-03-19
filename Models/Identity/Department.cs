using WebAppCoreDb.Interface;

namespace WebAppCoreDb.Models.Identity
{
    public class Department : IEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public AppUser Leader { get; set; }   

    }
}