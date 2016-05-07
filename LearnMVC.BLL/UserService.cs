/************************************************************************ 
 * Projt Name  :  LearnMVC.BLL       
 * File Name   :  UserService 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 3:23:28 PM 
 * Update Time :  5/6/2016 3:23:28 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using LearnMVC.DAL;
using LearnMVC.IBLL;
using LearnMVC.Models;
using System.Linq;

namespace LearnMVC.BLL
{
    public class UserService : BaseService<User>, InterfaceUserService
    {




        public UserService() : base(RepositoryFactory.UserRepository) { }

        public bool Exist(string userName) { return CurrentRepository.Exist(u => u.UserName == userName); }

        public User Find(int userID) { return CurrentRepository.Find(u => u.UserID == userID); }

        public User Find(string userName) { return CurrentRepository.Find(u => u.UserName == userName); }

        public IQueryable<User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;

            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "UserID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "UserID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "RegistrationTime";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "RegistrationTime";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "LoginTime";
                    break;
                case 5: _isAsc = false;
                    _orderName = "LoginTime";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "UserID";
                    break;
            }

            return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, _orderName, _isAsc);

        }
    }
}
