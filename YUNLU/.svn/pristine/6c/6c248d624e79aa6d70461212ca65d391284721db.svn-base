
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-17 10:07:30
//		©为之团队
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JFine.Data;
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using JFine.Common.UI;
using System.Linq.Expressions;


namespace JFine.Plugins.RDXM.Domain.IRepository.TN_XM
{	
	/// <summary>
	/// TN_CPJSRepository
	/// </summary>	
	public interface ITN_CPJSRepository
	{
		#region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_CPJSEntity> GetList();

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_CPJSEntity> GetListBySql(string sqlWhere);

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TN_CPJSEntity> GetList(Expression<Func<TN_CPJSEntity, bool>> condition);

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<TN_CPJSEntity> GetPageList(Pagination pagination, Expression<Func<TN_CPJSEntity, bool>> condition);

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        TN_CPJSEntity GetForm(string keyValue);
        #endregion

        #region 数据处理
        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name=entity">实体</param>
        /// <returns></returns>
        void SaveForm(string keyValue, TN_CPJSEntity tN_CPJSEntity);

		/// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteForm(string keyValue);
        #endregion
    }
}



