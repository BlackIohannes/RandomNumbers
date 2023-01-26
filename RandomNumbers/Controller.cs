namespace RandomNumbers;

public class Controller
{
    public int GetRandomNumbers(int min, int max)
    {
        int[] numbers = Enumerable.Range(min, max).ToArray();
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            int randomIndex = rand.Next(i, numbers.Length);
            int temp = numbers[i];
            numbers[i] = numbers[randomIndex];
            numbers[randomIndex] = temp;
        }

        return numbers[0];
    }
}
