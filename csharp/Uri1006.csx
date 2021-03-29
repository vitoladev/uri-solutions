using System;

public Func<double> average = () => {
  double a = double.Parse(ReadLine());
  double b = double.Parse(ReadLine());
  double c = double.Parse(ReadLine());

  return ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0;
};

WriteLine($"MEDIA = ${average().ToString("F1")}");
