using System.Runtime.InteropServices;

namespace ForTests;

public class Program
{
    public static void Main(string[] args)
    {
        unsafe
        {
            new_m(2);
        }
    }
    static unsafe void* new_m(uint size)
    {
        var s = 1;
        var b = &s;
        Console.WriteLine(b->ToString());
        return (void*)Marshal.AllocHGlobal((int)size);
    }
}