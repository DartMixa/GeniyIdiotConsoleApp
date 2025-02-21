using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    internal class UsersResultStorage
    {
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
                result.Add([]);
                foreach (var diagnose in item.Value)
                {
                    result[^1].Add(item.Key.Name);
                    result[^1].Add(Convert.ToString(diagnose.countRightAnswers));
                    result[^1].Add(diagnose.diagnose);
                }
            }
            return result;
        }
        public void Save()
        {
            string txt = "";
            foreach (var item in storage)
            {
                foreach (var diagnose in item.Value)
                {
                    txt += string.Format("{0};;;{1};;;{2}\n", item.Key.Name, diagnose.countRightAnswers, diagnose.diagnose);
                }
            }
            FileSystem.WriteFile("results.txt", txt);
        }
        public void Load()
        {
            try
            {
                var txt = (FileSystem.ReadFile("results.txt").Split("\n"));
                foreach (var item in txt)
                {
                    var strSplit = item.Split(";;;");
                    if (item != null && item.Length != 0)
                    {
                        AddDiagnose(new(strSplit[0]), new(Convert.ToInt32(strSplit[1]), new(strSplit[2])));
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                FileSystem.WriteFile("results.txt", "");
			}
        }
    }
}
