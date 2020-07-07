using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication2.Models
{
    public class UserInformation
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Occupation { get; set; }
        public string Mobile_Number { get; set; }
        
    }

    
        
}