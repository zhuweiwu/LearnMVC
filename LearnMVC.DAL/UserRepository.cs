/************************************************************************ 
 * Projt Name  :  LearnMVC.DAL       
 * File Name   :  UserRepository 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 3:12:39 PM 
 * Update Time :  5/6/2016 3:12:39 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/

using LearnMVC.IDAL;
using LearnMVC.Models;
using System.Linq;

namespace LearnMVC.DAL
{
    class UserRepository : BaseRepository<User>, InterfaceUserRepository
    {

    }
}
