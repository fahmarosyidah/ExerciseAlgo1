using System;

namespace ExerciseAlgo1
{
    class Program
    {
        //Deklarasi array integer dengan ukuran 3 + 0 + 10 + 20 + 20 - 2 x 15 = 23
        private int[] osi = new int[23];

        //Deklarasi array untuk menyimpan banyaknya data pada array
        private int n;

        //Method untuk menerima input dari user
        public void Input()
        {
            while (true)
            {
                //User memasukkan banyaknya elemen pada array
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 23)
                    break;
                else //Apabila n > 23
                    Console.WriteLine("\nArray dapat mempunyai maksimum 23 elemen\n");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("------------------------");
            //User memasukkan elemen array sebanyak yang telah diinputkan sebelumnya
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                osi[i] = Int32.Parse(s1);
            }
        }

        //Method untuk menampilkan array yang telah tersusun
        public void Display()
        {
            //Memasukkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Elemen array yang telah tersusun");
            Console.WriteLine("----------------------------------");
            //Menampilkan array yang telah tersusun dengan perulangan for
            for (int FR = 0; FR < n; FR++)
            {
                Console.WriteLine(osi[FR]);
            }
            Console.WriteLine("");
        }

        //Method untuk mengurutkan array
        public void BubbleSortArray()
        {
            for(int i = 1; i < n; i++)
            {
                
                for (int FR = 0; FR < n - i; FR++)
                {
                    if ( osi[FR] < osi[FR + 1]) //Jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar elemen 
                        int temp;
                        temp = osi[FR];
                        osi[FR] = osi[FR + 1];
                        osi[FR + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Membuat objek baru untuk class Program
            Program myList = new Program();

            //Memanggil fungsi untuk menerima elemen array
            myList.Input();
            //Memanggil fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //Memanggil fungsi untuk menampilkan array yang tersusun
            myList.Display();
            //Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}

