module Hello_World_Multiple
open System

let rec multiPrint x = 
    if x = 0 then
        ()
    else
        printfn "Hello World"
        multiPrint (x-1)

//[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    multiPrint n
    0 // exit