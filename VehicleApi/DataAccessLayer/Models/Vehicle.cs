using System.ComponentModel.DataAnnotations;

namespace HyperCaseProject.DataAccessLayer.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string? Color { get; set; }
    }
}
