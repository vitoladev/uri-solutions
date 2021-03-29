type employee = { name: string; salary: float; sales: float }

let calculate_bonus salary sales = 
  salary +. (sales *. 0.15)

let my_employee = 
  let name = read_line() in
  let salary = read_float() in
  let sales = read_float() in
  { name; salary; sales};;

let () =
  let salary_with_bonus =
    calculate_bonus my_employee.salary my_employee.sales in

  Printf.printf "TOTAL = R$ %.2f\n" salary_with_bonus