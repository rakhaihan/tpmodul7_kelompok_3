// See https://aka.ms/new-console-template for more information
namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300063 dataAgung = new DataMahasiswa_103022300063();
            dataAgung.ReadJSON();
            KuliahMahasiswa_103022300063 kuliahAgung = new KuliahMahasiswa_103022300063();
            kuliahAgung.ReadJSON();
        }
    }
}
