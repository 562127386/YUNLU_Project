/********************************************************************************
**文 件 名:YL_IT_FirstConfirmRepository
**命名空间:JFine.Plugins.YUNLU.Busines.YL_IT_FirstConfirm
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:46:25
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
using JFine.Plugins.YUNLU.Domain.Models.YL_IT_FirstConfirm;
using JFine.Data.Repository;
using JFine.Plugins.YUNLU.Domain.IRepository.YL_IT_FirstConfirm;
using JFine.Common.UI;
using JFine.Common.Extend;
using JFine.Common.Json;
using System.Data.Common;
using System.Linq.Expressions;

namespace JFine.Plugins.YUNLU.Domain.Repository.YL_IT_FirstConfirm
{	
	/// <summary>
	/// YL_IT_FirstConfirmRepository
	/// </summary>	
	public class YL_IT_FirstConfirmRepository:RepositoryFactory<YL_IT_FirstConfirmEntity>, IYL_IT_FirstConfirmRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YL_IT_FirstConfirmEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YL_IT_FirstConfirmEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   YL_IT_FirstConfirm
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
        public IEnumerable<YL_IT_FirstConfirmEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   YL_IT_FirstConfirm
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(),parameter, pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YL_IT_FirstConfirmEntity> GetList(Expression<Func<YL_IT_FirstConfirmEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<YL_IT_FirstConfirmEntity> GetPageList(Pagination pagination, Expression<Func<YL_IT_FirstConfirmEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public YL_IT_FirstConfirmEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="yL_IT_FirstConfirmEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, YL_IT_FirstConfirmEntity yL_IT_FirstConfirmEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                yL_IT_FirstConfirmEntity.Modify(keyValue);
                this.BaseRepository().Update(yL_IT_FirstConfirmEntity);
            }
            else
            {
                yL_IT_FirstConfirmEntity.Create();
                this.BaseRepository().Insert(yL_IT_FirstConfirmEntity);
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


