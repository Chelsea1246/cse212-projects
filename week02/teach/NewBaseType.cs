public static class NewBaseType
{
    public static void MAIN()
    {

        // True (stack was empty at the end)
        Console.WriteLine(CheckBraces("(a == 3 or (b == 5 and c == 6))"));
        // False ...wrong opening square bracket (stack had only '(' in it before it was popped and compared with ']')
        //                          here -------\/
        Console.WriteLine(CheckBraces("(students]i].Grade > 80 and students[i].Grade < 90"));
        // False ....missing closing ')' (stack had an extra '(' in it at the end when it was supposed to be empty
        //                 here -------\/
        Console.WriteLine(CheckBraces("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));
    }

    private static bool CheckBraces(string v)
    {
        throw new NotImplementedException();
    }
}
