using System;

namespace TugasGeneric
{
    public class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic temp1 = input1;
            dynamic temp2 = input2;
            dynamic temp3 = input3;

            dynamic hasil = temp1 + temp2 + temp3;
            Console.WriteLine($"Hasil penjumlahan tiga angka adalah: {hasil}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan objekJumlah = new Penjumlahan();

            long angka1 = 10L;
            long angka2 = 30L;
            long angka3 = 82L;

            objekJumlah.JumlahTigaAngka<long>(angka1, angka2, angka3);
        }
    }
}