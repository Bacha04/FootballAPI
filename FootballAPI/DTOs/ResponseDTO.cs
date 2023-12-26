using FootballAPI.Models;

namespace FootballAPI.DTOs
{
    public class ResponseDTO
    {
        public int Page { get; set; }
        public int CurrentPage { get; set; }
        public List<Partner> Partners = new List<Partner>();
    }
}
