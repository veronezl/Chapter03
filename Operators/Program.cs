#region Exploring unary operators
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c; // Prefix means increment c before assigning it.
WriteLine($"c is {c}, d is {d}");

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N4}, f is {f}");
WriteLine($"g / f = {g / f}");

int p = 6;
p += 3; // Equivalent to: p = p + 3;
p -= 3; // Equivalent to: p = p - 3;
p *= 3; // Equivalent to: p = p * 3;
p /= 3; // Equivalent to: p = p / 3;

WriteLine();

int x = 5;
int postfixIncrement = x++;
int prefixIncrement = ++x;
Type theTypeOfAnInteger = typeof(int);
string nameOfVariable = nameof(x);
int howManyBytesInAnInteger = sizeof(int);

WriteLine($"postfixIncrement is {postfixIncrement}");
WriteLine($"prefixIncrement is {prefixIncrement}");
WriteLine($"The type of an integer is {theTypeOfAnInteger}");
WriteLine($"The name of the variable is {nameOfVariable}");
WriteLine($"An integer takes {howManyBytesInAnInteger} bytes in memory");

#endregion

