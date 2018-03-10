// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

(*
user:
ordanary(math teacher)

Requirements:
    Purpose:
    to insert and add 3 ints to give a result.

Behaviour:
    I/O:
    a pop up to add 3 ints
    input:
    inserting 3 ints and only 3 ints
    output:
    result of adding them, 
    return error if they are not valid.

Steps (breaking down our program):
    // First version (general overview/summary)
    first to get the input 
    they are 3 valid int input
    if int true then pass to second int
 

    // Second version (a bit more detail)
    if input is valid then
        display sum result of the ints
    else
        error:invalid amount
        error: input must be an int 

    // Third version (further detail)
    if the input amount is valid then
        add them together and display the result
        print out the sum of the number together
    else
        Error: invalid amount of user input

    // Fourth version (breaking it apart even more, some part now look even more like pseudo-code)
    If the correct inpuyt is taken in then 
        print "%i" (x+y+z)
        0
    else
        Error: 
        1

*)
open System
open System.Numerics

let rec getIntinput n=
    printf"enter an integer(whole number like 3, 5 ,75) for %i: " n
    let parsedx, resultx = Console.ReadLine() |> BigInteger.TryParse
    if parsedx then 
       resultx 
    else 
        printfn"ERROR: invalid input. must be an integer" 
        getIntinput n

[<EntryPoint>]
let main argv = 
    
    let x = getIntinput 1
    let y = getIntinput 2
    let z = getIntinput 3
   
    printfn"%A"( x + y + z )

    0 // return an integer exit code
