using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ListOfNotes;
using System.Globalization;



namespace Models
{

    public class Data
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
    }

    public class ModelNotes : IModelNotes
    {
        private List<Data> notes;

        public ModelNotes()
        {
            notes = new List<Data>();
            LoadDataFromJson();
        }

        private int GenerateUniqueId()
        {
            if (notes.Count > 0)
                return notes[notes.Count - 1].Id + 1;
            else
                return 1;
        }

        private void SaveDataToJson()
        {
            string json = JsonSerializer.Serialize(notes);
            File.WriteAllText("../../../DataBase/database.json", json);
        }

        public void CreateData(string? date, string? title, string? text)
        {
            var dataOfNote = new Data
            {
                Id = GenerateUniqueId(),
                Date = DateTime.Parse(date, new CultureInfo("ru-RU")),
                Title = title,
                Text = text
            };

            notes.Add(dataOfNote);
            SaveDataToJson();
        }

        public List<Data> LoadDataFromJson()
        {
            try
            {
                if (File.Exists("../../../DataBase/database.json"))
                {
                    string json = File.ReadAllText("../../../DataBase/database.json");
                    notes = JsonSerializer.Deserialize<List<Data>>(json) ?? new List<Data>();
                    return notes;
                }
                else
                {
                    Console.WriteLine("Файл с данными не найден.");
                    notes = new List<Data>();
                    return notes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при загрузке данных: {ex.Message}");
                notes = new List<Data>();
                return notes;
            }
        }

        public void UpdateNote(int id, string? title, string? text)
        {
            var noteToUpdate = notes.FirstOrDefault(n => n.Id == id);
            if (noteToUpdate != null)
            {
                noteToUpdate.Title = title;
                noteToUpdate.Text = text;
                SaveDataToJson();
            }
        }

        public Data GetNoteById(int id)
        {
            return notes.FirstOrDefault(n => n.Id == id);
        }

        public List<Data> GetAllNotes()
        {
            return notes;
        }
    }
}
