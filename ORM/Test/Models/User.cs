using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models {
    public class User {

        [Key]
        public int UserId { get; set; }

        [RegularExpression("^[a-zA-Z]{1,25}$", ErrorMessage="Numbers are not allowed in your first name")]
        [Required (ErrorMessage = "First name is required.")]
        [MinLength (2, ErrorMessage = "First Name must be at least 2 characters.")]
        [Display (Name = "First Name:")]
        public string FirstName { get; set; }

        [RegularExpression("^[a-zA-Z]{1,25}$", ErrorMessage="Numbers are not allowed in your last name")]
        [Required (ErrorMessage = "Last name is required.")]
        [MinLength (2, ErrorMessage = "Last Name must be at least 2 characters.")]
        [Display (Name = "Last Name:")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Email is required.")]
        [EmailAddress]
        [Display (Name = "Email Address:")]
        public string Email { get; set; }

        public List<RSVP> RSVPs { get; set; } = new List<RSVP>();

        [Required (ErrorMessage = "Password is required.")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain a letter, number (0-9) and special character (e.g. !@#$%^&*)")]
        [DataType (DataType.Password)]
        [Display (Name = "Password:")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare ("Password", ErrorMessage = "The passwords do not match.")]
        [DataType (DataType.Password)]
        [Display (Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }
    }
}