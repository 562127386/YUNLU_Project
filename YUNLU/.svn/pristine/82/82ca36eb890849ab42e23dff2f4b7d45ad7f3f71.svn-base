
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-16 16:08:25
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
using System.Data;

namespace JFine.Busines.TN_XM
{	
	/// <summary>
	/// OECTaskPlanDBLL
	/// </summary>	
	public class TN_FK_MXDBLL
	{
        private ITN_FK_MXRepository service = new TN_FK_MXRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey = "TN_FK_MXCache";

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetList()
        {
            return service.GetList();
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetListBySql(string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetList(string queryJson)
        {
            var expression = LinqExtensions.True<TN_FK_MXEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["HTName"].IsEmpty())
            {
                string name = queryParam["HTName"].ToString();
                expression = expression.And(t => t.HTName.Contains(name));
            }
			return service.GetList(expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetPageList(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TN_FK_MXEntity>();
            var queryParam = queryJson.ToJObject();
             //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                expression = expression.And(t => t.HTName.Contains(keyord));
            }
            if (!queryParam["BindId"].IsEmpty())
            {
                string BindId = queryParam["BindId"].ToString();
                expression = expression.And(t => t.BindId.Contains(BindId));
            }
            return service.GetPageList(pagination, expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList3(Pagination pagination, string queryJson)
        {
            StringBuilder sb = new StringBuilder();
            var expression = LinqExtensions.True<TN_FK_MXEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["HTName"].IsEmpty())
            {
                string HTName = queryParam["HTName"].ToString();
                sb.Append(" and HTName like '%" + HTName + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["PaidDate1"].IsEmpty())
            {
                string PaidDate1 = queryParam["PaidDate1"].ToString();
                sb.Append(" and PaidDate >= '" + PaidDate1 + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["PaidDate2"].IsEmpty())
            {
                string PaidDate2 = queryParam["PaidDate2"].ToString();
                sb.Append(" and PaidDate <= '" + PaidDate2 + "'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            if (!queryParam["ProjectName"].IsEmpty())
            {
                string ProjectName = queryParam["ProjectName"].ToString();
                sb.Append(" and ProjectName like '%" + ProjectName + "%'");
                //expression = expression.And(t => t.Name.Contains(keyord));
            }
            return service.GetPageList3(pagination, sb.ToString());
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_FK_MXEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_FK_MXEntity TN_FK_MXEntity)
        {
            try
            {
                service.SaveForm(keyValue, TN_FK_MXEntity);
                CacheFactory.Cache().WriteCache(cacheKey, TN_FK_MXEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public void SaveForm2(string keyValue, TN_FK_MXEntity TN_FK_MXEntity,string items)
        {
            try
            {
                service.SaveForm2(keyValue, TN_FK_MXEntity,items);
                CacheFactory.Cache().WriteCache(cacheKey, TN_FK_MXEntity);
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



