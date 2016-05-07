using LearnMVC.Models;
using System.Linq;

namespace LearnMVC.IBLL
{
    public interface InterfaceUserService : InterfaceBaseService<User>
    {
        bool Exist(string userName);

        User Find(int userID);

        User Find(string userName);


        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="pageIndex">页码数</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="totalRecord">总记录数</param>
        /// <param name="order">排序：0-ID升序（默认），1ID降序，2注册时间升序，3注册时间降序，4登录时间升序，5登录时间降序</param>
        /// <returns></returns>
        IQueryable<User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);

    }
}
