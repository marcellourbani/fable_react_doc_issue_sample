module App

open Fable.React.Props
open Fable.React

type Model = int

type Msg =
    | Increment
    | Decrement

let init () = 0

let update (msg: Msg) count =
    match msg with
    | Increment -> count + 1
    | Decrement -> count - 1

let view model dispatch =

    div []
        [ button [ OnClick(fun _ -> dispatch Decrement) ] [ str "-" ]
          div [] [ str (sprintf "%A" model) ]
          button [ OnClick(fun _ -> dispatch Increment) ] [ str "+" ] ]
