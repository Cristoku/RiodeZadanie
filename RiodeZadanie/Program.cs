while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    var linia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Solution(n, linia);
}


static void Solution(int n, string[] linia)
{
    Queue<int> wjazd = new Queue<int>(Array.ConvertAll(linia, int.Parse));
    Stack<int> uliczka = new Stack<int>();
    int oczekiwany = 1;

    while (wjazd.Count > 0)
    {
        if (wjazd.Peek() == oczekiwany)
        {
            wjazd.Dequeue();
            oczekiwany++;
        }
        else if (uliczka.Count > 0 && uliczka.Peek() == oczekiwany)
        {
            uliczka.Pop();
            oczekiwany++;
        }
        else
        {
            uliczka.Push(wjazd.Dequeue());
        }
    }

    while (uliczka.Count > 0 && uliczka.Peek() == oczekiwany)
    {
        uliczka.Pop();
        oczekiwany++;
    }

    if (oczekiwany == n + 1)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
