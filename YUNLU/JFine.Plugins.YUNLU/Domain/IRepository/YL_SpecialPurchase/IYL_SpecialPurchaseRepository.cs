﻿/********************************************************************************
**文 件 名:IYL_SpecialPurchaseRepository
**命名空间:JFine.Plugins.YUNLU.Busines.YL_SpecialPurchase
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:45:29
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
using JFine.Plugins.YUNLU.Domain.Models.YL_SpecialPurchase;
using JFine.Common.UI;
using System.Linq.Expressions;
using System.Data.Common;


namespace JFine.Plugins.YUNLU.Domain.IRepository.YL_SpecialPurchase
{	
	/// <summary>
	/// IYL_SpecialPurchaseRepository
	/// </summary>	
	public interface IYL_SpecialPurchaseRepository
	{
		#region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<YL_SpecialPurchaseEntity> GetList();

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<YL_SpecialPurchaseEntity> GetListBySql(string sqlWhere);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="sqlWhere">查询条件</param>
        /// <returns></returns>
        IEnumerable<YL_SpecialPurchaseEntity> GetPageListBySql(Pagination pagination, string sqlWhere ,List<DbParameter> parameter);

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<YL_SpecialPurchaseEntity> GetList(Expression<Func<YL_SpecialPurchaseEntity, bool>> condition);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<YL_SpecialPurchaseEntity> GetPageList(Pagination pagination, Expression<Func<YL_SpecialPurchaseEntity, bool>> condition);

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        YL_SpecialPurchaseEntity GetForm(string keyValue);
        #endregion

        #region 数据处理
        

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name=entity">实体</param>
        /// <returns></returns>
        void SaveForm(string keyValue, YL_SpecialPurchaseEntity yL_SpecialPurchaseEntity);

		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteForm(string keyValue);

        #endregion
    }
}

