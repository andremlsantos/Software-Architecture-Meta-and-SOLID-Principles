using System;

namespace SOLID.SRP.Violation
{
    /*
     * Lets suppose this projects is a web app, that allows users to buy tickets on trains
     * Works on a website and on the point of service terminals
     * MVVM application
     *
     * PaymentModel provides the ability to buy a ticket
     */
    public class PaymentModel
    {
        private decimal _cashAccepted;

        /*
         * Whats the problem here?
         * Pay by credit card or by cash are coupled
         *
         * PaymentModel depends on TicketDetails, PaymentDetails and ProcessingCenterGateway
         * It knows too much
         */
        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment,
                              Action onPayChangeToMobilePhone)
        {
            if (payment.Method == PaymentMethod.CreditCard)
            {
                ChargeCard(ticket, payment);
            }
            else
            {
                AcceptCash(ticket);
                DispenseChange(ticket, onPayChangeToMobilePhone);
            }
        }

        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }

        private void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        private void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }
    }

    internal class ProcessingCenterGateway
    {
        public void Charge(decimal ticketPrice, PaymentDetails paymentDetails)
        {
            //charging process
        }
    }
}