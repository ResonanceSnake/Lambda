open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Lambdas will go here")

    Console.WriteLine("Press any key...")
    Console.ReadKey() |> ignore
    0 // return an integer exit code
