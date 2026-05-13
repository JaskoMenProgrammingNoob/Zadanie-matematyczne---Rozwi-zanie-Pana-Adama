class program
{
    static void Main(string[] args)
    {
        int j = 0;
        for (int i = 1000; i <= 9999; i++)
        {
            int a = i / 100;
            int b = i % 100;
            if (a * a + b * b == i)
            {
                j++;
                Console.WriteLine(a*a  + b*b);
            }
        }
        Console.WriteLine(j);


    }
}