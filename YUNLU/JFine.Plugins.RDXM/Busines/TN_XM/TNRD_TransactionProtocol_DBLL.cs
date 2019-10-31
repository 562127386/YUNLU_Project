﻿
/********************************************************************************
**文 件 名:TNRD_TransactionProtocol_DBLL
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:42:01
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

namespace JFine.Plugins.RDXM.Busines.TN_XM
{
    /// <summary>
    /// TNRD_TransactionProtocol_DBLL
    /// </summary>	
    public class TNRD_TransactionProtocol_DBLL
    {
        private ITNRD_TransactionProtocol_DRepository service = new TNRD_TransactionProtocol_DRepository();

        /// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey = "TNRD_TransactionProtocol_DCache";

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocol_DEntity> GetList()
        {
            return service.GetList();
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocol_DEntity> GetListBySql(string sqlWhere)
        {
            return service.GetListBySql(sqlWhere);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocol_DEntity> GetPageListBySql(Pagination pagination, string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            List<DbParameter> parameter = new List<DbParameter>();
            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {

                string keyword = queryParam["keyword"].ToString();
                sqlWhere.Append(" AND (Code like @keyword or Name like @keyword)");
                parameter.Add(DbParameters.CreateDbParameter("@keyword", "%" + keyword + "%", DbType.AnsiString));
            }

            return service.GetPageListBySql(pagination, sqlWhere.ToString(), parameter);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocol_DEntity> GetList(string queryJson)
        {
            var expression = LinqExtensions.True<TNRD_TransactionProtocol_DEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["Name"].IsEmpty())
            {
                string name = queryParam["Name"].ToString();
                expression = expression.And(t => t.Id.Contains(name));
            }
            return service.GetList(expression);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocol_DEntity> GetPageList(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TNRD_TransactionProtocol_DEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["BindId"].IsEmpty())
            {
                string BindId = queryParam["BindId"].ToString();
                expression = expression.And(t => t.BindId.Equals(BindId));
            }
            return service.GetPageList(pagination, expression);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TNRD_TransactionProtocol_DEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TNRD_TransactionProtocol_DEntity tNRD_TransactionProtocol_DEntity)
        {
            try
            {
                service.SaveForm(keyValue, tNRD_TransactionProtocol_DEntity);
                CacheFactory.Cache().WriteCache(cacheKey, tNRD_TransactionProtocol_DEntity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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