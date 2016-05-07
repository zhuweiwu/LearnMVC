/************************************************************************ 
 * Projt Name  :  LearnMVC.DAL       
 * File Name   :  ContextFactory 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 3:00:07 PM 
 * Update Time :  5/6/2016 3:00:07 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace LearnMVC.DAL
{
    public class ContextFactory
    {
        public static MyDBContext GetCurrentContext()
        {
            MyDBContext _nContext = CallContext.GetData("myContext") as MyDBContext;
            if (_nContext == null)
            {
                _nContext = new MyDBContext();
                CallContext.SetData("myContext", _nContext);
            }
            return _nContext;
        }

    }
}
