open System

let average = 
  let a = float(Console.ReadLine())
  let b = float(Console.ReadLine())
  let c = float(Console.ReadLine())
  ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0

printf "MEDIA = %.1f\n" average