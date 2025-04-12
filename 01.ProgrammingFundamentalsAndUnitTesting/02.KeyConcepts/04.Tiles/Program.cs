double bathWidth = double.Parse(Console.ReadLine()); 
double bathHeight = double.Parse(Console.ReadLine()); 
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathArea = bathWidth * bathHeight;
double tileArea = tileWidth * tileHeight;

double bathAddSurplus = bathArea + (bathArea * 0.1);
double tilesNeeded = bathAddSurplus / tileArea;

Console.WriteLine(Math.Round(tilesNeeded));