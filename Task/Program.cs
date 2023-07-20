namespace Task;

public class Program
{
    static void Main(string[] args)
    {

        //Task 3
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int start;
        int end;
        int sum = 0;

        if (num1 >= num2)
        {
            start = num2; end = num1;
        }
        else
        {
            end = num2; start = num1;
        }

        for (int i = start; i <= end; i++)
        {
            sum = sum + i;
        }


        //Task 4
        //int n = int.Parse(Console.ReadLine());
        //int m = int.Parse(Console.ReadLine());
        //int pow=1;

        //for (int i = 0; i < n; i++)
        //{
        //    pow = pow * m;
        //}
        //Console.WriteLine(pow);


        //Task 5
        //int number = int.Parse(Console.ReadLine());
        //int count = 0;
        //while (number > 0)
        //{
        //    number /= 10;
        //    count++;
        //}

        //Console.WriteLine(count);


        //Task 6
        //string[] arr = { "Shahin", "Fikret", "Asiman", "Tural", "Huseyn", "Eli" };
        //for (int i = 0; i < arr.Length-1; i++)
        //{
        //    if (arr[i].Length>4)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}


        //Task 7
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //int count = Convert.ToInt32(Console.ReadLine());

        //Console.Write($"{num1} {num2} ");
        //for (int i = 2; i < count; i++)
        //{
        //    int next = num1 + num2;
        //    Console.Write(next + " ");

        //    num1 = num2;
        //    num2 = next;
        //}
    }
}