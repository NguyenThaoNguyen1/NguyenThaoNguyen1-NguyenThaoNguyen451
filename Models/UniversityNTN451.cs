using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace  NguyenThaoNguyen451.Models
{

    public class UniversityNTN451
    {
      
        [Key]
        public string? UniversityId {get; set;}
        public string? UniversityName {get; set;} 
    }
}