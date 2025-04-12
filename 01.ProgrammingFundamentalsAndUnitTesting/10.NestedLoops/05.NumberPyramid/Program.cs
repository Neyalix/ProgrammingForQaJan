
int n = int.Parse(Console.ReadLine());

int current = 1;
bool isComplete = false;
for (int i = 1; i <= n; i++)
{
	for (int y = 1; y <= i; y++)
	{
		Console.Write(current + " ");
        current++;

        if (current > n)
        {
            isComplete = true;
            break;
        }
    }
    
    Console.WriteLine();

    if (isComplete)
    {
        break;
    }

}

