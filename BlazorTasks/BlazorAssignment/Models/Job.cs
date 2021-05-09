using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorAssignment.Models
{
    public class Job
    {
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
        
        [JsonPropertyName("salary")]
        public int Salary { get; set; }
    }
}