using Xunit;
using OpeningMentor.Chess.Model.MoveText;

namespace OpeningMentor.Chess.Model.Test
{
    public class GameTest
    {
        [Fact]
        public void can_create()
        {
            new Game();
        }

        [Fact]
        public void MoveText_should_return_a_MoveTextEntryList()
        {
            Assert.IsType<MoveTextEntryList>(new Game().MoveText);
        }
    }
}
