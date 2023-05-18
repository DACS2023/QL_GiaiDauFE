
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace QL_GiaiDauFE.Models
{
    public class User
    {
       
        public string IdUser { get; set; }

        public string FullName { get; set; }

        public string gender;
        public string Gender { get => gender; set => gender = value; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string Role { get; set; }

        public bool TrangThai { get; set; }


    }
}