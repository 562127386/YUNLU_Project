
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
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using System.Data;

namespace JFine.Domain.Repository.TN_XM
{	
	/// <summary>
    /// TN_FK_MXRepository
	/// </summary>	
    public class TN_FK_MXRepository : RepositoryFactory<TN_FK_MXEntity>, ITN_FK_MXRepository
	{
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   oec_task_plan_d
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindList(strSql.ToString());
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetList(Expression<Func<TN_FK_MXEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_FK_MXEntity> GetPageList(Pagination pagination, Expression<Func<TN_FK_MXEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 付款列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public DataTable GetPageList3(Pagination pagination, String sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   View_XM_FKMX
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);
            return this.BaseRepository().FindTable(strSql.ToString(), pagination);
        }


        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_FK_MXEntity GetForm(string keyValue)
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
        public void SaveForm(string keyValue, TN_FK_MXEntity TN_FK_MXEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                TN_FK_MXEntity.Modify(keyValue);
                this.BaseRepository().Update(TN_FK_MXEntity);
            }
            else
            {
                TN_FK_MXEntity.Create();
                this.BaseRepository().Insert(TN_FK_MXEntity);
            }
        }

        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="oECTaskPlanDEntity">实体</param>
        /// <returns></returns>
        public void SaveForm2(string keyValue, TN_FK_MXEntity TN_FK_MXEntity,string items)
        {
            JFine.Data.Repository.IRepositoryBase db = new RepositoryFactory().BaseRepository().BeginTrans();
            if (!string.IsNullOrEmpty(keyValue))
            {
                TN_FK_MXEntity.Modify(keyValue);
                this.BaseRepository().Update(TN_FK_MXEntity);
            }
            else
            {
                TN_FK_MXEntity.Create();
                this.BaseRepository().Insert(TN_FK_MXEntity);
            }
            List<TN_CG_CPEntity> list = JsonHelper.ToList<TN_CG_CPEntity>(items);
            List<TN_CG_CPEntity> list_item = items.ToList<TN_CG_CPEntity>();
            foreach (var item in list_item)
            {
                TN_CP_FKMXEntity tN_CP_FKMXEntity = new TN_CP_FKMXEntity();
                tN_CP_FKMXEntity.BindId = TN_FK_MXEntity.Id;
                tN_CP_FKMXEntity.CPId = item.Id;
                tN_CP_FKMXEntity.CPCode = item.CPCode;
                tN_CP_FKMXEntity.CPName = item.Name;
                tN_CP_FKMXEntity.CPType = item.Classify;
                tN_CP_FKMXEntity.ProjectNo = item.ProjectNo;
                tN_CP_FKMXEntity.ProjectName = item.ProjectName;
                tN_CP_FKMXEntity.HTName = item.CGName;
                tN_CP_FKMXEntity.HTCode = item.CGCode;
                tN_CP_FKMXEntity.NoTaxPrice = item.NoTaxPrice;
                tN_CP_FKMXEntity.Quantity = item.Quantity;
                tN_CP_FKMXEntity.Unit = item.Unit;
                tN_CP_FKMXEntity.PaymentCompanyId = item .CPpackage;
                tN_CP_FKMXEntity.PaymentAmount = Convert.ToDecimal(item.TaxTotal);
                tN_CP_FKMXEntity.PaidDate = TN_FK_MXEntity.PaidDate;
                tN_CP_FKMXEntity.CredentialsNumber = TN_FK_MXEntity.CredentialsNumber;
                tN_CP_FKMXEntity.FKNumber = TN_FK_MXEntity.FKNumber;
                tN_CP_FKMXEntity.Create();
                db.Insert(tN_CP_FKMXEntity);
                TN_CG_CPEntity tN_CG_CPEntity = new TN_CG_CPEntity();
                tN_CG_CPEntity.Id = item.Id;
                tN_CG_CPEntity.PayQuantity = item.Quantity + item.PayQuantity;
                db.Update(tN_CG_CPEntity);

            }

            try
            {
                db.Commit();
            }
            catch (Exception)
            {
                db.Rollback();
                throw;
            }
        }

		/// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void DeleteForm(string keyValue)
        {
            this.BaseRepository().Delete(keyValue);
            //修改设备表，已付设备数量
            var strSql = new StringBuilder();
            strSql.Append(@"update TN_CG_CP set PayQuantity = b.Quantity - a.Quantity
                            from TN_CP_FKMX a left join  TN_CG_CP b on a.CPId = b.Id where a.bindid = '" + keyValue + "'");
            new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
            var strSql2 = new StringBuilder();
            strSql2.Append(@"delete from TN_CP_FKMX where bindid= '" + keyValue + "'");
            new RepositoryFactory().BaseRepository().FindTable(strSql2.ToString());
        }
        #endregion
    }
}



