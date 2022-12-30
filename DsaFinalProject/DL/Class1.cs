using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DsaFinalProject.BL;

namespace DsaFinalProject.DL
{
    internal class userDL
    {
        public static List<userBL> users = new List<userBL>();

        public static void addUsersintoList(userBL u)
        {
            users.Add(u);
        }

        public static void storeUserinFile(userBL users, string path)
        {
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine(users.Username + "," + users.Password);
            filevariable.Flush();
            filevariable.Close();
        }

        public static void updateUserinFile(string path)
        {
            StreamWriter filevariable = new StreamWriter(path);
            for (int i = 0; i < users.Count; i++)
            {
                filevariable.WriteLine(users[i].Username + "," + users[i].Password);
            }
            filevariable.Flush();
            filevariable.Close();

        }

        public static userBL isUser(userBL info)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if ((info.Username == users[i].Username) && (info.Password == users[i].Password))
                {
                    return users[i];
                }
            }
            return null;
        }

        public static bool readUsersfromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                string username;
                string password;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record != " " && record != "" && record != "," && record != " , ")
                    {
                        username = getParse(record, 1);

                        password = getParse(record, 2);
                        userBL u = new userBL(username, password);
                        addUsersintoList(u);
                    }
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string getParse(string record, int field)
        {
            int comaCount = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comaCount++;
                }
                else if (comaCount == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }
}
