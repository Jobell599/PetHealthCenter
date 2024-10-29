using Microsoft.IdentityModel.Protocols.Configuration;
using System.ComponentModel.DataAnnotations;

namespace PetHealthCenter.Domain.Entities
{
    public class Clients
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName {  get; set; }
        public string Address {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
