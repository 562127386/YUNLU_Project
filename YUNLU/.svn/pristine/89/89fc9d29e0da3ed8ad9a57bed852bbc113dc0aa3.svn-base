
/********************************************************************************
**文 件 名:TNRD_TransactionProtocolBLL
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:41:23
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
    /// TNRD_TransactionProtocolBLL
    /// </summary>	
    public class TNRD_TransactionProtocolBLL
    {
        private ITNRD_TransactionProtocolRepository service = new TNRD_TransactionProtocolRepository();

        /// <summary>
        /// 缓存key
        /// </summary>
        public string cacheKey = "TNRD_TransactionProtocolCache";

        #region 数据获取

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetList()
        {
            return service.GetList();
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetListBySql(string sqlWhere)
        {
            return service.GetListBySql(sqlWhere);
        }

        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetPageListBySql(Pagination pagination, string queryJson)
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
        public IEnumerable<TNRD_TransactionProtocolEntity> GetList(string queryJson)
        {
            var expression = LinqExtensions.True<TNRD_TransactionProtocolEntity>();
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
        public IEnumerable<TNRD_TransactionProtocolEntity> GetPageList(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<TNRD_TransactionProtocolEntity>();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyord = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Id.Contains(keyord));
            }
            return service.GetPageList(pagination, expression);
        }
        /// <summary>
        /// 获取可用设备列表
        /// </summary>
        /// <param name="queryJson"></param>
        /// <returns></returns>
        public DataTable GetAvailDeviceList(string queryJson)
        {
            var sqlWhere = new StringBuilder();
            var queryParam = queryJson.ToJObject();
            //查询条件
            if (!queryParam["ProjectName"].IsEmpty())
            {
                string ProjectName = queryParam["ProjectName"].ToString();
                sqlWhere.Append(" AND (ProjectName like '" + ProjectName + "')");
            }
            if (!queryParam["ContractName"].IsEmpty())
            {
                string ContractName = queryParam["ContractName"].ToString();
                sqlWhere.Append(" AND (ContractName like '" + ContractName + "')");
            }
            return service.GetAvailDeviceList(sqlWhere.ToString());
        }
        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TNRD_TransactionProtocolEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue,string subRowData, TNRD_TransactionProtocolEntity tNRD_TransactionProtocolEntity)
        {
            try
            {
                service.SaveForm(keyValue, subRowData, tNRD_TransactionProtocolEntity);
                CacheFactory.Cache().WriteCache(cacheKey, tNRD_TransactionProtocolEntity);
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
