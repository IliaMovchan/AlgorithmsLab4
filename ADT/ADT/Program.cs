namespace ADT;

class Program
{
    static void Main(string[] args)
    {
        CursorList<int> cursorList = new CursorList<int>();

        cursorList.AddToEnd(15);
        cursorList.AddToCursor(1);
        cursorList.AddToEnd(-3);
        cursorList.AddToEnd(2);
        cursorList.AddToCursor(12);

        Console.WriteLine(cursorList.Count);

        cursorList.Next();
        cursorList.Next();

        Console.WriteLine(cursorList.getCurrent());

        cursorList.Next();

        cursorList.RemoveCurrent();

        Console.WriteLine(cursorList.getCurrent());
    }
}

