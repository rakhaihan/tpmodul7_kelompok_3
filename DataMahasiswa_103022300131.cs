using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_3
{
    internal class DataMahasiswa_103022300131
    {
        [JsonPropertyName("nama")]
        public Nama Nama { get; set; }

        [JsonPropertyName("nim")]
        public long Nim { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }

        public void ReadJSON()
        {
            String filePath = @"F:\TP Modul KPL\kelompok\tpmodul7_kelompok_3\tp7_1_103022300131.json";
            if (File.Exists(filePath))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string json = File.ReadAllText(filePath);
                DataMahasiswa_103022300131 data = JsonSerializer.Deserialize<DataMahasiswa_103022300131>(json, options);

                Console.WriteLine($"Nama: {data.Nama.depan} {data.Nama.belakang} dengan NIM: {data.Nim} dari Fakultas: {data.Fakultas}");
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }

        }
    }

    public class Nama
    {
        [JsonPropertyName("depan")]
        public string depan { get; set; }

        [JsonPropertyName("belakang")]
        public string belakang { get; set; }
    }
}

