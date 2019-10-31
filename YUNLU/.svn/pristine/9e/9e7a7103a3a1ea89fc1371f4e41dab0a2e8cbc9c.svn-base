
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-16 16:08:25
//     ©为之团队
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JFine.Data;
using JFine.Domain.Models.TN_XM;
using JFine.Data.Repository;
using JFine.Domain.IRepository.TN_XM;
using JFine.Common.UI;
using JFine.Common.Extend;
using JFine.Common.Json;
using System.Linq.Expressions;

namespace JFine.Domain.Repository.TN_XM
{	
	/// <summary>
    /// TN_FJRepository
	/// </summary>	
    public class TN_FJRepository : RepositoryFactory<TN_FJEntity>, ITN_FJRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.UploadTime).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_FJ
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetList(Expression<Func<TN_FJEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FJEntity> GetPageList(Pagination pagination, Expression<Func<TN_FJEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_FJEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="oECTaskPlanDEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_FJEntity tN_FJEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_FJEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_FJEntity);
            }
            else
            {
                tN_FJEntity.Create();
                this.BaseRepository().Insert(tN_FJEntity);
            }
        }

		/// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void DeleteForm(string keyValue)
        {
            this.BaseRepository().Delete(keyValue);
        }
        #endregion
    }
}



