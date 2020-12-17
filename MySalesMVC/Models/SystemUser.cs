using System;
using MySalesMVC.Models.Enumerates;

namespace MySalesMVC.Models
{
    public class SystemUser
    {
        public int Id { get; set; }   
        public string Username { get; set; }
        public string Password { get; }
        public string RealName { get; set; }
        public DateTime CreateDate { get; set; }
        public SystemUserLevel Level { get; set; }

        public SystemUser()
        {

        }

        public SystemUser(int id, string username, string password, string realName, DateTime createDate, SystemUserLevel level)
        {
            Id = id;
            Username = username;
            Password = password;
            RealName = realName;
            CreateDate = createDate;
            Level = level;
        }
    }
}
