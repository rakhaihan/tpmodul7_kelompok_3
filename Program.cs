// See https://aka.ms/new-console-template for more information
namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300131 dataAzki = new DataMahasiswa_103022300131();
            dataAzki.ReadJSON();
            KuliahMahasiswa_103022300131 kuliahAzki = new KuliahMahasiswa_103022300131();
            kuliahAzki.ReadJSON();

            Console.WriteLine();
        }
    }
}
