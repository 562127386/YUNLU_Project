
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:08:45
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
	/// TN_XMBaseBLL
	/// </summary>	
	public class TN_XMBaseBLL
	{
	    private ITN_XMBaseRepository service=new TN_XMBaseRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_XMBaseCache" ;

        #region 数据获取
        public DataTable GetParentCode(String keyValue)
        {
            return new RepositoryFactory().BaseRepository().FindTable("select Code from TN_XM_Base   where  Name = '" + keyValue + "' and ParentName = '0'");
        }
        
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetList()
        {
            return service.GetList();
        }

        public DataTable GetPageListBySql2(Pagination pagination, string queryJson)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("SELECT * FROM View_ProjectDetails where 1=1 ");
            
            if (!queryParam["Name1"].IsEmpty())
            {
                sb.Append("and Name1 like '%" + queryParam["Name1"] + "%'or Name2 like '%" + queryParam["Name2"] + "%'or Name3 like '%" + queryParam["Name3"] + "%'or Name4 like '%" + queryParam["Name4"] + "%'");
            }
            //if (!queryParam["Name2"].IsEmpty())
            //{
            //    sb.Append("and Name2 like '%" + queryParam["Name2"] + "%'");
            //}
            //if (!queryParam["Name3"].IsEmpty())
            //{
            //    sb.Append("and Name3 like '%" + queryParam["Name3"] + "%'");
            //}
            //if (!queryParam["Name4"].IsEmpty())
            //{
            //    sb.Append("and Name4 like '%" + queryParam["Name4"] + "%'");
            //}
            if (!queryParam["itemId"].IsEmpty())
            {
                sb.Append(" and( Code='" + queryParam["itemId"] + "' or Code1  ='" + queryParam["itemId"] + "' or Code2  ='" + queryParam["itemId"] + "' or Code3  ='" + queryParam["itemId"] + "')");
            }
          
            
            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
        }
        public DataTable GetPageListBySqlXM(Pagination pagination, string queryJson)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("SELECT * FROM View_XM where 1=1 ");

            if (!queryParam["Name"].IsEmpty())
            {
                sb.Append("and Name1 like '%" + queryParam["Name"] + "%'");
            }
            if (!queryParam["itemId"].IsEmpty())
            {
                sb.Append(" and( ParentCode  ='" + queryParam["itemId"] + "'  or Code  ='" + queryParam["itemId"] + "')");
            }
           


            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
        }
        public IEnumerable<TN_XMBaseEntity> GetTreeList()
        {
            return service.GetTreeList();
        }
		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql( string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }


        /// <summary>
        /// 列表获取公司信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListByCompany(string sqlWhere)
        {
            return service.GetListByCompany(sqlWhere);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql2(string sqlWhere)
        {
            return service.GetListBySql2(sqlWhere);
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql3(string sqlWhere)
        {
            return service.GetListBySql3(sqlWhere);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql5(string sqlWhere)
        {
            return service.GetListBySql5(sqlWhere);
        }

		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string Name = queryParam["Name"].ToString();
                sqlWhere.Append(" AND Name like '%" + Name + "%'");
            }
            if (!queryParam["ParentName"].IsEmpty())
            {
                string ParentName = queryParam["ParentName"].ToString();
                sqlWhere.Append(" AND ParentName = '" + ParentName + "'");
            }
            if (!queryParam["itemId"].IsEmpty())
            {
                string Name = queryParam["itemId"].ToString();
                sqlWhere.Append(" and( ParentCode  ='" + Name + "'  or Code  ='" + Name + "')");
               
            }
            return service.GetPageListBySql(pagination, sqlWhere.ToString());
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_XMBaseEntity>();
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
        public IEnumerable<TN_XMBaseEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_XMBaseEntity>();
            var queryParam = queryJson.ToJObject();
             //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Name.Contains(keyord));
               
            }
            return service.GetPageList(pagination, expression);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_XMBaseEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_XMBaseEntity tN_XMBaseEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_XMBaseEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_XMBaseEntity);
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



