using System;
namespace ClientProject;

class Program
{
    static void Main(string[] args)
    {
        // Initialise the UI and start the flow:
    }

    public void SelectActivity()
    {
        // Pretend these are not commented out.
        
        /*
         WriteThisToScreen();
         WriteThatToScreen();
         Action1();
         Action2();
         if (Action3() == 1)
            if (Action4() == 2)
               if (Action5() == 3)
                  if (Action7() == 4)
                  {
                      WriteToScreen("Action7");
                  }
         else
            WriteSomethingElseToScreen();
         if (Action8())
         {
            WriteToScreen("Action8 stuff");
         }
         else
         {
            WriteToScreen("Action9 stuff");
         }
         
         if (LoggedIn())
         {
            SetLocalStorage("ActivityID", Controller.SetActivity(RetrieveActivityId());
            SelectTicketTypesAndQuantities();
         }
         else
            GoToLoginPage(Enum.CarryOnSelectAction);
         */
    }
    public void SelectTicketTypesAndQuantities() {}
    public void SelectDateAndTime() {}
    public void SelectWaivers() {}
    public void SelectAttendees() {}

    public void TakePayment() { }
    public void PaymentFail() {}

    public void PaymentSuccess(string reservationId)
    {
        // Controller.ConfirmBooking (reservationId)
        // Controller.UnknownStep1
        // Controller.UnknownStep2
        // Controller.UnknownStep3
    }


}