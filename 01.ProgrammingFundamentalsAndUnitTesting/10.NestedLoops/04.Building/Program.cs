
int countOffloor = int.Parse(Console.ReadLine());

int countOfRoom = int.Parse(Console.ReadLine());

for (int floor = countOffloor; floor >= 1; floor--)
{
	for (int room = 0; room < countOfRoom ; room++)
	{
		if (floor == countOffloor)
		{
            Console.Write($"L{floor}{room} ");
		}
		else if (floor % 2 == 0)
		{
            Console.Write($"O{floor}{room} ");
		}
		else if (floor % 2 == 1)
		{
            Console.Write($"A{floor}{room} ");
		}
	}
    Console.WriteLine();
}