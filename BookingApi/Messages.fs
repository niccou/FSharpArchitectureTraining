namespace Booking.HttpApi

open System

type MakeReservation = {
    Date: DateTime
    Name: String
    Email: String
    Quantity: int
}

[<AutoOpen>]
module Envelopes = 
    open System

    [<CLIMutable>]
    type Envelope<'T> = {
        Id: Guid
        Created: DateTimeOffset
        Item: 'T
    }

    let Envelop id created item = {
        Id = id
        Created = created
        Item = item
    }

    let EnvelopWithDefaults item = 
        Envelop (Guid.NewGuid()) (DateTimeOffset.Now) item
