using ProjetoFinal.Business.Services;
using ProjetoFinal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_UnitTest.Business.Services
{
    public class ChampionshipServiceTest
    {
        [Fact]
        public async Task TheLast16_Ok()
        {
            var characters = new List<Characters>();
            
            characters.Add(new Characters { Name = "Kirby", Age = 31, Power = 71, Fights = 939, Defeat = 261, Victory = 678 });
            characters.Add(new Characters { Name = "Mario", Age = 25, Power = 34, Fights = 817, Defeat = 144, Victory = 673 });
            characters.Add(new Characters { Name = "Peach", Age = 23, Power = 28, Fights = 546, Defeat = 115, Victory = 431 });
            characters.Add(new Characters { Name = "Bowser", Age = 34, Power = 72, Fights = 837, Defeat = 490, Victory = 347 });
            characters.Add(new Characters { Name = "Luigi", Age = 25, Power = 3, Fights = 590, Defeat = 447, Victory = 143 });
            characters.Add(new Characters { Name = "Donkey Kong", Age = 19, Power = 70, Fights = 328, Defeat = 113, Victory = 215 });
            characters.Add(new Characters { Name = "Link", Age = 17, Power = 95, Fights = 795, Defeat = 19, Victory = 776 });
            characters.Add(new Characters { Name = "Zelda", Age = 17, Power = 91, Fights = 270, Defeat = 90, Victory = 180 });
            characters.Add(new Characters { Name = "Yoshi", Age = 35, Power = 67, Fights = 922, Defeat = 368, Victory = 554 });
            characters.Add(new Characters { Name = "Samus", Age = 32, Power = 29, Fights = 883, Defeat = 110, Victory = 773 });
            characters.Add(new Characters { Name = "Meta Knight", Age = 1000, Power = 83, Fights = 954, Defeat = 316, Victory = 638 });
            characters.Add(new Characters { Name = "King Dedede", Age = 48, Power = 74, Fights = 527, Defeat = 483, Victory = 44 });
            characters.Add(new Characters { Name = "Falco", Age = 37, Power = 73, Fights = 952, Defeat = 344, Victory = 608 });
            characters.Add(new Characters { Name = "Pokemon Trainer", Age = 15, Power = 54, Fights = 700, Defeat = 267, Victory = 433 });
            characters.Add(new Characters { Name = "Pikachu", Age = 4, Power = 97, Fights = 920, Defeat = 116, Victory = 804 });
            characters.Add(new Characters { Name = "Ness", Age = 13, Power = 30, Fights = 970, Defeat = 966, Victory = 4 });

            var winners = await new ChampionshipService().TheLast16(characters);

            Assert.Equal(8, winners.Count);
        }
        
    }
}
