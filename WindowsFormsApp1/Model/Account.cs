using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Model
{
    public class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Hash { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsEnabled { get; set; }

        public Account(string username, string password)
        {
            Username = username;

            Hash = DontDestroy.ComputeSha256Hash(password); //1
            for (int i = 0; i < 0; i++)
            {
                Hash = DontDestroy.ComputeSha256Hash(Hash);
            } // 2 (Not hashing, won't execute since i < 0; maybe later for some more security)

            // 2 + 1 = 3x hashed. (Bcrypt not possible since there's only a db)
        }

        public Account(int Id, string username, string hash, bool isAdmin, bool isEnabled)
        {
            ID = Id;
            Username = username;
            Hash = hash;
            IsAdmin = isAdmin;
            IsEnabled = isEnabled;
        }
    }
}
