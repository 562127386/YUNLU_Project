﻿/********************************************************************************
**文 件 名:TNRD_SupplierRepository
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-13 10:21:14
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
using System.Threading.Tasks;
using JFine.Data;
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using JFine.Data.Repository;
using JFine.Plugins.RDXM.Domain.IRepository.TN_XM;
using JFine.Common.UI;
using JFine.Common.Extend;
using JFine.Common.Json;
using System.Data.Common;
using System.Linq.Expressions;

namespace JFine.Plugins.RDXM.Domain.Repository.TN_XM
{	
	/// <summary>
	/// TNRD_SupplierRepository
	/// </summary>	
	public class TNRD_SupplierRepository:RepositoryFactory<TNRD_SupplierEntity>, ITNRD_SupplierRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_SupplierEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_SupplierEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TNRD_Supplier
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());
        
		}

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="sqlWhere">查询条件</param>
        /// <returns></returns>
        public IEnumerable<TNRD_SupplierEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TNRD_Supplier
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(),parameter, pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_SupplierEntity> GetList(Expression<Func<TNRD_SupplierEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TNRD_SupplierEntity> GetPageList(Pagination pagination, Expression<Func<TNRD_SupplierEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TNRD_SupplierEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tNRD_SupplierEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TNRD_SupplierEntity tNRD_SupplierEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tNRD_SupplierEntity.Modify(keyValue);
                this.BaseRepository().Update(tNRD_SupplierEntity);
            }
            else
            {
                tNRD_SupplierEntity.Create();
                this.BaseRepository().Insert(tNRD_SupplierEntity);
            }
        }

		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void DeleteForm(string keyValue)
        {
            this.BaseRepository().Delete(keyValue);
        }

        #endregion
    }
}


