let volume =
  let radius = read_int() in
  let pi = 3.14159 in
  (4.0 /. 3.0) *. pi *. (float(radius) ** 3.0);;

Printf.printf "VOLUME = %.3f\n" volume