namespace ADT;

class Program
{
    static void Main(string[] args)
    {
        CursorList<int> cursorList = new CursorList<int>();

        cursorList.Add(15);
        cursorList.Add(1);
        cursorList.Add(-3);
        cursorList.Add(2);
        cursorList.Add(12);

        Console.WriteLine(cursorList.Count);

        cursorList.Next();
        cursorList.Next();

        Console.WriteLine(cursorList.getCurrent());

        cursorList.Next();

        cursorList.RemoveCurrent();

        Console.WriteLine(cursorList.getCurrent());
    }
}

