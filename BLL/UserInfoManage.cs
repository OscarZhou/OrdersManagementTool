using DLL;
using Models;

namespace BLL
{
    public class UserInfoManage
    {

        public int InsertUser(UserInfo objUserInfo)
        {
            return new UserInfoService().InsertUser(objUserInfo);
        }


        public int GetLatestUserNo()
        {
            return new UserInfoService().GetLatestUserNo();
        }
    }
}
