// Палиндром.

bool Check(int value)
{
  int t = value;
  int inverseValue = 0;

  while (t != 0)
  {
    int o = t % 10;
    inverseValue = inverseValue * 10 + o;
    t = t / 10;
  }
  return value == inverseValue;
}

Console.WriteLine(Check(1223221));
