using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProjetoFinal.Data.Models
{
    public class Championship
    {
        public int Id { get; set; }

        public int ChampionID { get; set; }

        public virtual Characters Champion { get; set; }

        public List<int> CharactersID { get; set; }
    }
}
