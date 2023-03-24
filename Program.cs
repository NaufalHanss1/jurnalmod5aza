internal class Program
{
    public class penjumlahan
    {
        public static void Main(string[] args)
        {
            penjumlahan.jumlah3angka<int>(12,13,14);
        }
        static void jumlah3angka<T>(T angka1, T angka2, T angka3)
        {
            Console.WriteLine((dynamic)angka1+(dynamic)angka2+(dynamic)angka3);
        }
    }
}
 