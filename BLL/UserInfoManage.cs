using DAL;
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

        public int DeleteUser(UserInfo objUserInfo)
        {
            return new UserInfoService().DeleteUser(objUserInfo);
        }

        public UserInfo GetUserByOrderNo(string orderNo)
        {
            return new UserInfoService().GetUserByOrderNo(orderNo);
        }

        public int UpdatetUser(UserInfo objUserInfo)
        {
            return new UserInfoService().UpdatetUser(objUserInfo);
        }
    }
}
