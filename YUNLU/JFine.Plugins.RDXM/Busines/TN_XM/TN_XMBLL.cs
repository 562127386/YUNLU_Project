
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:14:16
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
using System.Data;
using JFine.Data.Repository;
using System.Data.Common;
using JFine.Data.Common;

namespace JFine.Busines.TN_XM
{	
	/// <summary>
	/// TN_XMBLL
	/// </summary>	
	public class TN_XMBLL
	{
	    private ITN_XMRepository service=new TN_XMRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey ="TN_XMCache" ;

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetList()
        {
            return service.GetList();
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetListBySql( string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

        /// <summary>
        /// 根据公司取数
        /// </summary>
        /// <param name="sqlWhere"></param>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetListBySql2(string sqlWhere)
        {
            var current = OnlineUser.Operator.GetCurrent();
            if (!current.IsSystem && current.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sqlWhere = "and CompanyId = '" + current.CompanyId +"'";
            }
            return service.GetListBySql(sqlWhere);
        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            //查询条件
             
            if (!queryParam["Name"].IsEmpty())
            {
                string Name = queryParam["Name"].ToString();
                sqlWhere.Append(" AND Name like '%" + Name + "%'");
            }
            if (!queryParam["BaseSubName"].IsEmpty())
            {
                string Name = queryParam["BaseSubName"].ToString();
                sqlWhere.Append(" AND BaseSubName like '%" + Name + "%'");
            }
            if (!queryParam["ConstructionUnit"].IsEmpty())
            {
                string Name = queryParam["ConstructionUnit"].ToString();
                sqlWhere.Append(" AND ConstructionUnit like '%" + Name + "%'");
            }
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sqlWhere.Append(" AND CompanyId like '%" + currentUser.CompanyId + "%'");
                //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            return service.GetPageListBySql(pagination, sqlWhere.ToString());
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetList( string queryJson)
        {
             var expression = LinqExtensions.True<TN_XMEntity>();
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
        public IEnumerable<TN_XMEntity> GetPageList(Pagination pagination, string queryJson)
        {
			var expression = LinqExtensions.True<TN_XMEntity>();
            var queryParam = queryJson.ToJObject();
             //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string keyord = queryParam["Name"].ToString();
                expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["Code"].IsEmpty())
            {
                string keyord = queryParam["Code"].ToString();
                expression = expression.And(t => t.Code.Contains(keyord));
                expression = expression.Or(t => t.BaseSubCode.Contains(keyord));
                expression = expression.Or(t => t.BaseCode.Contains(keyord));
            }
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            //if (!queryParam["Code"].IsEmpty())
            //{
            //    string Code = queryParam["Code"].ToString();
            //    expression = expression.And(t => t.Code.Equals(Code));
            //}
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
            sb.Append("SELECT * FROM TN_XM where 1=1 ");
            //所属公司
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sb.Append("and CompanyId like '" + currentUser.CompanyId + "'");
                //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string keyord = queryParam["Name"].ToString();
                sb.Append("and Name like '%" + keyord + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            //查询条件
            if (!queryParam["CPpackage"].IsEmpty())
            {
                string keyord = queryParam["CPpackage"].ToString();
                sb.Append("and CPpackage like '%" + keyord + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["BeginDate1"].IsEmpty())
            {
                string keyord = queryParam["BeginDate1"].ToString();
                sb.Append("and BeginDate >= '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["BeginDate2"].IsEmpty())
            {
                string keyord = queryParam["BeginDate2"].ToString();
                sb.Append("and BeginDate <= '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            //查询条件
            //if (!queryParam["BeginDate"].IsEmpty() && !queryParam["EndDate"].IsEmpty())
            //{
            //    string keyord = queryParam["BeginDate"].ToString();
            //    string keyord1 = queryParam["EndDate"].ToString();
            //    sb.Append("and BeginDate  between  BeginDate '" + keyord + "'and '" + keyord1 + "'");
            //    //expression = expression.And(t => t.Name.Contains(keyord));
            //}

            if (!queryParam["Code"].IsEmpty())
            {
                sb.Append(" and( RulesCode+'-'+Code='" + queryParam["Code"] + "' or BaseCode  ='" + queryParam["Code"] + "' or BaseSubCode  ='" + queryParam["Code"] + "')");
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
        /// 列表--分页--项目亚行贷款金额
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList4(Pagination pagination, string queryJson, int flag = 0)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            //string Id = queryParam["Id"].ToString();
            sb.Append("select * from View_XM_JEHZ where 1=1");
            //所属公司
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sb.Append("and CompanyId like '" + currentUser.CompanyId + "'");
                //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            //查询条件
            if (!queryParam["Id"].IsEmpty())
            {
                string keyord = queryParam["Id"].ToString();
                sb.Append("and CGHTId = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            //查询条件
            if (!queryParam["keyValue"].IsEmpty())
            {
                string keyord = queryParam["keyValue"].ToString();
                sb.Append("and Id = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            //sb.Append("select isnull((select top(1) 1 from TN_FK_MX where PayType = '尾款' and BindId = @keyValue ),0) as a ");
            //List<DbParameter> dbParameter = new List<DbParameter>();
            ////DbParameter dbp = DbParameters.CreateDbParameter("@keyValue", keyValue);
            //dbParameter.Add(DbParameters.CreateDbParameter("@keyValue", Id, DbType.AnsiString));
            //string str = new RepositoryFactory().BaseRepository().getString(sb.ToString(), "a", dbParameter);
            //sb.Length = 0;
            //if (int.Parse(str) == 0)
            //{
            //    sb.Append(" select t.*,t1.TaxTotal as Amount from (select * from TN_XM where RulesCode+'-'+Code in (select distinct ProjectNo from TN_CG_CP where BindId = '" + Id + "')) t"
            //                + " left join ( select a.Id, ISNULL(sum(TaxTotal)*0.1,0)+ISNULL(sum(PaymentAmount),0) as TaxTotal from TN_XM a,TN_CG_CP b ,TN_CP_FKMX c "
            //                + " where a.RulesCode+'-'+a.Code = b.ProjectNo and a.RulesCode+'-'+a.Code = b.ProjectNo group by a.Id) t1"
            //                + " on t.Id = t1.id ");
            //}
            //else
            //{
            //    sb.Append("  select t.*,t1.TaxTotal as Amount from (select * from TN_XM where RulesCode+'-'+Code in (select distinct ProjectNo from TN_CG_CP where BindId = '" + Id + "')) t"
            //                + " left join (select a.id, sum(TaxTotal)*0.1 as TaxTotal from TN_XM a,TN_CG_CP b where a.RulesCode+'-'+a.Code = b.ProjectNo  group by a.Id) t1"
            //                + " on t.Id = t1.id ");
            //}
            //sb.Append("select * from TN_XM where RulesCode+'-'+Code in (select distinct ProjectNo from TN_CG_CP where BindId = '" + Id + "') ");
            //sb.Append(" if (select isnull((select top(1) 1 from TN_FK_MX where FKNumber = '第三批次' and BindId = 1045531396715712512),0)) = 0 "
            //+ " begin"
            //+ " select t.*,t1.TaxTotal as Amount from (select * from TN_XM where RulesCode+'-'+Code in (select distinct ProjectNo from TN_CG_CP where BindId = '" + Id + "')) t"
            //+ " left join ( select a.Id, ISNULL(sum(TaxTotal)*0.1,0)+ISNULL(sum(PaymentAmount),0) as TaxTotal from TN_XM a,TN_CG_CP b ,TN_CP_FKMX c "
            //+ " where a.RulesCode+'-'+a.Code = b.ProjectNo and a.RulesCode+'-'+a.Code = b.ProjectNo group by a.Id) t1"
            //+ " on t.Id = t1.id "
            //+ " end"
            //+ " else"
            //+ " begin"
            //+ " select t.*,t1.TaxTotal as Amount from (select * from TN_XM where RulesCode+'-'+Code in (select distinct ProjectNo from TN_CG_CP where BindId = '" + Id + "')) t"
            //+ " left join (select a.id, sum(TaxTotal)*0.1 as TaxTotal from TN_XM a,TN_CG_CP b where a.RulesCode+'-'+a.Code = b.ProjectNo  group by a.Id) t1"
            //+ " on t.Id = t1.id "
            //+ " end");
            //var currentUser = OnlineUser.Operator.GetCurrent();
            //if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            //{
            //    sb.Append("and CompanyId like '" + currentUser.CompanyId + "'");
            //    //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            //}
            ////查询条件
            //if (!queryParam["Name"].IsEmpty())
            //{
            //    string keyord = queryParam["Name"].ToString();
            //    sb.Append("and Name like '%" + keyord + "%'");
            //    //expression = expression.And(t => t.Name.Contains(keyord));
            //}
            ////查询条件
            //if (!queryParam["CPpackage"].IsEmpty())
            //{
            //    string keyord = queryParam["CPpackage"].ToString();
            //    sb.Append("and CPpackage like '%" + keyord + "%'");
            //    //expression = expression.And(t => t.Name.Contains(keyord));
            //}
            ////查询条件
            //if (!queryParam["BeginDate"].IsEmpty() && !queryParam["EndDate"].IsEmpty())
            //{
            //    string keyord = queryParam["BeginDate"].ToString();
            //    string keyord1 = queryParam["EndDate"].ToString();
            //    sb.Append("and BeginDate  between  BeginDate '" + keyord + "'and '" + keyord1 + "'");
            //    //expression = expression.And(t => t.Name.Contains(keyord));
            //}

            //if (!queryParam["Code"].IsEmpty())
            //{
            //    sb.Append(" and( RulesCode+'-'+Code='" + queryParam["Code"] + "' or BaseCode  ='" + queryParam["Code"] + "' or BaseSubCode  ='" + queryParam["Code"] + "')");
            //}

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
        /// 列表--分页--项目亚行贷款金额
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList3(Pagination pagination, string queryJson, int flag = 0)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            //string Id = queryParam["Id"].ToString();
            sb.Append("select * from View_XM_JEHZ where 1=1");
            //所属公司
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sb.Append("and CompanyId like '" + currentUser.CompanyId + "'");
                //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            //查询条件
            if (!queryParam["Id"].IsEmpty())
            {
                string keyord = queryParam["Id"].ToString();
                sb.Append("and CGHTId = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            //查询条件
            if (!queryParam["keyValue"].IsEmpty())
            {
                string keyord = queryParam["keyValue"].ToString();
                sb.Append("and Id = '" + keyord + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
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

        public DataTable GetPageListBySql2(Pagination pagination, string queryJson)
        {
            StringBuilder sb = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            sb.Append("SELECT * FROM View_XM1 where 1=1 ");

            //if (!queryParam["Name1"].IsEmpty())
            //{
            //    sb.Append("and Name1 like '%" + queryParam["Name1"] + "%'");
            //}
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


            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                sb.Append("and Name3 like '%" + keyord + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                sb.Append("and CompanyId like '%" + currentUser.CompanyId + "%'");
                //expression = expression.And(t => t.CompanyId.Contains(currentUser.CompanyId));
            }
            if (!queryParam["itemId"].IsEmpty())
            {
                sb.Append(" and( Code='" + queryParam["itemId"] + "' or Code1  ='" + queryParam["itemId"] + "' or Code2  ='" + queryParam["itemId"] + "' or Code3  ='" + queryParam["itemId"] + "')");
            }


            return new RepositoryFactory().BaseRepository().FindTable(sb.ToString(), pagination);
        }


        /// <summary>
        /// 获取附件报表
        /// </summary>
        /// <param name="queryJson"></param>
        /// <returns></returns>
        public DataTable GetAdjunctReport(string queryJson)
        {
            try
            {
                return service.GetAdjunctReport(queryJson);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_XMEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_XMEntity tN_XMEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_XMEntity);
                CacheFactory.Cache().WriteCache(cacheKey,tN_XMEntity);
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



