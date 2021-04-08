open System

type Employee =
    { Name: string
      Salary: float
      Sales: float }

let calculateBonus salary sales = salary + (sales * 0.15)

let myEmployee =
    let name = Console.ReadLine()
    let salary = float (Console.ReadLine())
    let sales = float (Console.ReadLine())

    { Name = name
      Salary = salary
      Sales = sales }

let salaryWithBonus =
    calculateBonus myEmployee.Salary myEmployee.Sales

printf "TOTAL = R$ %.2f\n" salaryWithBonus
