open Printf

type employee = { number : int; salary : float }

let calculate_salary worked_hours amount_per_hour = 
  float(worked_hours) *. amount_per_hour

let my_employee =
  let number = read_int() in
  let worked_hours = read_int() in
  let amount_per_hour = read_float() in
  let salary = calculate_salary worked_hours amount_per_hour in
  { number; salary};;


let () = 
  printf "NUMBER = %i\n" my_employee.number;
  printf "SALARY = U$ %.2f\n" my_employee.salary