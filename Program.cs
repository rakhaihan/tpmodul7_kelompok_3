namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300024 dataJack = new DataMahasiswa_103022300024();
            dataJack.ReadJSON();

            KuliahMahasiswa_103022300024 kuliahJack = new KuliahMahasiswa_103022300024();
            kuliahJack.ReadJSON();
        }
    }
}
