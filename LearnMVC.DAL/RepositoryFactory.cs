/************************************************************************ 
 * Projt Name  :  LearnMVC.DAL       
 * File Name   :  RepositoryFactory 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 3:14:03 PM 
 * Update Time :  5/6/2016 3:14:03 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using LearnMVC.IDAL;

namespace LearnMVC.DAL
{
    public static class RepositoryFactory
    {
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }

    }
}
