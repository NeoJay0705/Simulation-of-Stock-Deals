using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public enum StatusOfAccount { SUCCESS, ACCOUNTERROR, PASSWORDERROR, REPEAT, HAD, HADNT, ENOUGH, UNENOUGH }

    public abstract class Member
    {
        #region 屬性

        public string Account { get; set; }

        public string Password { get; set; }

        public StatusOfAccount AccountStatus { get; set; }

        #endregion 屬性

        #region 會員資料庫

        public static List<Member> memberList = new List<Member>();
        public static StatusOfAccount StatusOfRegister;
        public static string ConnectAccount;
        public static StockAccount SynchronizeAccount;

        public static Member MemberList
        {
            set
            {
                Member.StatusOfRegister = StatusOfAccount.SUCCESS;
                foreach (Member member in Member.memberList)
                {
                    if (member.Account == value.Account)
                    {
                        Member.StatusOfRegister = StatusOfAccount.REPEAT;
                    }
                }
                if (Member.StatusOfRegister == StatusOfAccount.SUCCESS)
                    Member.memberList.Add(value);
            }
        }

        #endregion 會員資料庫
    }
}