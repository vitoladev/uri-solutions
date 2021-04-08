open System

type Employee = { Number: int; Salary: float }

let calculateSalary workedHours amountPerHour = float (workedHours) * amountPerHour

let myEmployee : Employee =
    let number = int (Console.ReadLine())
    let workedHours = int (Console.ReadLine())
    let amountPerHour = float (Console.ReadLine())

    let salary =
        calculateSalary workedHours amountPerHour

    { Number = number; Salary = salary }

printf "NUMBER = %i\n" myEmployee.Number
printf "SALARY = U$ %.2f\n" myEmployee.Salary
