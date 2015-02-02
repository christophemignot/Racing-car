namespace TDDMicroExercices.TurnTicketDispenser
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TDDMicroExercises.TurnTicketDispenser;

    [TestClass]
    public class TicketDispenserTest
    {
        [TestMethod]
        public void WhenInitializedThenInstanceOk()
        {
            var dispenser = new TicketDispenser();

            Assert.IsNotNull(dispenser);
        }

        [TestMethod]
        public void WhenFirstTicketThenNumberIs0()
        {
            var dispenser = new TicketDispenser();
            
            var ticket = dispenser.GetTurnTicket();
            
            Assert.AreEqual(0, ticket.TurnNumber);
        }

        [TestMethod]
        public void WhenSecondAndThirdTicketThenNumberAre1And2()
        {
            var dispenser = new TicketDispenser();
            
            var ticket1 = dispenser.GetTurnTicket();
            var ticket2 = dispenser.GetTurnTicket();
            
            Assert.AreEqual(1, ticket1.TurnNumber);
            Assert.AreEqual(2, ticket2.TurnNumber);
        }


        [TestMethod]
        public void WhenFourthTicketThenNumberIsNot0()
        {
            var dispenser = new TicketDispenser();

            var ticket = dispenser.GetTurnTicket();

            Assert.AreNotEqual(0, ticket.TurnNumber);
        }
    }
}
