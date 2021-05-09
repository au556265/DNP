using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace BlazorAssignment.Models
{
    public class User
    {
        [JsonPropertyName("userName")]
        [MinLength(3)]
        public string UserName { get; set; }
        [JsonPropertyName("password")]
        [MinLength(3)]
        public string Password { get; set; }
        [JsonPropertyName("role")]
        [ValidateRole]
        public string Role { get; set; }
    }

    public class ValidateRole : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "admin", "editor", "customer"
            }.ToList();
            if (value != null && valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Valid roles are: Admin, Editor, Customer");
        }
    }
}