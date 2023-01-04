using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace  NguyenThaoNguyen451.Models
{

    public class  NTN451
    {
      
        [Key]
        public string? NTNId {get; set;}
        public string? NTNName {get; set;} 
    }
}