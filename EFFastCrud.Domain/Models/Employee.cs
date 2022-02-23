using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFFastCrud.Connections.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }


        [Column("birth_date")]
        public DateTime BirthDate { get; set; }


        [Column("card_number")]
        public string CardNumber { get; set; }


        [Column("email")]
        public string Email { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
