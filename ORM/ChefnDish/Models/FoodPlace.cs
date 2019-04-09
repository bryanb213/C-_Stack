using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace ChefnDish.Models
{
    public class  Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required]
        public string FirstName {get;set;}

        [Required]
        public string LastName {get;set;}

        [Required]
        [Range(typeof(DateTime), "1/1/1920", "12/31/2001",
        ErrorMessage = "Must be 18 or older")]
        public DateTime Birthday {get;set;}

        public int Age {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Dish> CreatedDishes {get;set;}
        
    }

    public class Dish
    {
        public int DishId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Tastiness { get; set; }


        [Required]
        public int Calories { get; set; }


        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int ChefId  {get;set;}
        public Chef Creator {get;set;}
    }

}