open System

type Product = { Code: int; Units: int; Price: float }

let createProduct () =
    let input = Console.ReadLine().Split(" ")
    let code = int32 input.[0]
    let units = int32 input.[1]
    let pricePerUnit = double input.[2]

    { Code = code
      Units = units
      Price = pricePerUnit }

let calcTotal (p1: Product, p2: Product) =
    (p1.Price * float (p1.Units))
    + (p2.Price * float (p2.Units))

let product1 = createProduct ()
let product2 = createProduct ()

let total = calcTotal (product1, product2)
printf "VALOR A PAGAR: R$ %.2f\n" total
