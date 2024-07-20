//Input
double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters =  double.Parse(Console.ReadLine());
double timeInSeconds = double.Parse(Console.ReadLine());

//Calculations

double timeForWholeDistance = distanceInMeters * timeInSeconds;
double timesSlowedDown = Math.Floor(distanceInMeters / 15);

timeForWholeDistance += timesSlowedDown * 12.5;

//Output
if (timeForWholeDistance < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {timeForWholeDistance:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {timeForWholeDistance - recordInSeconds:f2} seconds slower.");
}