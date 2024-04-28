using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using WebAppAutorization.Models.Validators;

namespace WebAppAutorization.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        [NameExists]
        [FirstCapital(ErrorMessage = "Must be first capitel")]
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        public string SerName { get; set; }
        public string TgNick {  get; set; }
        public decimal Number {  get; set; }

        public DateTime DataTravell { get; set; }

        public bool Private { get; set; }


        [Required(ErrorMessage = "Enter Price")]
        public decimal Price { get; set; }
        public bool Privat { get; internal set; }
    }
}
