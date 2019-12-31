using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace SSR
{
    class JSonUtilities
    {
        FileStream file;
        internal bool CreateFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    file = File.Open(path, FileMode.Create);
                    file.Close();
                    file.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal bool SetTasks(List<ControlTaskType> List)
        {
            try
            {
                string Json = JsonConvert.SerializeObject(List.ToArray(), Formatting.Indented);
                File.WriteAllText($@"{Directory.GetCurrentDirectory()}\controlTask.json", Json);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal List<ControlTaskType> GetTasks()
        {
            try
            {
                List<ControlTaskType> Json = new List<ControlTaskType>();
                Json = JsonConvert.DeserializeObject<List<ControlTaskType>>(File.ReadAllText($@"{Directory.GetCurrentDirectory()}\controlTask.json"));
                return Json;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
