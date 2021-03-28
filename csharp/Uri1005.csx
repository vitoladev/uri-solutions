public Func<double> average = () => {
    double a = double.Parse(ReadLine());
    double b = double.Parse(ReadLine());

    return ((a * 3.5) + (b * 7.5)) / 11.0;
};

WriteLine($"MEDIA = {average().ToString("F5")}");