using TDDMicroExercises._3_TurnTicketDispenser;

namespace TDDMicroExercises.TurnTicketDispenser
{
    public class TicketDispenser
    {
        private INumberProvider numberProvider;

        public TicketDispenser():this(new NumberProvider()) {

        }
        public TicketDispenser(INumberProvider numberProvider)
        {
            this.numberProvider = numberProvider;
        }

        public TurnTicket GetTurnTicket()
        {
            int newTurnNumber = numberProvider.GetNextTurnNumber();
            TurnTicket newTurnTicket = new TurnTicket(newTurnNumber);

            return newTurnTicket;
        }
    }

    internal class NumberProvider : INumberProvider
    {
        public int GetNextTurnNumber()
        {
            return TurnNumberSequence.GetNextTurnNumber();
        }
    }
}
