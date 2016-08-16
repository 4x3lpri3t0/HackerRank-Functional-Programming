open System
open _01___Introduction

[<EntryPoint>]
let main argv = 
    let a = Console.ReadLine() |> int
    let b = Console.ReadLine() |> int
    let solveMeFirstFP = SolveMeFirstFP.create a b
    let sum = solveMeFirstFP.Sum
    printfn "%d" (sum)
    
    0 // return an integer exit code