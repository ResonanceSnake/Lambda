open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Lambdas will go here")
    let True = fun x -> fun y -> x
    let False = fun x -> fun y -> y

    let trueValue = True(true)(false)
    let falseValue = False(true)(false)
    let If = fun x -> fun y -> fun z -> x(y)(z)
    
    printfn "%s" (If(True)("TRUE")("oops.."))
    printfn "%s" (If(False)("oops")("FALSE"))
    
    let rec Omega x acc = 
        printfn "%i" acc 
        Omega x (acc + 1)

    //Omega Omega 0
    //runs forever

    Console.WriteLine("Press any key...")
    Console.ReadKey() |> ignore
    0 // return an integer exit code
