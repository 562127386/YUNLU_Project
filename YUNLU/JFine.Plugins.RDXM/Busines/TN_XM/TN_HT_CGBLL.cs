
/********************************************************************************
**文 件 名:TN_HT_CGBLL
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 14:56:44
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using JFine.Plugins.RDXM.Domain.IRepository.TN_XM;
using JFine.Plugins.RDXM.Domain.Repository.TN_XM;
using JFine.Cache;
using JFine.Common.UI;
using JFine.Common.Extend;
using JFine.Common.Json;
using JFine.Data.Common;
using System.Linq.Expressions;
using System.Data.Common;
using System.Data;
using JFine.Data.Repository;

namespace JFine.Plugins.RDXM.Busines.TN_XM
{	
	/// <summary>
	/// TN_HT_CGBLL
	/// </summary>	
	public class TN_HT_CGBLL
	{
	    private ITN_HT_CGRepository service=new TN_HT_CGRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_HT_CGCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetList()
        {
            return service.GetList();
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetListBySql( string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
			 List<DbParameter> parameter =  new List<DbParameter>();
            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                sqlWhere.Append(" AND (Code like @keyword or Name like @keyword)");
				parameter.Add(DbParameters.CreateDbParameter("@keyword","%"+ keyword +"%",DbType.AnsiString));
            }
            
            return service.GetPageListBySql(pagination, sqlWhere.ToString(),parameter);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_HT_CGEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string name = queryParam["Name"].ToString();
                expression = expression.And(t => t.Name.Contains(name));
            }
			return service.GetList(expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_HT_CGEntity>();
            var queryParam = queryJson.ToJObject();
             //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Name.Contains(keyord));
            }
            //查询条件
            if (!queryParam["Code"].IsEmpty())
            {
                string keyord = queryParam["Code"].ToString();
                expression = expression.And(t => t.Code.Contains(keyord));
            }
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string keyord = queryParam["Name"].ToString();
                expression = expression.And(t => t.Name.Contains(keyord));
            }
            //查询条件
            if (!queryParam["CPpackage"].IsEmpty())
            {
                string keyord = queryParam["CPpackage"].ToString();
                expression = expression.And(t => t.CPpackage.Contains(keyord));
            }
            return service.GetPageList(pagination, expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList2(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TN_HT_CGEntity>();
            var queryParam = queryJson.ToJObject();
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from TN_HT_CG where id in (select distinct bindId from TN_CG_CP  where 1=1");
            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                //string keyord = queryParam["keyword"].ToString();
                //expression = expression.And(t => t.Name.Contains(keyord));
                sb.Append(")and Name like '" + queryParam["keyword"] + "'");
            }
            //查询条件
            if (!queryParam["Code"].IsEmpty())
            {
                //string keyord = queryParam["Code"].ToString();
                //expression = expression.And(t => t.Code.Contains(keyord));
                sb.Append(" and ProjectNo ='" + queryParam["Code"] + "')");
            }
            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
        }

        /// <summary>
        /// 列表--采购合同打印
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList3(string queryJson)
        {
            var expression = LinqExtensions.True<TN_HT_CGEntity>();
            var queryParam = queryJson.ToJObject();
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from TN_HT_CG where 1=1");
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                //string keyord = queryParam["keyword"].ToString();
                //expression = expression.And(t => t.Name.Contains(keyord));
                sb.Append(" and Name like '" + queryParam["keyword"] + "'");
            }
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                //string keyord = queryParam["keyword"].ToString();
                //expression = expression.And(t => t.Name.Contains(keyord));
                sb.Append("and Name like '" + queryParam["keyword"] + "'");
            }
            //查询条件
            if (!queryParam["CPpackage"].IsEmpty())
            {
                //string keyord = queryParam["Code"].ToString();
                //expression = expression.And(t => t.Code.Contains(keyord));
                sb.Append(" and CPpackage ='" + queryParam["CPpackage"] + "')");
            }
            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
        }


        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_HT_CGEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_HT_CGEntity tN_HT_CGEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_HT_CGEntity);
                CacheFactory.Cache().WriteCache(cacheKey, tN_HT_CGEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public void SaveForm2(string keyValue, TN_HT_CGEntity tN_HT_CGEntity,string items)
        {
            try
            {
                service.SaveForm2(keyValue, tN_HT_CGEntity,items);
                CacheFactory.Cache().WriteCache(cacheKey,tN_HT_CGEntity);
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
