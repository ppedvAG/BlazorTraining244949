using System.ComponentModel.DataAnnotations;

namespace BlazorTraining244949.Components.Pages.Modul05
{
    public class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10, MinimumLength =3, ErrorMessage = "Min 3  Maximal 10 Zeichen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(1, 120, ErrorMessage = "Alter muss zwischen 1 und 120 liegen")]
        public int Alter { get; set; } //doofes property
        [Required(ErrorMessage = "Da muss was rein")]
        public  DateTime GebDat { get; set; }
    }
}
