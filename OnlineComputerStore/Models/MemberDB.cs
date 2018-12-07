using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class MemberDB
    {
        public static void AddMember(Member m)
        {
            var context = new ApplicationDbContext();
            context.Members.Add(m);
            context.SaveChanges();
        }

        public static bool IsUsernameTaked(RegisterViewModel register)
        {
            var context = new ApplicationDbContext();

            bool isNameTaken = (from mem in context.Members
                                where mem.Username == register.Username
                                select mem).Count() == 1;

            return isNameTaken;
        }

        public static bool UserExits(LoginViewModel log)
        {
            var db = new ApplicationDbContext();

            bool doesExist = (from member in db.Members
                              where member.Username == log.Username
                              select member).Any();

            return doesExist;
        }
    }
}