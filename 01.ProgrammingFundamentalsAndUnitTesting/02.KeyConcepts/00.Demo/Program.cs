double num = 5.6734556;
//Закръгля до на-близко цяло число.
Console.WriteLine(Math.Round(num));
//Закръгляне към най-близкото по-малко цяло число
Console.WriteLine(Math.Floor(num));
//Закръгля към най-близкото по-голямо цяло число.
Console.WriteLine(Math.Ceiling(num));
//Закръгляне до дадена цифра след десетичната запетая
Console.WriteLine(Math.Round(num, 3));

//Форматиране vs Закръгляне
double num2 = 4.5043564;
//форматиране -> закръгляне до съответната цифра + подсигурява броя цифри който сме избрали
Console.WriteLine($"{num2:F2}");
//Закръгляне до дадена цифра след десетичната запетая + изрязва излишни нули.
Console.WriteLine(Math.Round(num, 3));