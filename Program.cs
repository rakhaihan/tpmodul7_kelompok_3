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
        }
    }
}