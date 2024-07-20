
int number = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < number; i++)
{
    int leftNum = int.Parse(Console.ReadLine());
    leftSum += leftNum;
}
for (int i = 0; i < number; i++)
{
    int rightNum = int.Parse(Console.ReadLine());
    rightSum += rightNum;
}
if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
   int diff = leftSum - rightSum;
    Console.WriteLine( $"No, diff = {Math.Abs(diff)}");
}