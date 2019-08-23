using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GOT.Models
{
    public class Show
    {
        [Key]
        public int ShowId{get;set;}
        [Required]
        [MinLength(3, ErrorMessage="Title must be at least 3 chracters")]
        public string Title{get;set;}
        [Required]
        public string Genre{get;set;}
        public DateTime Date {get;set;}
        public string Location {get;set;}

        public User Host{get;set;}

        public List<UserShow> UserShows{get;set;}
        public DateTime CreatedAt {get;set;}= DateTime.Now;
        public DateTime UpdatedAt {get;set;}= DateTime.Now;

        public class DateValidatorAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if((DateTime)value > DateTime.Today)
                {
                    return new ValidationResult("Please enter a date between 1988 and present");
                }
                return ValidationResult.Success;
            }
        }
    }
}