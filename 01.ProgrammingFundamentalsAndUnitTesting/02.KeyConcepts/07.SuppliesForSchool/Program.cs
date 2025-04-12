double packOfPens = 5.80;
double packOfMarkers = 7.20;
double boardCleaner = 1.20;

int numOfPens = int.Parse(Console.ReadLine());
int numOfMarkes = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
double discountPercentage = double.Parse(Console.ReadLine()) / 100;


double pensPrice = packOfPens * numOfPens;
double markersPrice = packOfMarkers * numOfMarkes;
double cleanerPrice = litersOfBoardCleaner * boardCleaner;
double total = pensPrice +  markersPrice + cleanerPrice;
total = total - total * discountPercentage;

Console.WriteLine(total);