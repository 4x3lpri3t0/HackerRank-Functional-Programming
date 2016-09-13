module Filter_Array
open System

[<EntryPoint>]
let main argv = 
    let inputs =
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile (fun s -> s <> null)
        |> Seq.map int
        |> List.ofSeq
    List.filter (fun x -> x < (List.head inputs)) (List.tail inputs)
    |> List.iter (printfn "%i")
    0 // exit