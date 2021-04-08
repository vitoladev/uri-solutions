let a, b, c = Scanf.scanf "%i %i %i\n" (fun a b c -> a, b, c);;

let biggest = 
  if a > b && a > c
  then a
  else if b > c
  then b
  else c;;

let () = 
  Printf.printf "%d eh o maior\n" biggest
