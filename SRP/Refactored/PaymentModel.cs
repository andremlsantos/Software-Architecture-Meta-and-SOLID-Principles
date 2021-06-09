namespace SOLID.SRP.Refactored
{
    /*
     * This is our abstraction way of buying a ticket
     * The concrete classes, both extend the base class, to implement BuyTicket() method
     */
    public abstract class PaymentModel
    {
        // we need this details to be visible for the concrete implementations
        protected TicketDetails _ticketDetails;

        protected PaymentModel(TicketDetails ticketDetails)
        {
            _ticketDetails = ticketDetails;
        }

        public abstract void BuyTicket();
    }
}
