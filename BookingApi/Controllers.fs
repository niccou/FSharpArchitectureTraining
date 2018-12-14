namespace Booking.HttpApi

open Microsoft.AspNetCore.Mvc
open System.Net.Http
open System.Net

type HomeController() =
    inherit ControllerBase()
    member __.Get() = new HttpResponseMessage()

type ReservationsController()=
    inherit ControllerBase()
    member __.Post (rendition: MakeReservationRendition) =
        new HttpResponseMessage(HttpStatusCode.Accepted);

