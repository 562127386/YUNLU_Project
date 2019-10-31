/********************************************************************************
**文 件 名:YL_AlterNotifyRepository
**命名空间:JFine.Plugins.YUNLU.Busines.YL_AlterNotify
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:43:07
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
using JFine.Plugins.YUNLU.Domain.Models.YL_AlterNotify;
using JFine.Data.Repository;
using JFine.Plugins.YUNLU.Domain.IRepository.YL_AlterNotify;
using JFine.Common.UI;
using JFine.Common.Extend;
using JFine.Common.Json;
using System.Data.Common;
using System.Linq.Expressions;

namespace JFine.Plugins.YUNLU.Domain.Repository.YL_AlterNotify
{	
	/// <summary>
	/// YL_AlterNotifyRepository
	/// </summary>	
	public class YL_AlterNotifyRepository:RepositoryFactory<YL_AlterNotifyEntity>, IYL_AlterNotifyRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YL_AlterNotifyEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YL_AlterNotifyEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   YL_AlterNotify
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
        public IEnumerable<YL_AlterNotifyEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   YL_AlterNotify
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(),parameter, pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YL_AlterNotifyEntity> GetList(Expression<Func<YL_AlterNotifyEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<YL_AlterNotifyEntity> GetPageList(Pagination pagination, Expression<Func<YL_AlterNotifyEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public YL_AlterNotifyEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="yL_AlterNotifyEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, YL_AlterNotifyEntity yL_AlterNotifyEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                yL_AlterNotifyEntity.Modify(keyValue);
                this.BaseRepository().Update(yL_AlterNotifyEntity);
            }
            else
            {
                yL_AlterNotifyEntity.Create();
                this.BaseRepository().Insert(yL_AlterNotifyEntity);
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


