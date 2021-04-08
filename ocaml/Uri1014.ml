let () =
  let distance = read_int() in
  let spent_fuel = read_float() in
  let consumption = float(distance) /. spent_fuel in

  Printf.printf "%.3f km/l\n" consumption
