open System

let average = 
    let a = float(Console.ReadLine())
    let b = float(Console.ReadLine())

    ((a * 3.5) + (b * 7.5)) / 11.0

printf "MEDIA = %.5f\n" average