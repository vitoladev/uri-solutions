using System;

double r = double.Parse(ReadLine());
double n = 3.14159;

double areaOfCircle = n * (r * r);
WriteLine($"A={areaOfCircle.ToString("F4")}");