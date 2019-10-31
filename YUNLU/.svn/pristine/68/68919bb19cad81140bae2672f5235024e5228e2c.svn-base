
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:18:29
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
using JFine.Code.Online;
using JFine.Domain.Models.SystemManage;
using JFine.Busines.SystemManage;

namespace JFine.Domain.Repository.TN_XM
{	
	/// <summary>
	/// TN_HTRepository
	/// </summary>	
	public class TN_HTRepository:RepositoryFactory<TN_HTEntity>, ITN_HTRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}



        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_HT
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());

        }


        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetListBySql2(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_XM
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
        public IEnumerable<TN_HTEntity> GetPageListBySql(Pagination pagination, string sqlWhere)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"select a.*,b.CompanyId from  TN_HT a,TN_XM b where 1=1 and  a.ProjectNo = b.Code ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(), pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetList(Expression<Func<TN_HTEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_HTEntity> GetPageList(Pagination pagination, Expression<Func<TN_HTEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_HTEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_HTEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_HTEntity tN_HTEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_HTEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_HTEntity);

                //插入日志
                var currentUser = OnlineUser.Operator.GetCurrent();
                LogEntity logEntity = new LogEntity();
                logEntity.Category = "国内配套合同";
                logEntity.OperateType = "修改";
                logEntity.CreateUserId = currentUser.Account;
                logEntity.CreateUserName = currentUser.UserName;
                logEntity.Description = "修改国内配套合同信息:" + tN_HTEntity.Name + tN_HTEntity.Code + tN_HTEntity.Amount;
                logEntity.Module = "国内配套合同";
                logEntity.WriteLog();
            }
            else
            {
                tN_HTEntity.Create();
                this.BaseRepository().Insert(tN_HTEntity);
            }
        }

		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void DeleteForm(string keyValue)
        {
            this.BaseRepository().Delete(keyValue);

            //插入日志
            var currentUser = OnlineUser.Operator.GetCurrent();
            LogEntity logEntity = new LogEntity();
            logEntity.Category = "国内配套合同";
            logEntity.OperateType = "删除";
            logEntity.CreateUserId = currentUser.Account;
            logEntity.CreateUserName = currentUser.UserName;
            logEntity.Description = "删除国内配套合同信息:" + keyValue;
            logEntity.Module = "国内配套合同";
            logEntity.WriteLog();
        }

        #endregion
    }
}



