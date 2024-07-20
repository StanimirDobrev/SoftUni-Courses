//Input

double depositedSum = double.Parse(Console.ReadLine());
int depositLenghtInMonths = int.Parse(Console.ReadLine());
double increase = double.Parse(Console.ReadLine()) /100 ;

//Calculation
double accumulatedInterestForYear = depositedSum * increase;
double accumulatedInterestForMonth = accumulatedInterestForYear / 12;
double sumAfterDeposit = depositedSum + accumulatedInterestForMonth * depositLenghtInMonths;
//Output
Console.WriteLine(sumAfterDeposit);