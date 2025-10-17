using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerAnalyticModels
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Position { get; set; }


        public int ClubId { get; set; }
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        

    }
}
