using System.ComponentModel.DataAnnotations;

namespace FinalCinema.Models
{
    public class Country
    {
        public Country()
        {
            Studios = new HashSet<Studio>();
            Cinemas = new HashSet<Cinema>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим")]
        [Display(Name = "Країна")]
        public string CountryName { get; set; }

        public virtual ICollection<Studio> Studios { get; set; }
        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}
