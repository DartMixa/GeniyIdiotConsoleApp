using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class UsersResultStorage
    {
        public static string Path = "results.json";

		private Dictionary<User, List<Diagnose>> storage = [];
        public UsersResultStorage() { }
        public UsersResultStorage(Dictionary<User, List<Diagnose>> storage)
        {
            this.storage = storage;
        }
        public void AddDiagnose(User user, Diagnose diagnose)
        {
            if (storage.TryGetValue(user, out var list))
            {
                list.Add(diagnose);
            }
            else
            {
                storage[user] = [diagnose];
            }
        }
        public List<List<string>> GetResults()
        {
            List<List<string>> result = [];
            foreach (var item in storage)
            {
                foreach (var diagnose in item.Value)
                {
                    result.Add([]);
                    result[^1].Add(item.Key.Name);
                    result[^1].Add(Convert.ToString(diagnose.countRightAnswers));
                    result[^1].Add(diagnose.diagnose);
                }
            }
            return result;
        }
        public void Save()
        {
            var JsonData = JsonConvert.SerializeObject(storage);
			FileSystem.WriteFile(Path, JsonData);
        }
        public void Load()
        {
            try
            {
                var JsonData = FileSystem.ReadFile(Path);
                storage = JsonConvert.DeserializeObject<Dictionary<User, List<Diagnose>>>(JsonData) ?? throw new Exception();

			}
            catch (Exception)
            {
                FileSystem.WriteFile(Path, "");
			}
        }
    }
}
