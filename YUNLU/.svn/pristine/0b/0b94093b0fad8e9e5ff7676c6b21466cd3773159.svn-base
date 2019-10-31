
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:18:28
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
using JFine.Code.Online;
using JFine.Data.Repository;
using System.Data;

namespace JFine.Busines.TN_XM
{	
	/// <summary>
	/// TN_HTBLL
	/// </summary>	
	public class TN_HTBLL
	{
	    private ITN_HTRepository service=new TN_HTRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_HTCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetList()
        {
            return service.GetList();
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetListBySql3(string sqlWhere)
        {
            var current = OnlineUser.Operator.GetCurrent();
            if (!current.IsSystem && current.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sqlWhere = "and CreateUserId ='" + current.Account+"'";
            }
            return service.GetListBySql(sqlWhere);
        }


        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetListBySql(string sqlWhere)
        {
            return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetListBySql2( string sqlWhere)
        {
			return service.GetListBySql2(sqlWhere);
        }





		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                //var strSql = new StringBuilder();
                sqlWhere.Append("and b.CompanyId = '" + currentUser.CompanyId + "'");
                //return service.GetPageListBySql(pagination, strSql.ToString());
            }
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string keyword = queryParam["Name"].ToString();
                sqlWhere.Append(" AND (ProjectName like '%" + keyword + "%' or AName like '%" + keyword + "%' or BName like '%" + keyword + "%' or a.Name like '%" + keyword + "%')");
            }
            //if (!queryParam["AName"].IsEmpty())
            //{
            //    string keyword = queryParam["AName"].ToString();
            //    sqlWhere.Append(" AND AName like '%" + keyword + "%'");
            //}
            //if (!queryParam["BName"].IsEmpty())
            //{
            //    string keyword = queryParam["BName"].ToString();
            //    sqlWhere.Append(" AND BName like '%" + keyword + "%'");
            //}
            //if (!queryParam["Name"].IsEmpty())
            //{
            //    string keyword = queryParam["Name"].ToString();
            //    sqlWhere.Append(" AND Name like '%" + keyword + "%'");
            //}

            return service.GetPageListBySql(pagination, sqlWhere.ToString());
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_HTEntity>();
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
        public IEnumerable<TN_HTEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_HTEntity>();
            var queryParam = queryJson.ToJObject();
             //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["Code"].IsEmpty())
            {
                string code = queryParam["Code"].ToString();
                expression = expression.And(t => t.Name.Contains(code));
            }
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
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
        public DataTable GetPageList2(Pagination pagination, string queryJson, int flag = 0)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("SELECT * FROM View_HT where 1=1 ");

            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sb.Append("and CompanyId like '" + currentUser.CompanyId + "'");
                //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                sb.Append("and (Name like '%" + keyord + "%'or Code  like '%"+ keyord + "%')");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }

            if (!queryParam["ProjectName"].IsEmpty())
            {
                string keyord = queryParam["ProjectName"].ToString();
                sb.Append("and ProjectName like '%" + keyord + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["ProjectNo"].IsEmpty())
            {
                string keyord = queryParam["ProjectNo"].ToString();
                sb.Append("and ProjectNo = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["Name"].IsEmpty())
            {
                string keyord = queryParam["Name"].ToString();
                sb.Append("and Name like '%" + keyord + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["SignDate1"].IsEmpty())
            {
                string keyord = queryParam["SignDate1"].ToString();
                sb.Append("and SignDate >= '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["SignDate2"].IsEmpty())
            {
                string keyord = queryParam["SignDate2"].ToString();
                sb.Append("and SignDate <= '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["FundSource"].IsEmpty())
            {
                string keyord = queryParam["FundSource"].ToString();
                sb.Append("and FundSource like '%" + keyord + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }

            if (!queryParam["Code"].IsEmpty())
            {
                sb.Append(" and( ProjectNo='" + queryParam["Code"] + "' or BaseCode  ='" + queryParam["Code"] + "' or BaseSubCode  ='" + queryParam["Code"] + "' or Code3  ='" + queryParam["Code"] + "')");
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
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
           

            var currentUser = OnlineUser.Operator.GetCurrent();

            if (!queryParam["BeginDate"].IsEmpty() && !queryParam["EndDate"].IsEmpty())
            {
                string BeginDate = queryParam["BeginDate"].ToString();
                string EndDate = queryParam["EndDate"].ToString();
                sb.Append("select * from (select t.*,t2.sumAmount from TN_HT t left join " +
                    " (  select BindId, sum(PaymentAmount)as sumAmount from  TN_FK_MX where PaidDate >= '"+ BeginDate + "' " +
                    " and PaidDate <='"+ EndDate + "' group by bindid  )t2 on t.id=t2.BindId) t3  where ((SignDate >= '"+ BeginDate + "' " +
                    " and SignDate <='"+ EndDate + "') or sumAmount is not null) ");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            else
            {
                sb.Append("select * from (select t.*,t2.sumAmount from TN_HT t left join " +
                    " (  select BindId, sum(PaymentAmount)as sumAmount from  TN_FK_MX  " +
                    " group by bindid  )t2 on t.id=t2.BindId) t3  where 1=1 ");
            }
            if (!queryParam["ProjectNo"].IsEmpty())
            {
                string keyord = queryParam["ProjectNo"].ToString();
                sb.Append(" and ProjectNo = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }

            if (!queryParam["Code"].IsEmpty())
            {
                sb.Append(" and( ProjectNo='" + queryParam["Code"] + "' or BaseCode  ='" + queryParam["Code"] + "' or BaseSubCode  ='" + queryParam["Code"] + "' or Code3  ='" + queryParam["Code"] + "')");
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
            sb.Append("select distinct ProjectName,sum(paidAmount) AS paidAmount,sum(unpaidAmount) AS unpaidAmount,sum(Amount) AS Amount from TN_HT where 1=1 ");
            if (!queryParam["ProjectNo"].IsEmpty())
            {
                string keyord = queryParam["ProjectNo"].ToString();
                sb.Append("and ProjectNo = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            sb.Append(" group by ProjectName   order by ProjectName");
            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString());
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_HTEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_HTEntity tN_HTEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_HTEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_HTEntity);
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



