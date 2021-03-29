let average = 
  let a = read_float() in
  let b = read_float() in
  let c = read_float() in
  ((a *. 2.0) +. (b *. 3.0) +. (c *. 5.0)) /. 10.0;;

Printf.printf "MEDIA = %.1f\n" average