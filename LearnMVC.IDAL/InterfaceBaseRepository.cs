using System;
using System.Linq;
using System.Linq.Expressions;

namespace LearnMVC.IDAL
{
    public interface InterfaceBaseRepository<T>
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity">Data Entity</param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// query count
        /// </summary>
        /// <param name="predicate">expression</param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(T entity);

        /// <summary>
        /// exist
        /// </summary>
        /// <param name="anyLambda"></param>
        /// <returns>boolean</returns>
        bool Exist(Expression<Func<T, bool>> anyLamdba);

        /// <summary>
        /// find one
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns>entity</returns>
        T Find(Expression<Func<T, bool>> whereLamdba);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="whereLamdba"></param>
        /// <param name="orderName"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba, string orderName,  bool isAsc);

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecord"></param>
        /// <param name="whereLamdba"></param>
        /// <param name="orderName"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc);

    }
}
