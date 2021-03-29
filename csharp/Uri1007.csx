using System;

public Func<double> average = () =>
{
    int a = int.Parse(ReadLine());
    int b = int.Parse(ReadLine());
    int c = int.Parse(ReadLine());
    int d = int.Parse(ReadLine());
    return (a * b) - (c * d);
};

WriteLine($"MEDIA = {average()}");
