using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ProjetoFinal.Data.Models
{
    [Table("Tabela_de_Personagens")]
    public class Characters
    {
        [Key]
        [Column("CharacterID")]
        public int Id { get; set; }

        [Required]
        [Column("CharacterNAME")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Column("CharacterAGE")]
        public int Age { get; set; }

        [Required]
        [Column("Power")]
        public int Power { get; set; }

        [Required]
        [Column("TotalFIGHTS")]
        public int Fights { get; set; }

        [Required]
        [Column("VictoryFIGHTS")]
        public int Victory { get; set; }

        [Required]
        [Column("DefeatFIGHTS")]
        public int Defeat { get; set; }

        //public virtual ICollection<Championship> Championships { get; set; }

        public Characters()
        {

        }

        public Characters(int characterId, string characterName, int characterAge, int power, int fights, int victory, int defeat)
        {
            Id = characterId;
            Name = characterName;
            Age = characterAge;
            Power = power;
            Fights = fights;
            Victory = victory;
            Defeat = defeat;

        }
    }
}
