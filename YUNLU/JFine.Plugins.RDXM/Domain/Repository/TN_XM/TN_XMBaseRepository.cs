
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:08:47
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
	/// TN_XMBaseRepository
	/// </summary>	
	public class TN_XMBaseRepository:RepositoryFactory<TN_XMBaseEntity>, ITN_XMBaseRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}
        /// <summary>
        /// 获取上级项目的数据源
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetTreeList()
        { 
            return this.BaseRepository().FindList("select * from  View_ParentProject");
        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_XM_Base
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());
        
		}



        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListByCompany(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   Sys_Organize
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());

        }



        
        /// <summary>
        /// 项目列表树
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql2(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   View_XM
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            //strSql.Append("ORDER BY CreateDate");
            return this.BaseRepository().FindList(strSql.ToString());

        }

        /// <summary>
        /// 合同列表树
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql3(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   View_XM_HT
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());

        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql4(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_HT
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());

        }

        /// <summary>
        /// 设备列表树
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetListBySql5(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   View_CP
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
        public IEnumerable<TN_XMBaseEntity> GetPageListBySql(Pagination pagination, string sqlWhere)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_XM_Base
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            //strSql.Append("ORDER BY CreateDate");
            return this.BaseRepository().FindList(strSql.ToString(), pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetList(Expression<Func<TN_XMBaseEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_XMBaseEntity> GetPageList(Pagination pagination, Expression<Func<TN_XMBaseEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_XMBaseEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_XMBaseEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_XMBaseEntity tN_XMBaseEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_XMBaseEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_XMBaseEntity);
                var strSql = new StringBuilder();
                strSql.Append(@"UPDATE TN_XM SET BaseName = '" + tN_XMBaseEntity.Name + "' where BaseCode = '" + tN_XMBaseEntity.Code + "'");
                new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
                var strSql2 = new StringBuilder();
                strSql2.Append(@"UPDATE TN_XM SET BaseSubName = '" + tN_XMBaseEntity.Name + "' where BaseSubCode = '" + tN_XMBaseEntity.Code + "'");
                new RepositoryFactory().BaseRepository().FindTable(strSql2.ToString());
            }
            else
            {
                tN_XMBaseEntity.Create();
                this.BaseRepository().Insert(tN_XMBaseEntity);
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



