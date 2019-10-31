
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-16 16:14:20
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
using JFine.Code.Online;

namespace JFine.Plugins.RDXM.Busines.TN_XM
{	
	/// <summary>
	/// TN_CPBLL
	/// </summary>	
	public class TN_CPBLL
	{
	    private ITN_CPRepository service=new TN_CPRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_CPCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CPEntity> GetList()
        {
            return service.GetList();
        }
        public DataTable GetCode(String keyValue)
        {
            return new RepositoryFactory().BaseRepository().FindTable("select Code,ProjectName from TN_HT   where  Name LIKE '%" + keyValue + "%'  ");
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CPEntity> GetListBySql( string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CPEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_CPEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["Code"].IsEmpty())
            {
                string name = queryParam["Code"].ToString();
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
        public IEnumerable<TN_CPEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_CPEntity>();         
             //查询条件
            var queryParam = queryJson.ToJObject();
            if (!queryParam["Id"].IsEmpty())
            {
                string id = queryParam["Id"].ToString();
                expression = expression.And(t => t.BindId.Contains(id));
            }

            if (!queryParam["HTNo"].IsEmpty())
            {
                string HTNo = queryParam["HTNo"].ToString();
                expression = expression.And(t => t.HTNo.Contains(HTNo));
            }
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId  !="30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                expression = expression.And(t => t.CreateUserId.Contains(currentUser.Account));
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
            //查询条件
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("SELECT * FROM View_CP where 1=1 ");

            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sb.Append("and CompanyId like '" + currentUser.CompanyId + "'");
                //expression = expression.And(t => t.CreateUserId.Contains(currentUser.Account));
            }

            if (!queryParam["Code"].IsEmpty())
            {
                sb.Append(" and( Code='" + queryParam["Code"] + "' or BaseCode  ='" + queryParam["Code"] + "' or BaseSubCode  ='" + queryParam["Code"] + "')");
            }

            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                sb.Append("and (HTName like '%" + keyord + "%'or HTNo  like '%" + keyord + "%' or Name like'%" + keyord +"%' )");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }

            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
        }


        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList3(Pagination pagination, string queryJson)
        {
            //查询条件
            StringBuilder strSql = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            strSql.Append(@" select a.*,b.ProjectName from TN_CP a,TN_HT b,TN_XM c  where a.HTNo = b.Code and b.ProjectNo = c.RulesCode+'-'+c.Code");

            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                strSql.Append("and c.CompanyId = '" + currentUser.CompanyId + "'");
                //strSql.Append("and CompanyId like '" + currentUser.CompanyId + "'");
                //expression = expression.And(t => t.CreateUserId.Contains(currentUser.Account));
            }

            if (!queryParam["Code"].IsEmpty())
            {
                strSql.Append(" and( b.ProjectNo ='" + queryParam["Code"] + "' or c.BaseCode  ='" + queryParam["Code"] + "' or c.BaseSubCode  ='" + queryParam["Code"] + "' or a.HTNO = '" + queryParam["Code"] + "')");
            }

            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                strSql.Append("and (HTName like '%" + keyord + "%'or HTNo  like '%" + keyord + "%' or Name like'%" + keyord + "%' )");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }

            return new RepositoryFactory().BaseRepository().FindTable(strSql.ToString(), pagination);
        }




        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_CPEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_CPEntity tN_CPEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_CPEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_CPEntity);
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



