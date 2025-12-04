static int SumEven()
{
  int sum = 0;

  for (int i = 0; i <= 100; i++)
    if (i % 2 == 0)
      sum += i;

  return sum;
}

Console.WriteLine($"Jumlah bilangan genap 1-100: {SumEven()}");

