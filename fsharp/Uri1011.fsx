open System

let volume =
  let radius = int (Console.ReadLine())
  let pi = 3.14159
  (4.0 / 3.0) * pi * (float(radius) ** 3.0)

printf "VOLUME = %.3f\n" volume