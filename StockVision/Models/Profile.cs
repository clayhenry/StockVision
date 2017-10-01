using System;
using System.ComponentModel.DataAnnotations;
using StockVision.Models.Identity;

namespace StockVision.Models
{

    public enum SomeType
    {
        No,
        Occasional,
        Regular   
    }
    public class Profile
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime BirthDate { get; set; }
        
        [Display(Name = "Profile Picture")]
        public string Picture { get; set; }
        public SomeType SomeType { get; set; }
        public User User { get; set; }
        
    }
}