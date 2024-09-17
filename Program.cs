namespace Lessons_;
internal class Program
{
    private static void Main()
    {
        /*int[] ints = new int[10];
        foreach (var item in ints)
        {
            Console.Write(item + " ");
        }*/

        // Nullable<int> b = 1;
        int? nullableInt = null;



        int?[] nulls = new int?[10];
        foreach (var item in nulls)
        {
            Console.Write(item + " ");
        }
    }
}