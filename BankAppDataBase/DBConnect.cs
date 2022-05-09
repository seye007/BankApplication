using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Model;
using System.IO;

namespace DataBase
{
    public class DBConnect
    {
        public static string path = Path.Combine(Directory.GetCurrentDirectory());
        public static async Task<bool> WriteToJason<T>(T jsonFilType, string jsonName)
        {
            
            try
            {
                UpdatePath();
                string JsonPath = path + jsonName;
                string json = JsonConvert.SerializeObject(jsonFilType) + Environment.NewLine;
                await File.AppendAllTextAsync(JsonPath, json);
                return true;
            }
           catch (Exception)
            {
                throw;
            }
            
        }
        public static async Task<List<T>> ReadFromJason<T>(string jsonName)
        {
            try
            {
                UpdatePath();
                string JsonPath = path + jsonName;
                var serializer = new JsonSerializer();
                string readText = await File.ReadAllTextAsync(JsonPath);
                var objects = new List<T>();
                using (var stringReader = new StringReader(readText))
                using (var jsonReader = new JsonTextReader(stringReader))
                {
                    jsonReader.SupportMultipleContent = true;
                    while (jsonReader.Read())
                    {
                        T customer = serializer.Deserialize<T>(jsonReader);
                        objects.Add(customer);
                    }
                }
                return objects;
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public static async Task<bool> UpdateJason<T>(List<T> models, string fileName)
        {
            
            try
            {
                UpdatePath();
                string json = "";
                string jasonPath = path + fileName;
                foreach (T model in models)
                {
                    json += JsonConvert.SerializeObject(model) + Environment.NewLine;
                }
                await File.WriteAllTextAsync(jasonPath, json);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public static void UpdatePath()
        {
            string[] pathArr = path.Split(@"\");
            path = "";
            for (int i = 0; i < pathArr.Length-1; i++)
            {
                if(pathArr[i]== "winform_jason")
                {
                    path += pathArr[i] + @"\";
                    break;
                }
                path += pathArr[i] + @"\";
            }
        }
    }
}

