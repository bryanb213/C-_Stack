using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models {
    public class Event {

        [Key]
        public int EventId { get; set; }

        [Required (ErrorMessage = "Event name is required.")]
        [MinLength (2, ErrorMessage = "Event name must be at least 2 characters.")]
        [Display (Name = "Title:")]
        public string Title { get; set; }

        [Required (ErrorMessage = "Event date is required.")]
        [Display (Name = "Event Date:")]
        public DateTime EventDate { get; set; }

        [Required (ErrorMessage = "Event time is required.")]
        [MinLength (2, ErrorMessage = "Event must be in the future.")]
        [Display (Name = "Event Time:")]
        public string EventTime { get; set; }

        [Required (ErrorMessage = "Event Duration is required.")]
        [Display (Name = "Duration:")]
        public int EventDuration {get;set;}



        public int UserId { get; set; }

        public User Creator { get; set; }

        public List<RSVP> Guests { get; set; } = new List<RSVP>();

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}