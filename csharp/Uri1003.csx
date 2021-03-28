public Func<int> sum = () => {
    int a = int.Parse(ReadLine());
    int b = int.Parse(ReadLine());
    return a + b;
};

WriteLine($"SOMA = {sum()}");