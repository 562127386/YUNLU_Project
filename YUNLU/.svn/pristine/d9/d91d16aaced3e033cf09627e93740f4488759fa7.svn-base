
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:22:16
//    ©为之团队
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JFine.Domain.Models.TN_XM;
using JFine.Domain.IRepository.TN_XM;
using JFine.Domain.Repository.TN_XM;
using JFine.Cache;
using JFine.Common.UI;
using JFine.Common.Extend;
using JFine.Common.Json;
using System.Linq.Expressions;
using JFine.Data.Repository;
using System.Data;

namespace JFine.Busines.TN_XM
{	
	/// <summary>
	/// TN_JSBLL
	/// </summary>	
	public class TN_JSBLL
	{
	    private ITN_JSRepository service=new TN_JSRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_JSCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_JSEntity> GetList()
        {
            return service.GetList();
        }
        public DataTable GetCode(String keyValue)
        {
            return new RepositoryFactory().BaseRepository().FindTable("SELECT * FROM TN_HT  where  Name LIKE '%" + keyValue + "%'  ");
        }
		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_JSEntity> GetListBySql( string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_JSEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["HTNo"].IsEmpty())
            {
                string keyword = queryParam["HTNo"].ToString();
                sqlWhere.Append(" AND HTNo like '%" + keyword + "%' ");
            }
            if (!queryParam["VoucherNo"].IsEmpty())
            {
                string keyword = queryParam["VoucherNo"].ToString();
                sqlWhere.Append(" AND VoucherNo like '%" + keyword + "%' ");
            }
            if (!queryParam["ProjectName"].IsEmpty())
            {
                string keyword = queryParam["ProjectName"].ToString();
                sqlWhere.Append(" AND ProjectName like '%" + keyword + "%' ");
            }
            if (!queryParam["SupplierName"].IsEmpty())
            {
                string keyword = queryParam["SupplierName"].ToString();
                sqlWhere.Append(" AND SupplierName like '%" + keyword + "%' ");
            }
            
            return service.GetPageListBySql(pagination, sqlWhere.ToString());
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_JSEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_JSEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["HTNo"].IsEmpty())
            {
                string HTNo = queryParam["HTNo"].ToString();
                expression = expression.And(t => t.HTNo.Contains(HTNo));
            }
			return service.GetList(expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_JSEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_JSEntity>();
            var queryParam = queryJson.ToJObject();
             //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                expression = expression.And(t => t.HTNo.Contains(keyord));
            }
            return service.GetPageList(pagination, expression);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_JSEntity GetForm(string keyValue)
        {
            return service.GetForm(keyValue);
        }
        #endregion

        #region 数据处理

        

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_JSEntity tN_JSEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_JSEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_JSEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void DeleteForm(string keyValue)
        {
            try
            {
                service.DeleteForm(keyValue);
                CacheFactory.Cache().RemoveCache(cacheKey);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}



