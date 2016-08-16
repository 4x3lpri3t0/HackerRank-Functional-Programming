namespace _01___Introduction

open System

module SolveMeFirstFP =
    type T = {A:int; B:int} with
        member this.Sum =
            this.A + this.B

    // constructor
    let create a b = 
        {A=a; B=b}