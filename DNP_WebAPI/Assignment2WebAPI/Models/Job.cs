using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment2WebAPI.Models
{

    public class Job
    {
        [JsonPropertyName("jobId"), Key]
        public int JobId { get; set; }

        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
        
        [JsonPropertyName("salary")]
        public int Salary { get; set; }
    }
}