// Генератор псевдослучайных чисел. Пример вычисления суммы.

// Random - ввод случайных (сгенерированных) чисел.

// new Random().Next(min, max) - даст случайное целое число от min до max-1,
//                                              [min, max-1] или [min, max)

int numberA = new Random().Next(1, 10); // 1, 2, 3, 4, ...9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
