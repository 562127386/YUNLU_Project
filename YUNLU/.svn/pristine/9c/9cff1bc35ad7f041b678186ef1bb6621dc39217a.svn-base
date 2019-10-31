
/********************************************************************************
**文 件 名:TN_CG_CPBLL
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 14:50:33
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
	/// TN_CG_CPBLL
	/// </summary>	
	public class TN_CG_CPBLL
	{
	    private ITN_CG_CPRepository service=new TN_CG_CPRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_CG_CPCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetList()
        {
            return service.GetList();
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public TN_CG_CPEntity GetListBySql( string sqlWhere)
        {
            sqlWhere = "and Id ='" + sqlWhere + "'";
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
			 List<DbParameter> parameter =  new List<DbParameter>();
             //查询条件
             if (!queryParam["keyValue"].IsEmpty())
             {
                 string keyord = queryParam["keyValue"].ToString();
                 sqlWhere.Append(" AND BindId = '" + keyord + "'");
             }
            //查询条件
            //if (!queryParam["keyword"].IsEmpty())
            //{
            //    string keyword = queryParam["keyword"].ToString();
            //    sqlWhere.Append(" AND (Code like @keyword or Name like @keyword)");
            //    parameter.Add(DbParameters.CreateDbParameter("@keyword","%"+ keyword +"%",DbType.AnsiString));
            //}
            if (!queryParam["CGCode"].IsEmpty())
            {
                string keyord = queryParam["CGCode"].ToString();
                sqlWhere.Append(" AND CGCode = '" + keyord+"'");
                //data = data.TreeWhere(t => t.CGCode.Contains(keyord), "");
            }
            if (!queryParam["ProjectNo"].IsEmpty())
            {
                string keyord = queryParam["ProjectNo"].ToString();
                sqlWhere.Append(" AND ProjectNo = '" + keyord + "'");
                //data = data.TreeWhere(t => t.ProjectNo.Contains(keyord), "");
                //sb.Append(" and ProjectNo = '" + queryParam["ProjectNo"] + "'");
            }
            return service.GetPageListBySql(pagination, sqlWhere.ToString(),parameter);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_CG_CPEntity>();
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
        public IEnumerable<TN_CG_CPEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_CG_CPEntity>();
            if (!queryJson.IsEmpty())
            {
                var queryParam = queryJson.ToJObject();
                //查询条件
                if (!queryParam["keyValue"].IsEmpty())
                {
                    string keyord = queryParam["keyValue"].ToString();
                    expression = expression.And(t => t.BindId.Contains(keyord));
                }
                if (!queryParam["CGCode"].IsEmpty())
                {
                    string keyord = queryParam["CGCode"].ToString();
                    expression = expression.And(t => t.CGCode.Contains(keyord));
                }
                //查询条件
                //if (!queryParam["keyValue"].IsEmpty())
                //{
                //    string keyord = queryParam["keyValue"].ToString();
                //    expression = expression.And(t => t.BindId.Contains(keyord));
                //}
                if (!queryParam["ProjectNo"].IsEmpty())
                {
                    string keyord = queryParam["ProjectNo"].ToString();
                    expression = expression.And(t => t.ProjectNo.Contains(keyord));
                    //sb.Append(" and ProjectNo = '" + queryParam["ProjectNo"] + "'");
                }
            }

            return service.GetPageList(pagination, expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList2(Pagination pagination, string queryJson,int flag = 0)
        {
            var expression = LinqExtensions.True<TN_CG_CPEntity>();
            StringBuilder sb = new StringBuilder();
            //sb.Append("select b.* , a.Code As HTCode,a.Name As HTName,a.HTType AS HTType,a.Id AS HTId from TN_HT_CG  a , TN_CG_CP b where a.id = b.BindId ");
            sb.Append("select * from View_CG_CP where 1=1");
            if (!queryJson.IsEmpty())
            {
                var queryParam = queryJson.ToJObject();
                //查询条件
                if (!queryParam["keyValue"].IsEmpty())
                {
                    sb.Append(" and id = " + queryParam["keyValue"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                if (!queryParam["ProjectName"].IsEmpty())
                {
                    sb.Append(" and ProjectName like '%" + queryParam["ProjectName"]+"%'");
                }
                if (!queryParam["HTName"].IsEmpty())
                {
                    sb.Append(" and HTName like '%" + queryParam["HTName"]+"%'");
                }
                if (!queryParam["Name"].IsEmpty())
                {
                    sb.Append(" and Name like '%" + queryParam["Name"]+"%'");
                }
                if (!queryParam["CGCode"].IsEmpty())
                {
                    //string keyord = queryParam["CGCode"].ToString();
                    //expression = expression.And(t => t.CGCode.Contains(keyord));
                    sb.Append(" and CGCode = '" + queryParam["CGCode"]+"'");
                }
                if (!queryParam["ProjectNo"].IsEmpty())
                {
                    //string keyord = queryParam["CGCode"].ToString();
                    //expression = expression.And(t => t.CGCode.Contains(keyord));
                    sb.Append(" and ProjectNo = '" + queryParam["ProjectNo"]+"'");
                }
            }
            if (flag == 0)
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
            }
            else 
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
            }
            
        }

        /// <summary>
        /// 列表--分页  设备管理
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList5(Pagination pagination, string queryJson, int flag = 0)
        {
            var expression = LinqExtensions.True<TN_CG_CPEntity>();
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from TN_CG_CP  where 1=1 ");
            if (!queryJson.IsEmpty())
            {
                var queryParam = queryJson.ToJObject();
                //查询条件
                if (!queryParam["keyValue"].IsEmpty())
                {
                    sb.Append(" and id = " + queryParam["keyValue"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                //查询条件
                if (!queryParam["BindId"].IsEmpty())
                {
                    sb.Append(" and BindId = " + queryParam["BindId"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                if (!queryParam["ProjectName"].IsEmpty())
                {
                    sb.Append(" and ProjectName like '%" + queryParam["ProjectName"]+"%'");
                }
                if (!queryParam["ProjectNo"].IsEmpty())
                {
                    sb.Append(" and ProjectNo = '" + queryParam["ProjectNo"] + "'");
                }
                if (!queryParam["HTName"].IsEmpty())
                {
                    sb.Append(" and CGName like '%" + queryParam["HTName"]+"%'");
                }
                if (!queryParam["Name"].IsEmpty())
                {
                    sb.Append(" and Name like '%" + queryParam["Name"]+"%'");
                }
                if (!queryParam["CGCode"].IsEmpty())
                {
                    //string keyord = queryParam["CGCode"].ToString();
                    //expression = expression.And(t => t.CGCode.Contains(keyord));
                }
            }
            if (flag == 0)
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
            }
            else
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
            }

        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList4(Pagination pagination, string queryJson, int flag = 0)
        {
            var expression = LinqExtensions.True<TN_CG_CPEntity>();
            StringBuilder sb = new StringBuilder();
            //sb.Append("select b.* , a.Code As HTCode,a.Name As HTName,a.HTType AS HTType,a.Id AS HTId from TN_HT_CG  a , TN_CG_CP b where a.id = b.BindId ");
            sb.Append("select * from TN_CG_CP where 1=1");
            if (!queryJson.IsEmpty())
            {
                var queryParam = queryJson.ToJObject();
                //查询条件
                if (!queryParam["keyValue"].IsEmpty())
                {
                    sb.Append("and a.id = " + queryParam["keyValue"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                if (!queryParam["ProjectName"].IsEmpty())
                {
                    sb.Append("and ProjectName = " + queryParam["ProjectName"]);
                }
                if (!queryParam["HTName"].IsEmpty())
                {
                    sb.Append("and HTName = " + queryParam["HTName"]);
                }
                if (!queryParam["Name"].IsEmpty())
                {
                    sb.Append("and Name = " + queryParam["Name"]);
                }
                if (!queryParam["Id"].IsEmpty())
                {
                    sb.Append("and BindId = " + queryParam["Id"]);
                }
                if (!queryParam["CGCode"].IsEmpty())
                {
                    //string keyord = queryParam["CGCode"].ToString();
                    //expression = expression.And(t => t.CGCode.Contains(keyord));
                }
            }
            if (flag == 0)
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
            }
            else
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
            }

        }

        /// <summary>
        /// 列表--分页  项目下关联设备
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList6(Pagination pagination, string queryJson, int flag = 0)
        {
            var expression = LinqExtensions.True<TN_CG_CPEntity>();
            StringBuilder sb = new StringBuilder();
            //sb.Append("select b.* , a.Code As HTCode,a.Name As HTName,a.HTType AS HTType,a.Id AS HTId from TN_HT_CG  a , TN_CG_CP b where a.id = b.BindId ");
            sb.Append("select * from TN_CG_CP where 1=1");
            if (!queryJson.IsEmpty())
            {
                var queryParam = queryJson.ToJObject();
                //查询条件
                if (!queryParam["keyValue"].IsEmpty())
                {
                    sb.Append("and a.id = " + queryParam["keyValue"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                if (!queryParam["ProjectNo"].IsEmpty())
                {
                    sb.Append("and ProjectNo = '" + queryParam["ProjectNo"]+"'");
                }
                if (!queryParam["ProjectName"].IsEmpty())
                {
                    sb.Append("and ProjectName = '" + queryParam["ProjectName"]+"'");
                }
                if (!queryParam["HTName"].IsEmpty())
                {
                    sb.Append("and HTName = '" + queryParam["HTName"]+"'");
                }
                if (!queryParam["Name"].IsEmpty())
                {
                    sb.Append("and Name = '" + queryParam["Name"]+"'");
                }
                if (!queryParam["Id"].IsEmpty())
                {
                    sb.Append("and BindId = " + queryParam["Id"]);
                }
                if (!queryParam["CGCode"].IsEmpty())
                {
                    //string keyord = queryParam["CGCode"].ToString();
                    //expression = expression.And(t => t.CGCode.Contains(keyord));
                }
            }
            if (flag == 0)
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
            }
            else
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
            }

        }


        /// <summary>
        /// 列表--分页  设备管理  --- 设备付款
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList7(Pagination pagination, string queryJson, int flag = 0)
        {
            var expression = LinqExtensions.True<TN_CG_CPEntity>();
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from TN_CG_CP  where 1=1 and Quantity <> PayQuantity ");
            if (!queryJson.IsEmpty())
            {
                var queryParam = queryJson.ToJObject();
                //查询条件
                if (!queryParam["keyValue"].IsEmpty())
                {
                    sb.Append(" and id = " + queryParam["keyValue"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                //查询条件
                if (!queryParam["BindId"].IsEmpty())
                {
                    sb.Append(" and BindId = " + queryParam["BindId"]);
                    //string keyord = queryParam["keyValue"].ToString();
                    //expression = expression.And(t => t.BindId.Contains(keyord));
                }
                if (!queryParam["ProjectName"].IsEmpty())
                {
                    sb.Append(" and ProjectName like '%" + queryParam["ProjectName"] + "%'");
                }
                if (!queryParam["ProjectNo"].IsEmpty())
                {
                    sb.Append(" and ProjectNo = '" + queryParam["ProjectNo"] + "'");
                }
                if (!queryParam["HTName"].IsEmpty())
                {
                    sb.Append(" and CGName like '%" + queryParam["HTName"] + "%'");
                }
                if (!queryParam["Name"].IsEmpty())
                {
                    sb.Append(" and Name like '%" + queryParam["Name"] + "%'");
                }
                if (!queryParam["CGCode"].IsEmpty())
                {
                    //string keyord = queryParam["CGCode"].ToString();
                    //expression = expression.And(t => t.CGCode.Contains(keyord));
                }
            }
            if (flag == 0)
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
            }
            else
            {
                return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
            }

        }

        /// <summary>
        /// 金额汇总列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList3(Pagination pagination, string queryJson)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("select distinct a.Name, sum(paidAmount) AS paidAmount,sum(unpaidAmount) AS unpaidAmount,sum(Amount) AS Amount "
            +"from TN_HT_CG a,TN_CG_CP b,TN_HT c where 1=1 and a.id = b.BindId and b.ProjectNo = c.ProjectNo and c.FundSource = '亚行贷款' group by a.Name");
            //if (!queryParam["ProjectNo"].IsEmpty())
            //{
            //    string keyord = queryParam["ProjectNo"].ToString();
            //    sb.Append("and ProjectNo = '" + keyord + "'");
            //    //expression = expression.And(t => t.Name.Contains(keyord));
            //}
            //sb.Append(" group by ProjectName,FundSource   order by ProjectName,FundSource");
            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_CG_CPEntity GetForm(string keyValue)
        {
            return service.GetForm(keyValue);
        }
        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public DataTable GetForm2(string keyValue)
        {
            return service.GetForm2(keyValue);
        }
        #endregion

        #region 数据处理

        

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_CG_CPEntity tN_CG_CPEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_CG_CPEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_CG_CPEntity);
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
