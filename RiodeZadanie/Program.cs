string test = @"5
5 1 2 4 3 
0";
Console.SetIn(new StringReader(test));

while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    var linia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Solution(n, linia);

    //if (n > 1000)
    //{
    //    Console.WriteLine("Number of trucks cannot be more than 1000.");
    //    continue;
    //}

    //string[] input = Console.ReadLine().Split();
    //int[] order = new int[n];
    //for (int i = 0; i < n; i++)
    //{
    //    order[i] = int.Parse(input[i]);
    //}

    //if (Solution(order))
    //{

    //    Console.WriteLine("yes");
    //}
    //else
    //{
    //    Console.WriteLine("no");
    //}
}


static void Solution(int n, string[] linia)
{
    Queue<int> wjazd = new Queue<int>(Array.ConvertAll(linia, int.Parse));
    Queue<int> wyjazd = new Queue<int>();
    Stack<int> uliczka = new Stack<int>();

    int oczekiwany = 1;
    if (wjazd.Peek() == oczekiwany)
    {
        wyjazd.Enqueue(wjazd.Dequeue());
        oczekiwany++;
    }
    else
    {
        uliczka.Push(wjazd.Dequeue());
    }

}



