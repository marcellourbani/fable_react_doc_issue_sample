module App


open Fable.React.Props

module R = Fable.React.Standard
module X = Fable.React.Helpers
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

    R.div []
        [ R.button [ OnClick(fun _ -> dispatch Decrement) ] [ X.str "-" ]
          R.div [] [ X.str (sprintf "%A" model) ]
          R.button [ OnClick(fun _ -> dispatch Increment) ] [ X.str "+" ] ]

open Elmish
open Elmish.HMR

Program.mkSimple init update view
|> Program.withReact "elmish-app"
|> Program.run
