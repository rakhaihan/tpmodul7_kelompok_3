
namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103022330167 dataRaihan = new DataMahasiswa103022330167();
            dataRaihan.ReadJSON();

            KuliahMahasiswa103022330167 kuliahRaihan = new KuliahMahasiswa103022330167();
            kuliahRaihan.ReadJSON();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}