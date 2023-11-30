using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HyperCaseProject.DataAccessLayer.Models
{
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        [JsonIgnore]
        public bool Headlights { get; set; } //on-off, true-false
        public string HeadlightsStatus
        {
            get 
            {
                return Headlights ? "On" : "Off";
            }
        }
    }
}
