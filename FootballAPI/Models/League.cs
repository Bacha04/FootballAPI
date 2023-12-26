using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FootballAPI.Models
{
    public class League
    {
        public League()
        {
            Teams = new List<Team>();
        }

        public int Id { get; set; }

        [Display(Name = "Назва ліги")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string LeagueName { get; set; } = null!;

        [Display(Name = "Країна")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string LeagueCountry { get; set; } = null!;

        [Display(Name = "Кількість команд")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int NumOfTeams { get; set; }

        [Display(Name = "Партнер ліги")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int PartnerId { get; set; }

        [Display(Name = "Титульний спонсор")]
        public virtual Partner Partner { get; set; } = null!;

        public virtual ICollection<Team> Teams { get; set; }
    }
}
