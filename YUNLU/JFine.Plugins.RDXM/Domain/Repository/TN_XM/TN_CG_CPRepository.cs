/********************************************************************************
**文 件 名:TN_CG_CPRepository
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 14:50:38
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
using System.Data;

namespace JFine.Plugins.RDXM.Domain.Repository.TN_XM
{	
	/// <summary>
	/// TN_CG_CPRepository
	/// </summary>	
	public class TN_CG_CPRepository:RepositoryFactory<TN_CG_CPEntity>, ITN_CG_CPRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_CG_CP
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());

        }


		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public TN_CG_CPEntity GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_CG_CP
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindEntityFromSql(strSql.ToString());
        
		}

		/// <summary>
        /// 列表-分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="sqlWhere">查询条件</param>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_CG_CP
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(),parameter, pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetList(Expression<Func<TN_CG_CPEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_CG_CPEntity> GetPageList(Pagination pagination, Expression<Func<TN_CG_CPEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_CG_CPEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }

        /// <summary>
        /// 实体主子表，关联税率更改
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public DataTable GetForm2(string keyValue)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   View_CP_SLBG
                            WHERE  1=1 ");
            strSql.Append("and a.id = "+keyValue);
            return new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
        }


        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_CG_CPEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_CG_CPEntity tN_CG_CPEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_CG_CPEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_CG_CPEntity);
            }
            else
            {
                tN_CG_CPEntity.Create();
                tN_CG_CPEntity.PayQuantity = 0;
                this.BaseRepository().Insert(tN_CG_CPEntity);
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


