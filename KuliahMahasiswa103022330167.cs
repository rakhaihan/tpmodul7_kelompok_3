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
    internal class KuliahMahasiswa103022330167
    {
        [JsonPropertyName("courses")]
        public List<Courses> Courses { get; set; }

        public void ReadJSON()
        {
            String filePath = @"tp7_2_103022330167.json";
            if (File.Exists(filePath))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string json = File.ReadAllText(filePath);
                KuliahMahasiswa103022330167 data = JsonSerializer.Deserialize<KuliahMahasiswa103022330167>(json, options);

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
        [JsonPropertyName("kode_mk")]
        public string Code { get; set; }
        [JsonPropertyName("nama_mk")]
        public string Name { get; set; }
    }
}