using System;
using System.Collections.Generic;

namespace TugasGeneric
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<long> db = new SimpleDataBase<long>();
            db.AddNewData(10L);
            db.AddNewData(30L);
            db.AddNewData(82L);

            db.PrintAllData();
        }
    }
}