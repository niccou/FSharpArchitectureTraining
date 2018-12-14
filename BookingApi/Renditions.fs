namespace Booking.HttpApi

[<CLIMutable>]
type MakeReservationRendition = {
    Date: string
    Name: string
    Email: string
    Quantity: int
    }
