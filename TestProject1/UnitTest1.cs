using FormsAppEvoX;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void GameFormShowGame()
        {
            Game game1 = new() { name = "Game 1", price = 20 };
            Form1.games_list = new List<Game> { game1 };

            GameForm gf = new(game1.name);

            Assert.Equal(game1.name, gf.game1.name);
            Assert.Equal(game1.price, gf.game1.price);
        }
    }
}
