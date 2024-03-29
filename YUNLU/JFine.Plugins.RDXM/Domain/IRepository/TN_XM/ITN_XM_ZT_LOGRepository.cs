﻿/********************************************************************************
**文 件 名:ITN_XM_ZT_LOGRepository
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-21 17:47:52
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
using JFine.Common.UI;
using System.Linq.Expressions;
using System.Data.Common;


namespace JFine.Plugins.RDXM.Domain.IRepository.TN_XM
{	
	/// <summary>
	/// ITN_XM_ZT_LOGRepository
	/// </summary>	
	public interface ITN_XM_ZT_LOGRepository
	{
		#region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XM_ZT_LOGEntity> GetList();

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XM_ZT_LOGEntity> GetListBySql(string sqlWhere);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="sqlWhere">查询条件</param>
        /// <returns></returns>
        IEnumerable<TN_XM_ZT_LOGEntity> GetPageListBySql(Pagination pagination, string sqlWhere ,List<DbParameter> parameter);

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XM_ZT_LOGEntity> GetList(Expression<Func<TN_XM_ZT_LOGEntity, bool>> condition);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<TN_XM_ZT_LOGEntity> GetPageList(Pagination pagination, Expression<Func<TN_XM_ZT_LOGEntity, bool>> condition);

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        TN_XM_ZT_LOGEntity GetForm(string keyValue);
        #endregion

        #region 数据处理
        

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name=entity">实体</param>
        /// <returns></returns>
        void SaveForm(string keyValue, TN_XM_ZT_LOGEntity tN_XM_ZT_LOGEntity);

		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteForm(string keyValue);

        #endregion
    }
}

