﻿using System.IO.Pipelines;
using System.Runtime.Intrinsics.X86;

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Divide value1 by value2
int result1 = Convert.ToInt32(value1 / value2);

// Divide value2 by value3
decimal result2 = value2 / (decimal)value3;

// Divide value3 by value1
float result3 = value3 / value1;


Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
