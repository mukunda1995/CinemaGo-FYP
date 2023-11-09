using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaGo.DataModels.Models
{
    public partial class ContactUs
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
    }
}
