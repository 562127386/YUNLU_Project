
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-17 10:07:30
//    ©为之团队
//------------------------------------------------------------------------------
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
using System.Linq.Expressions;
using System.Data;
using JFine.Data.Repository;

namespace JFine.Plugins.RDXM.Busines.TN_XM
{	
	/// <summary>
	/// TN_CPJSBLL
	/// </summary>	
	public class TN_CPJSBLL
	{
	    private ITN_CPJSRepository service=new TN_CPJSRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_CPJSCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CPJSEntity> GetList()
        {
            return service.GetList();
        }
        public DataTable GetCode(String code,String name)
        {
            return new RepositoryFactory().BaseRepository().FindTable("SELECT * FROM View_CPJS where BindId='" + code + "' and Name='" + name + "' ");
        }
        public DataTable GetPageListBySql(Pagination pagination, string queryJson)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("SELECT * FROM TN_CPJS where 1=1 ");
            if (!queryParam["Name"].IsEmpty())
            {
                sb.Append("and Name like '%" + queryParam["Name"] + "%'");
            }
            if (!queryParam["ProjectName"].IsEmpty())
            {
                sb.Append("and ProjectName like '%" + queryParam["ProjectName"] + "%'");
            }
            if (!queryParam["Contract"].IsEmpty())
            {
                sb.Append("and Contract like '%" + queryParam["Contract"] + "%'");
            }
            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CPJSEntity> GetListBySql( string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CPJSEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_CPJSEntity>();
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
        public IEnumerable<TN_CPJSEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_CPJSEntity>();
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
        public TN_CPJSEntity GetForm(string keyValue)
        {
            return service.GetForm(keyValue);
        }
        #endregion


        #region 数据处理

        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_CPJSEntity tN_CPJSEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_CPJSEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_CPJSEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
		/// <summary>
        /// 删除
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



