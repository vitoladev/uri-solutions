open Scanf

let () =
  let x1, y1 = scanf "%f %f\n" (fun a b -> a, b) in
  let x2, y2 = scanf "%f %f\n" (fun a b -> a, b) in
  let distance = sqrt (((x2 -. x1) ** 2.0) +. ((y2 -. y1) ** 2.0)) in

  Printf.printf "%.4f\n" distance
