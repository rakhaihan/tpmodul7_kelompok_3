using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_3
{
    internal class KuliahMahasiswa_103022300131
    {
        [JsonPropertyName("courses")]
        public List<Courses> Courses { get; set; }

        public void ReadJSON()
        {
            String filePath = @"F:\TP Modul KPL\kelompok\tpmodul7_kelompok_3\tp7_2_103022300131.json";
            if (File.Exists(filePath))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string json = File.ReadAllText(filePath);
                KuliahMahasiswa_103022300131 data = JsonSerializer.Deserialize<KuliahMahasiswa_103022300131>(json, options);

                int i = 1;
                foreach (var course in data.Courses)
                {
                    Console.WriteLine($"MK {i++}: {course.Code} - {course.Name}");
                }
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }

        }
    }

    public class Courses
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
