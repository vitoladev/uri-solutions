open Printf
open Scanf

let a, b, c = scanf "%f %f %f\n" (fun a b c -> a, b, c)
let pi = 3.14159

let triangle = (a *. c) /. 2.0
let circle = pi *. (c ** 2.0)
let trapezium = ((a +. b) /. 2.0) *. c
let square = b *. b
let rectangle = a *. b;;

printf "TRIANGULO: %.3f\n" triangle;
printf "CIRCULO: %.3f\n" circle;
printf "TRAPEZIO: %.3f\n" trapezium;
printf "QUADRADO: %.3f\n" square;
printf "RETANGULO: %.3f\n" rectangle