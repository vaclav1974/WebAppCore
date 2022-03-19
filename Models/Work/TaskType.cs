using WebAppCoreDb.Interface;
using WebAppCoreDb.Models.Identity;

namespace WebAppCoreDb.Models.Work
{
    public class TaskType : IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Department Department { get; set; }
    }
}