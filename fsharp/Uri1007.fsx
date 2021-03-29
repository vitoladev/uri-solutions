open System

let difference =
    let a = int (Console.ReadLine())
    let b = int (Console.ReadLine())
    let c = int (Console.ReadLine())
    let d = int (Console.ReadLine())
    (a * b) - (c * d)

printf "DIFERENCA = %i\n" difference
