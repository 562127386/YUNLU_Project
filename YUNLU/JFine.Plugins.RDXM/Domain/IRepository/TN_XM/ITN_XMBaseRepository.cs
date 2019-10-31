
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:08:46
//		©为之团队
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JFine.Data;
using JFine.Domain.Models.TN_XM;
using JFine.Common.UI;
using System.Linq.Expressions;


namespace JFine.Domain.IRepository.TN_XM
{	
	/// <summary>
	/// TN_XMBaseRepository
	/// </summary>	
	public interface ITN_XMBaseRepository
	{
		#region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XMBaseEntity> GetList();
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XMBaseEntity> GetTreeList();
		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XMBaseEntity> GetListBySql(string sqlWhere);
        IEnumerable<TN_XMBaseEntity> GetListBySql2(string sqlWhere);
        IEnumerable<TN_XMBaseEntity> GetListBySql3(string sqlWhere);
        IEnumerable<TN_XMBaseEntity> GetListBySql5(string sqlWhere);

        IEnumerable<TN_XMBaseEntity> GetListByCompany(string sqlWhere);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="sqlWhere">查询条件</param>
        /// <returns></returns>
        IEnumerable<TN_XMBaseEntity> GetPageListBySql(Pagination pagination, string sqlWhere);

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_XMBaseEntity> GetList(Expression<Func<TN_XMBaseEntity, bool>> condition);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<TN_XMBaseEntity> GetPageList(Pagination pagination, Expression<Func<TN_XMBaseEntity, bool>> condition);

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        TN_XMBaseEntity GetForm(string keyValue);
        #endregion

        #region 数据处理
        

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name=entity">实体</param>
        /// <returns></returns>
        void SaveForm(string keyValue, TN_XMBaseEntity tN_XMBaseEntity);

		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteForm(string keyValue);

        #endregion
    }
}



