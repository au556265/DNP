using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;

namespace BlazorAssignment.Models
{
    public class Person
    {
        [JsonPropertyName("id")] public int Id { get; set; }

        [JsonPropertyName("firstName")]
        [MinLength(3)]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        [MinLength(3)]
        public string LastName { get; set; }

        [JsonPropertyName("hairColor")]
        [ValidateHairColor]
        public string HairColor { get; set; }

        [JsonPropertyName("eyeColor")]
        [NotNull]
        [ValidateEyeColor]
        public string EyeColor { get; set; }

        [JsonPropertyName("age")]
        [NotNull, Range(0, 125)]
        public int Age { get; set; }

        [JsonPropertyName("weight")]
        [NotNull, Range(1, 250)]
        public float Weight { get; set; }

        [JsonPropertyName("height")]
        [NotNull, Range(30, 250)]
        public int Height { get; set; }

        [JsonPropertyName("sex")]
        [NotNull]
        [ValidateGender]
        public string Sex { get; set; }

        public void Update(Person toUpdate)
        {
            Age = toUpdate.Age;
            Height = toUpdate.Height;
            HairColor = toUpdate.HairColor;
            Sex = toUpdate.Sex;
            Weight = toUpdate.Weight;
            EyeColor = toUpdate.EyeColor;
            FirstName = toUpdate.FirstName;
            LastName = toUpdate.LastName;
        }
    }

    public class ValidateHairColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "blond", "red", "brown", "black",
                "white", "grey", "leverpostej"
            }.ToList();
            if (value != null && valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(
                "Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Leverpostej");
        }
    }

    public class ValidateEyeColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {

                "brown", "grey", "green", "blue",
                "amber", "hazel"
            }.ToList();
            if (value != null && valid.Contains(value?.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
        }
    }

    public class ValidateGender : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {

                "f", "m"
            }.ToList();
            if (value != null && valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Valid gender is: F, M ");
        }
    }

}
