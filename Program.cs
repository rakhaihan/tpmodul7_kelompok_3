
namespace tpmodul7_kelompok_3

{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103022300046 dataRakha = new DataMahasiswa103022300046();
            dataRakha.ReadJSON();

            KuliahMahasiswa103022300046 kuliahMahasiswa = new KuliahMahasiswa103022300046();
            kuliahMahasiswa.ReadJSON();
          
            Console.WriteLine();

            DataMahasiswa_103022300131 dataAzki = new DataMahasiswa_103022300131();
            dataAzki.ReadJSON();
            KuliahMahasiswa_103022300131 kuliahAzki = new KuliahMahasiswa_103022300131();
            kuliahAzki.ReadJSON();

            Console.WriteLine();
          
            DataMahasiswa_103022300024 dataJack = new DataMahasiswa_103022300024();
            dataJack.ReadJSON();

            KuliahMahasiswa_103022300024 kuliahJack = new KuliahMahasiswa_103022300024();
            kuliahJack.ReadJSON();
          
            Console.WriteLine();

            DataMahasiswa_103022300063 dataAgung = new DataMahasiswa_103022300063();
            dataAgung.ReadJSON();
            KuliahMahasiswa_103022300063 kuliahAgung = new KuliahMahasiswa_103022300063();
            kuliahAgung.ReadJSON();

            Console.WriteLine();
        }
    }
}



