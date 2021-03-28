public Func<int> prod = () => {
    int a = int.Parse(ReadLine());
    int b = int.Parse(ReadLine());
    return a * b;
};

WriteLine($"PROD = {prod()}")