/************************************************************************ 
 * Projt Name  :  LearnMVC.IBLL       
 * File Name   :  InterfaceBaseService 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 3:15:22 PM 
 * Update Time :  5/6/2016 3:15:22 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/

namespace LearnMVC.IBLL
{
    public interface InterfaceBaseService<T> where T : class
    {
        T Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

    }
}
