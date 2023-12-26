using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FootballAPI.Models
{
    public class Partner
    {
        public Partner()
        {
            Leagues = new List<League>();
        }

        public int Id { get; set; }

        [Display(Name = "Назва компанії")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string PartnerName { get; set; } = null!;

        [Display(Name = "Сфера діяльності")]
        public string? TypeOfActivity { get; set; }

        [Display(Name = "Країна")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Country { get; set; } = null!;

        public virtual ICollection<League> Leagues { get; set; }
    }
}
