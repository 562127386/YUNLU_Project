/********************************************************************************
**文 件 名:TN_HT_CGRepository
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 14:56:47
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
using System.Collections;
using JFine.Plugins.RDXM.Busines.TN_XM;
using JFine.Plugins.RDXM.Areas.TN_XM.Controllers;
using JFine.Domain.Models.TN_XM;
using JFine.Code.Online;
using JFine.Busines.TN_XM;
using JFine.Domain.Models.SystemManage;
using JFine.Busines.SystemManage;

namespace JFine.Plugins.RDXM.Domain.Repository.TN_XM
{	
	/// <summary>
	/// TN_HT_CGRepository
	/// </summary>	
	public class TN_HT_CGRepository:RepositoryFactory<TN_HT_CGEntity>, ITN_HT_CGRepository
	{
        private TN_FK_MXDBLL TN_FK_MXDBLL = new TN_FK_MXDBLL();
		 #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();
        
		}

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_HT_CG
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
        public IEnumerable<TN_HT_CGEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TN_HT_CG
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(),parameter, pagination);

        }

		/// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetList(Expression<Func<TN_HT_CGEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


		/// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TN_HT_CGEntity> GetPageList(Pagination pagination, Expression<Func<TN_HT_CGEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TN_HT_CGEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region 数据处理
        
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_HT_CGEntity">实体</param>
        /// <returns></returns>
        public void SaveForm2(string keyValue, TN_HT_CGEntity tN_HT_CGEntity,string items)
        {

            JFine.Data.Repository.IRepositoryBase db = new RepositoryFactory().BaseRepository().BeginTrans();
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_HT_CGEntity.Modify(keyValue);
                db.Update(tN_HT_CGEntity);
                //插入日志
                var currentUser = OnlineUser.Operator.GetCurrent();
                LogEntity logEntity = new LogEntity();
                logEntity.Category = "采购合同管理";
                logEntity.OperateType = "修改";
                logEntity.CreateUserId = currentUser.Account;
                logEntity.CreateUserName = currentUser.UserName;
                logEntity.Description = "修改采购合同信息:" + tN_HT_CGEntity.Name + tN_HT_CGEntity.Code + tN_HT_CGEntity.Amount;
                logEntity.Module = "采购设备合同";
                logEntity.WriteLog();

            }
            else
            {
                tN_HT_CGEntity.Create();
                db.Insert(tN_HT_CGEntity);
                TN_FK_MXEntity tN_FK_MXEntity = new TN_FK_MXEntity();
                tN_FK_MXEntity.BindId = tN_HT_CGEntity.Id;
                tN_FK_MXEntity.HTCode = tN_HT_CGEntity.Code;
                tN_FK_MXEntity.HTName = tN_HT_CGEntity.Name;
                tN_FK_MXEntity.PaymentCompany = "青岛能源集团有限公司";
                tN_FK_MXEntity.PaymentAmount = tN_HT_CGEntity.AdvancePayment;
                tN_FK_MXEntity.PayType = "采购合同预付款";
                tN_FK_MXEntity.CredentialsNumber = "预付款";
                tN_FK_MXEntity.HTType = "亚行贷款";
                TN_FK_MXDBLL.SaveForm("", tN_FK_MXEntity);
            }
            List<TN_CG_CPEntity> list = JsonHelper.ToList<TN_CG_CPEntity>(items);
            List<TN_CG_CPEntity> list_item = items.ToList<TN_CG_CPEntity>();
            foreach (var item in list_item)
            {
                item.BindId = tN_HT_CGEntity.Id;
                item.CGCode = tN_HT_CGEntity.Code;
                item.CGName = tN_HT_CGEntity.Name;
                item.CPpackage = tN_HT_CGEntity.CPpackage;
                if (!string.IsNullOrEmpty(item.Id))
                {
                    item.Modify(item.Id);
                    db.Update(item);
//                    var strSql = new StringBuilder();
//                    strSql.Append(@"SELECT * 
//                            FROM   TN_CG_CP
//                            WHERE  1=1 and id = " + item.Id);

//                    TN_CG_CPEntity cp = new TN_CG_CPRepository().BaseRepository().FindEntityFromSql(strSql.ToString());
                    //if(cp.Rate != item.Rate){
                    //    TN_CP_SLBGEntity tN_CP_SLBGEntity = new TN_CP_SLBGEntity();
                    //    tN_CP_SLBGEntity.ProjectNo = item.ProjectNo;
                    //    tN_CP_SLBGEntity.ProjectName = item.ProjectName;
                    //    tN_CP_SLBGEntity.CPCode = item.CPCode;
                    //    tN_CP_SLBGEntity.CPName = item.Name;
                    //    tN_CP_SLBGEntity.OldRate = cp.Rate;
                    //    tN_CP_SLBGEntity.Rate = item.Rate;
                    //    tN_CP_SLBGEntity.TaxPrice = cp.TaxPrice;
                    //    tN_CP_SLBGEntity.NoTaxPrice = cp.NoTaxPrice;
                    //    tN_CP_SLBGEntity.TaxTotal = cp.TaxTotal;
                    //    tN_CP_SLBGEntity.NoTaxTotal = cp.NoTaxTotal;
                    //    db.Insert(tN_CP_SLBGEntity);
                    //    //TN_CP_SLBGController t = new TN_CP_SLBGController();
                    //    //t.SaveForm("",tN_CP_SLBGEntity);
                    //}

                }
                else
                {
                    item.Create();
                    item.PayQuantity = 0;
                    db.Insert(item);
                }

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


            //if (!string.IsNullOrEmpty(keyValue))
            //{
            //    tN_HT_CGEntity.Modify(keyValue);
            //    this.BaseRepository().Update(tN_HT_CGEntity);
            //}
            //else
            //{

            //    tN_HT_CGEntity.Create();
            //    this.BaseRepository().Insert(tN_HT_CGEntity);
            //    TN_FK_MXEntity tN_FK_MXEntity = new TN_FK_MXEntity();
            //    tN_FK_MXEntity.BindId = tN_HT_CGEntity.Id;
            //    tN_FK_MXEntity.HTCode = tN_HT_CGEntity.Code;
            //    tN_FK_MXEntity.HTName = tN_HT_CGEntity.Name;
            //    tN_FK_MXEntity.PaymentCompany = "青岛能源集团有限公司";
            //    tN_FK_MXEntity.PaymentAmount = tN_HT_CGEntity.AdvancePayment;
            //    tN_FK_MXEntity.PayType = "采购合同预付款";
            //    tN_FK_MXEntity.CredentialsNumber = "预付款";
            //    tN_FK_MXEntity.HTType = "亚行贷款";
            //    TN_FK_MXDBLL.SaveForm("", tN_FK_MXEntity);
            //}
            //List<TN_CG_CPEntity> list = JsonHelper.ToList<TN_CG_CPEntity>(items);
            //List<TN_CG_CPEntity> list_item = items.ToList<TN_CG_CPEntity>();
            //foreach (var item in list_item)
            //{
            //    if (string.IsNullOrEmpty(item.Id))
            //    {
            //        item.Create();
            //    }
            //    item.BindId = tN_HT_CGEntity.Id;
            //    item.CGCode = tN_HT_CGEntity.Code;
            //    item.CGName = tN_HT_CGEntity.Name;
            //    item.CPpackage = tN_HT_CGEntity.CPpackage;
            //    TN_CG_CPEntity tN_CG_CPEntity = new TN_CG_CPEntity();
            //    TN_CG_CPBLL tN_CG_CPBll = new TN_CG_CPBLL();
            //    tN_CG_CPBll.SaveForm(keyValue, item);
            //}
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tN_JSEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, TN_HT_CGEntity tN_HT_CGEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                tN_HT_CGEntity.Modify(keyValue);
                this.BaseRepository().Update(tN_HT_CGEntity);
            }
            else
            {
                tN_HT_CGEntity.Create();
                this.BaseRepository().Insert(tN_HT_CGEntity);
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
            logEntity.Category = "采购合同管理";
            logEntity.OperateType = "删除";
            logEntity.CreateUserId = currentUser.Account;
            logEntity.CreateUserName = currentUser.UserName;
            logEntity.Description = "删除采购合同信息:" + keyValue;
            logEntity.Module = "采购设备合同";
            logEntity.WriteLog();
        }

        #endregion
    }
}


