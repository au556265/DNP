using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorAssignment.Models
{
    public class Job
    {
     
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}