using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Poistion { get; set; }
        public string Role { get; set; }
    }
    
}