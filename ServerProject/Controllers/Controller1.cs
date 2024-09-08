using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace ServerProject.Controllers;

public static class AppSettings
{
    public static IConfiguration Configuration { get; private set; }

    public static void Initialize(IConfiguration configuration)
    {
        Configuration = configuration;
    }
}

[ApiController]
[Route("experiencepaymentsuccess/v1/")]
public class BookingFlowController : ControllerBase
{
    [HttpPut]
    [Route("confirmbooking")]
    public void ConfirmBooking(string reservationToken)
    {
        var connectionString = AppSettings.Configuration["MyDbConnection"];
        var connection = new SqlConnection(connectionString);
        connection.Open();
        var idQuery = connection.Query<int>("SELECT BookingID FROM Reservations WHERE ReservationToken = '" + reservationToken + "'");
        connection.Execute("UPDATE Bookings SET Confirmed = 1 WHERE BookingID = " + idQuery.First().ToString());
        connection.Execute("DELETE FROM Reservations WHERE ReservationToken = '" + reservationToken + "'");
    }
    
    // To test creativity, please add as many actions you think a payment success controller would need on a general user ticketing platform
    // An example > Confirm booking (reservation token)

}