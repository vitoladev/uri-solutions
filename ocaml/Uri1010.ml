type product = { code: int; units: int; price: float }

let create_product() = 
  let code, units, price = Scanf.scanf "%i %i %f\n" 
      (fun a b c -> a, b, c) in
  { code; units; price }

let calc_total p1 p2 =
  (p1.price *. float(p1.units)) +. (p2.price *. float(p2.units))

let () =
  let product1 = create_product() in
  let product2 = create_product() in

  let total = calc_total product1 product2 in
  Printf.printf "VALOR A PAGAR: R$ %.2f\n" total