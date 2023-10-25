using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaGo.DataModels.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }
        public string Createdon { get; set; }
        public string UpdatedOn { get; set; }
    }
}
