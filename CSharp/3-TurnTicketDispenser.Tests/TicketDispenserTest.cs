using FluentAssertions;
using TDDMicroExercises.TurnTicketDispenser;
using Xunit;

namespace TDDMicroExercises._3_TurnTicketDispenser
{
    public class TicketDispenserTest
    {
        [Fact]
        public void should_give_ticket_with_expected_number()
        {
            TicketDispenser ticketDispenser = new TicketDispenser(new NumberProviderFake(15));
            TurnTicket turnTicket = ticketDispenser.GetTurnTicket();
            turnTicket.TurnNumber.Should().Be(15);
        }        
    }

    internal class NumberProviderFake : INumberProvider
    {
        private int value;

        public NumberProviderFake(int value)
        {
            this.value = value;
        }

        public int GetNextTurnNumber()
        {
            return value;
        }
    }

    public interface INumberProvider
    {
        int GetNextTurnNumber();
    }
}


