using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttainTaskSupportSystem.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}
