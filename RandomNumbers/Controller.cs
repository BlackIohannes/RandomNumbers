namespace RandomNumbers;

public class Controller
{
    public static void GetRandomNumbers(){
        int[] numbers = Enumerable.Range(1, 27).ToArray();
        var random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            int randomIndex = i + random.Next(numbers.Length - i);
            int temp = numbers[randomIndex];
            numbers[randomIndex] = numbers[i];
            numbers[i] = temp;
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}