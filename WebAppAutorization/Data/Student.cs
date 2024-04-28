using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data
{
    [Table("Student", Schema = "data")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerName {  get; set; }
        public string TgNick {  get; set; }
        public decimal Number { get; set; }
        public DateTime  DataTravell { get; set; }
        public bool Privat { get; set; }
        public decimal Price { get; set; }
    }
}