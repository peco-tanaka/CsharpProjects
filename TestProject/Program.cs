int[] numbers = [ 4, 8, 15, 16, 23, 42 ];

bool found;
int total = 0;


foreach (int number in numbers)
{
  total += number;
  if (number == 42)
  {
    found = true;
    Console.WriteLine("Set contains 42");
  }
}

Console.WriteLine($"Total: {total}");