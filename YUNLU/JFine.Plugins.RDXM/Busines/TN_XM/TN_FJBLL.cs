
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

namespace JFine.Busines.TN_XM
{	
	/// <summary>
    /// TN_FJBLL
	/// </summary>	
    public class TN_FJBLL
	{
        private ITN_FJRepository service = new TN_FJRepository();

		/// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey = "TN_FJCache";

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetList()
        {
            return service.GetList();
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetListBySql(string sqlWhere)
        {
			return service.GetListBySql(sqlWhere);
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetList(string queryJson)
        {
            var expression = LinqExtensions.True<TN_FJEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string name = queryParam["Name"].ToString();
                expression = expression.And(t => t.AccessoryName.Contains(name));
            }
			return service.GetList(expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetPageList(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TN_FJEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["AccessoryName"].IsEmpty())
            {
                string keyord = queryParam["AccessoryName"].ToString();
                expression = expression.And(t => t.AccessoryName.Contains(keyord));
            }
            if (!queryParam["SerialNumber"].IsEmpty())
            {
                string HTNo = queryParam["SerialNumber"].ToString();
                expression = expression.And(t => t.SerialNumber.Contains(HTNo));
            }
            if (!queryParam["Code"].IsEmpty())
            {
                string code = queryParam["Code"].ToString();
                expression = expression.And(t => t.OrderNo.Contains(code));
            }
            if (!queryParam["keyValue"].IsEmpty())
            {
                string keyValue = queryParam["keyValue"].ToString();
                expression = expression.And(t => t.BINDID.Contains(keyValue));
            }
            expression = expression.And(t => t.FileType.Contains("0"));
            return service.GetPageList(pagination, expression);
        }



        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetPageList1(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TN_FJEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["AccessoryName"].IsEmpty())
            {
                string keyord = queryParam["AccessoryName"].ToString();
                expression = expression.And(t => t.AccessoryName.Contains(keyord));
            }
            if (!queryParam["SerialNumber"].IsEmpty())
            {
                string HTNo = queryParam["SerialNumber"].ToString();
                expression = expression.And(t => t.SerialNumber.Contains(HTNo));
            }
            if (!queryParam["Code"].IsEmpty())
            {
                string code = queryParam["Code"].ToString();
                expression = expression.And(t => t.OrderNo.Contains(code));
            }
            if (!queryParam["keyValue"].IsEmpty())
            {
                string keyValue = queryParam["keyValue"].ToString();
                expression = expression.And(t => t.BINDID.Contains(keyValue));
            }
            expression = expression.And(t => t.FileType.Contains("1"));
            return service.GetPageList(pagination, expression);
        }



        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetPageList2(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TN_FJEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["AccessoryName"].IsEmpty())
            {
                string keyord = queryParam["AccessoryName"].ToString();
                expression = expression.And(t => t.AccessoryName.Contains(keyord));
            }
            if (!queryParam["SerialNumber"].IsEmpty())
            {
                string HTNo = queryParam["SerialNumber"].ToString();
                expression = expression.And(t => t.SerialNumber.Contains(HTNo));
            }
            if (!queryParam["Code"].IsEmpty())
            {
                string code = queryParam["Code"].ToString();
                expression = expression.And(t => t.OrderNo.Contains(code));
            }
            if (!queryParam["keyValue"].IsEmpty())
            {
                string keyValue = queryParam["keyValue"].ToString();
                expression = expression.And(t => t.BINDID.Contains(keyValue));
            }
            expression = expression.And(t => t.FileType.Contains("1"));
            return service.GetPageList(pagination, expression);
        }


        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetPageList3(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TN_FJEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["AccessoryName"].IsEmpty())
            {
                string keyord = queryParam["AccessoryName"].ToString();
                expression = expression.And(t => t.AccessoryName.Contains(keyord));
            }
            if (!queryParam["SerialNumber"].IsEmpty())
            {
                string HTNo = queryParam["SerialNumber"].ToString();
                expression = expression.And(t => t.SerialNumber.Contains(HTNo));
            }
            if (!queryParam["Code"].IsEmpty())
            {
                string code = queryParam["Code"].ToString();
                expression = expression.And(t => t.OrderNo.Contains(code));
            }
            if (!queryParam["keyValue"].IsEmpty())
            {
                string keyValue = queryParam["keyValue"].ToString();
                expression = expression.And(t => t.BINDID.Contains(keyValue));
            }
            expression = expression.And(t => t.FileType.Contains("0"));
            return service.GetPageList(pagination, expression);
        }



        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_FJEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_FJEntity tN_FJEntity)
        {
            try
            {
                service.SaveForm(keyValue, tN_FJEntity);
                CacheFactory.Cache().WriteCache(cacheKey, tN_FJEntity);
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



