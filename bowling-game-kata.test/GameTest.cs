using Xunit;
using System;

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

        [Fact]
        public void Should_NotCalculateSpareBonus_When_NotRolledSameFrame()
        {
            Game game = new Game();

            game.Roll(3);
            game.Roll(5);
            game.Roll(5);
            game.Roll(2);

            Assert.Equal(15, game.TotalScore);
        }

        [Fact]
        public void Should_NotCalculateStrikeBonus_When_FrameSecondRoleKnockedDown10Pins()
        {
            Game game = new Game();

            game.Roll(0);
            game.Roll(10);
            game.Roll(5);
            game.Roll(2);

            Assert.Equal(22, game.TotalScore);
        }
    }
}
