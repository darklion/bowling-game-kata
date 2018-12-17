using Xunit;

namespace bowling_game_kata.test
{
    public class GameTest
    {  
        [Fact]
        public void Should_FirstRollX_TotalScoreX()
        {
            Game game = new Game();

            game.Roll(1);

            Assert.True(game.TotalScore == 1);

        }

        [Fact]
        public void Should_Calculate20_When_AllRolls1()
        {
            Game game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.True(game.TotalScore == 20);
        }

        [Fact]
        public void Should_Calculate80_When_AllRolls4()
        {
            Game game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(4);
            }

            Assert.True(game.TotalScore == 80);
        }

        [Fact]
        public void Should_CalculateSpareBonus_When_NextRolled()
        {
            Game game = new Game();

            game.Roll(5);
            game.Roll(5);
            game.Roll(4);

            Assert.Equal(18, game.TotalScore);
        }


        [Fact]
        public void Should_CalculateStrikeBonus_When_NextTwoRolled()
        {
            Game game = new Game();

            game.Roll(10);
            game.Roll(5);
            game.Roll(4);

            Assert.Equal(28, game.TotalScore);
        }
    }
}
