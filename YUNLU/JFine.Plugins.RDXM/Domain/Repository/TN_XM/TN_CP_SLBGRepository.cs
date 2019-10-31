/********************************************************************************
**文 件 名:TN_CP_SLBGRepository
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-30 13:42:31
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
using JFine.Plugins.RDXM.Areas.TN_XM.Controllers;

namespace JFine.Plugins.RDXM.Domain.Repository.TN_XM
{	
	/// <summary>
	/// TN_CP_SLBGRepository
	/// </summary>	
	public class TN_CP_SLBGRepository:RepositoryFactory<TN_CP_SLBGEntity>, ITN_CP_SLBGRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CP_SLBGEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CP_SLBGEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_CP_SLBG
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
        public IEnumerable<TN_CP_SLBGEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_CP_SLBG
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(),parameter, pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CP_SLBGEntity> GetList(Expression<Func<TN_CP_SLBGEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_CP_SLBGEntity> GetPageList(Pagination pagination, Expression<Func<TN_CP_SLBGEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_CP_SLBGEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_CP_SLBGEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_CP_SLBGEntity tN_CP_SLBGEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_CP_SLBGEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_CP_SLBGEntity);
            }
            else
            {
                TN_CG_CPEntity tN_CG_CPEntity = new TN_CG_CPEntity();
                tN_CG_CPEntity.Rate = tN_CP_SLBGEntity.Rate;
                tN_CG_CPEntity.NoTaxPrice = tN_CP_SLBGEntity.NoTaxPrice1;
                tN_CG_CPEntity.NoTaxTotal = tN_CP_SLBGEntity.NoTaxTotal1;
                tN_CG_CPEntity.TaxTotal = tN_CP_SLBGEntity.TaxTotal1;
                TN_CG_CPController t = new TN_CG_CPController();
                t.SaveForm(tN_CP_SLBGEntity.BindId, tN_CG_CPEntity);
                tN_CP_SLBGEntity.Create();
                this.BaseRepository().Insert(tN_CP_SLBGEntity);
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


