class Culculator
{
    static void Main (string[] args)
	static void Main(string[] args)
        {
            double pilih, a, b;

            bool bener = true;
            double total = 0 ;
            
            Console.WriteLine("1. Pertambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            do
            {
                Console.WriteLine("Pilih Menu: ");

                pilih = int.Parse(Console.ReadLine());
                if (pilih > 4 || pilih < 1)
                {
                    Console.WriteLine("Piilihan Tidak Tersedia");
                    bener = false;
                } else
                {
                    bener = true;
                }

            } while (!bener);
            
            Console.Write("Masukkan angka pertama ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Masukkan angka kedua ");
            b = double.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    total = a + b;
                    break;
                case 2:
                    total = a - b;
                    break;
                case 3:
                    total = a * b;
                    break;
                case 4:
                    total = a / b;
                    break;
                default:
                    
                    break;
            }
            Console.WriteLine("Hasil dari operasi bilangan = " + total);
            Console.ReadKey();
        }
}