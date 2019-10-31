
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:14:19
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
using JFine.Domain.Models;
using JFine.Domain.Models.SystemManage;
using JFine.Log;
using JFine.Busines.SystemManage;
using JFine.Code.Online;
using System.Data;
using System.Data.Entity;
using System.Data.Common;
using Dapper;
using System.Configuration;

namespace JFine.Domain.Repository.TN_XM
{	
	/// <summary>
	/// TN_XMRepository
	/// </summary>	
	public class TN_XMRepository:RepositoryFactory<TN_XMEntity>, ITN_XMRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetListBySql(string sqlWhere)
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
        public IEnumerable<TN_XMEntity> GetPageListBySql(Pagination pagination, string sqlWhere)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_XM
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(), pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetList(Expression<Func<TN_XMEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_XMEntity> GetPageList(Pagination pagination, Expression<Func<TN_XMEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_XMEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }

        /// <summary>
        /// 获取附件报表
        /// </summary>
        /// <param name="queryJson"></param>
        /// <returns></returns>
        public DataTable GetAdjunctReport(string queryJson)
        {
            try
            {
                var queryParam = queryJson.ToJObject();
                var strSql = new StringBuilder();
                return ExecuteProc("Proc_PivotAccessoryName");
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// 获取 当前使用的数据访问上下文对象
        /// </summary>
        public DbContext dbcontext { get; set; }
        /// <summary>
        /// 事务对象
        /// </summary>
        public DbTransaction dbTransaction { get; set; }

        public DataTable ExecuteProc(string procName)
        {
            try
            {
                var obj= ConfigurationManager.ConnectionStrings["SqlServerDbContext"].ToString();
                dbcontext = new DbContext(obj);
                IDataReader reader = dbcontext.Database.Connection.ExecuteReader(procName, null, dbTransaction, null, CommandType.StoredProcedure);
                DataTable objDataTable = new DataTable("Table");
                int intFieldCount = reader.FieldCount;
                for (int intCounter = 0; intCounter < intFieldCount; ++intCounter)
                {
                    objDataTable.Columns.Add(reader.GetName(intCounter).ToUpper(), reader.GetFieldType(intCounter));
                }
                objDataTable.BeginLoadData();
                object[] objValues = new object[intFieldCount];
                while (reader.Read())
                {
                    reader.GetValues(objValues);
                    objDataTable.LoadDataRow(objValues, true);
                }
                reader.Close();
                objDataTable.EndLoadData();
                return objDataTable;

            }
            catch (Exception ex)
            {
              var s=  ex.Message;
                throw;
            }
            finally
            {
                if (dbTransaction == null)
                {
                    this.Close();
                }
            }

        }
        /// <summary>
        /// 关闭连接 内存回收
        /// </summary>
        public void Close()
        {
            dbcontext.Dispose();
        }
        #endregion

        #region 数据处理

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_XMEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_XMEntity tN_XMEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_XMEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_XMEntity);
                //插入日志
                var currentUser = OnlineUser.Operator.GetCurrent();
                LogEntity logEntity = new LogEntity();
                logEntity.Category = "项目管理";
                logEntity.OperateType = "修改";
                logEntity.CreateUserId = currentUser.Account;
                logEntity.CreateUserName = currentUser.UserName;
                logEntity.Description = "修改项目信息:" + tN_XMEntity.Name + tN_XMEntity.Code;
                logEntity.Module = "项目管理";
                logEntity.WriteLog();

            }
            else
            {
                tN_XMEntity.Create();
                this.BaseRepository().Insert(tN_XMEntity);
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
            logEntity.Category = "项目管理";
            logEntity.OperateType = "删除";
            logEntity.CreateUserId = currentUser.Account;
            logEntity.CreateUserName = currentUser.UserName;
            logEntity.Description = "删除项目信息:" + keyValue;
            logEntity.Module = "项目管理";
            logEntity.WriteLog();
        }

        #endregion
    }
}



