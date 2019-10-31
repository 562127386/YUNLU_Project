/********************************************************************************
**文 件 名:TNRD_TransactionProtocolRepository
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:41:26
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
using Newtonsoft.Json;

namespace JFine.Plugins.RDXM.Domain.Repository.TN_XM
{
    /// <summary>
    /// TNRD_TransactionProtocolRepository
    /// </summary>	
    public class TNRD_TransactionProtocolRepository : RepositoryFactory<TNRD_TransactionProtocolEntity>, ITNRD_TransactionProtocolRepository
    {
        #region 数据获取
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetList()
        {
            return this.BaseRepository().IQueryable().OrderByDescending(t => t.CreateDate).ToList();

        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetListBySql(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TNRD_TransactionProtocol
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
        public IEnumerable<TNRD_TransactionProtocolEntity> GetPageListBySql(Pagination pagination, string sqlWhere, List<DbParameter> parameter)
        {

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT * 
                            FROM   TNRD_TransactionProtocol
                            WHERE  1=1 ");
            strSql.Append(sqlWhere);

            return this.BaseRepository().FindList(strSql.ToString(), parameter, pagination);

        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetList(Expression<Func<TNRD_TransactionProtocolEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable(condition).ToList();

        }


        /// <summary>
        /// 列表--分页
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<TNRD_TransactionProtocolEntity> GetPageList(Pagination pagination, Expression<Func<TNRD_TransactionProtocolEntity, bool>> condition)
        {
            return this.BaseRepository().FindList(condition, pagination);
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public TNRD_TransactionProtocolEntity GetForm(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        /// <summary>
        /// 获取可用设备列表
        /// </summary>
        /// <param name="sqlWhere"></param>
        /// <returns></returns>
        public DataTable GetAvailDeviceList(string sqlWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append(@"select  t1.CPCode as DeviceCode,
        t1.Name as DeviceName,
		t1.ContractName,
		t1.ProjectName,
        t1.Unit,
        t1.Specifications as Spec,
        t1.NoTaxPrice as Price,
        t1.Quantity - isnull(t2.usedQuantity, 0) as AvailQuantity ,
        t1.NoTaxPrice * ( t1.Quantity - isnull(t2.usedQuantity, 0) ) as Amount
from    ( select tp.*,tp2.Name as ContractName
          from      dbo.TN_CG_CP tp left join dbo.TN_HT_CG tp2 on tp.BindId=tp2.Id
        ) t1
        left join ( select  PCode ,
                            sum(Quantity) as usedQuantity
                    from    dbo.TNRD_TransactionProtocol_D td
                    where   exists ( select 1
                                     from   dbo.TNRD_TransactionProtocol
                                     where  td.Id = BindId
                                            and Status = '已提交')
                    group by PCode
                  ) t2 on t1.CPCode = t2.PCode where 1=1 ");
            strSql.Append(sqlWhere);
            return new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
        }
        #endregion

        #region 数据处理

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="tNRD_TransactionProtocolEntity">实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, string subRowData, TNRD_TransactionProtocolEntity tNRD_TransactionProtocolEntity)
        {

            var protocol_d_list = JsonConvert.DeserializeObject<List<TNRD_TransactionProtocol_DEntity>>(subRowData);

            #region 校验转让数量不能大于可用数量
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" and ProjectName='" + tNRD_TransactionProtocolEntity.ProjectName + "' and ContractName='" + tNRD_TransactionProtocolEntity.ContractName + "'");
            DataTable dt_avail = GetAvailDeviceList(strWhere.ToString());
            foreach (var item in protocol_d_list)
            {
                if (dt_avail != null && dt_avail.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_avail.Rows.Count; i++)
                    {
                        if (item.PCode == dt_avail.Rows[i]["DeviceCode"].ToString())
                        {
                            var availQuantity = dt_avail.Rows[i]["AvailQuantity"].ToString();
                            if (item.Quantity > dt_avail.Rows[i]["AvailQuantity"].ToDecimal())
                            {
                                throw new Exception("设备:<<" + item.PCode + ">>转让数量超出可用数量:" + dt_avail.Rows[i]["AvailQuantity"]);
                            }
                        }

                    }
                }

            }
            #endregion

            IRepositoryBase db = new RepositoryFactory().BaseRepository().BeginTrans();
            if (string.IsNullOrEmpty(keyValue))
            {
                tNRD_TransactionProtocolEntity.Create();
                db.Insert(tNRD_TransactionProtocolEntity);
            }
            else
            {
                tNRD_TransactionProtocolEntity.Modify(keyValue);
                db.Update(tNRD_TransactionProtocolEntity);
            }

            //先删除后添加
            db.Delete<TNRD_TransactionProtocol_DEntity>(u => u.BindId == keyValue);
            foreach (var item in protocol_d_list)
            {
                item.Create();
                item.BindId = keyValue;
                db.Insert(item);
            }
            //提交时生成甲方出入库单和乙方入库单
            if (tNRD_TransactionProtocolEntity.Status == "1")
            {
                //甲方入库
                TNRD_StockInEntity stockInEntity = new TNRD_StockInEntity();
                stockInEntity.Create();
                stockInEntity.TransactionNum = tNRD_TransactionProtocolEntity.TransactionNum;
                stockInEntity.Category = "0";//总公司
                stockInEntity.Status = "1";//提交
                stockInEntity.FirmCode = tNRD_TransactionProtocolEntity.TransactionA_Code;
                stockInEntity.FirmName = tNRD_TransactionProtocolEntity.TransactionA_Name;
                stockInEntity.ProjectCode = tNRD_TransactionProtocolEntity.ProjectCode;
                stockInEntity.ProjectName = tNRD_TransactionProtocolEntity.ProjectName;
                db.Insert(stockInEntity);
                foreach (var item in protocol_d_list)
                {
                    TNRD_StockInDEntity stockInDEntity = new TNRD_StockInDEntity();
                    stockInDEntity.Create();
                    stockInDEntity.BindId = stockInEntity.Id;
                    stockInDEntity.OrderNum = stockInEntity.OrderNum;
                    stockInDEntity.PCode = item.PCode;
                    stockInDEntity.PName = item.PName;
                    stockInDEntity.Spec = item.Spec;
                    stockInDEntity.Unit = item.Unit;
                    stockInDEntity.Price = item.Price;
                    stockInDEntity.Quantity = item.Quantity;
                    stockInDEntity.Amount = item.Amount;
                    db.Insert(stockInDEntity);
                }
                //甲方出库
                TNRD_StockOutEntity stockOutEntity = new TNRD_StockOutEntity();
                stockOutEntity.Create();
                stockOutEntity.Category = "0";//总公司
                stockOutEntity.Status = "1";//提交
                stockOutEntity.FirmCode = tNRD_TransactionProtocolEntity.TransactionA_Code;
                stockOutEntity.FirmName = tNRD_TransactionProtocolEntity.TransactionA_Name;
                stockOutEntity.ProjectCode = tNRD_TransactionProtocolEntity.ProjectCode;
                db.Insert(stockOutEntity);
                foreach (var item in protocol_d_list)
                {
                    TNRD_StockOutDEntity stockOutDEntity = new TNRD_StockOutDEntity();
                    stockOutDEntity.Create();
                    stockOutDEntity.BindId = stockInEntity.Id;
                    stockOutDEntity.OrderNum = stockInEntity.OrderNum;
                    stockOutDEntity.StockInNum = stockInEntity.OrderNum;//入库单号
                    stockOutDEntity.PCode = item.PCode;
                    stockOutDEntity.PName = item.PName;
                    stockOutDEntity.Spec = item.Spec;
                    stockOutDEntity.Unit = item.Unit;
                    stockOutDEntity.Price = item.Price;
                    stockOutDEntity.Quantity = item.Quantity;
                    stockOutDEntity.Amount = item.Amount;
                    db.Insert(stockOutDEntity);
                }
                //乙方入库
                TNRD_StockInEntity stockIn_B_Entity = new TNRD_StockInEntity();
                stockIn_B_Entity.Create();
                stockIn_B_Entity.TransactionNum = tNRD_TransactionProtocolEntity.TransactionNum;
                stockIn_B_Entity.Category = "1";//分公司
                stockIn_B_Entity.Status = "1";//提交
                stockIn_B_Entity.FirmCode = tNRD_TransactionProtocolEntity.TransactionA_Code;
                stockIn_B_Entity.FirmName = tNRD_TransactionProtocolEntity.TransactionA_Name;
                stockIn_B_Entity.ProjectCode = tNRD_TransactionProtocolEntity.ProjectCode;
                stockIn_B_Entity.ProjectName = tNRD_TransactionProtocolEntity.ProjectName;
                db.Insert(stockIn_B_Entity);
                foreach (var item in protocol_d_list)
                {
                    TNRD_StockInDEntity stockIn_B_DEntity = new TNRD_StockInDEntity();
                    stockIn_B_DEntity.Create();
                    stockIn_B_DEntity.BindId = stockIn_B_Entity.Id;
                    stockIn_B_DEntity.OrderNum = stockIn_B_Entity.OrderNum;
                    stockIn_B_DEntity.PCode = item.PCode;
                    stockIn_B_DEntity.PName = item.PName;
                    stockIn_B_DEntity.Spec = item.Spec;
                    stockIn_B_DEntity.Unit = item.Unit;
                    stockIn_B_DEntity.Price = item.Price;
                    stockIn_B_DEntity.Quantity = item.Quantity;
                    stockIn_B_DEntity.Amount = item.Amount;
                    db.Insert(stockIn_B_DEntity);
                }

            }
            try
            {
                db.Commit();
            }
            catch (Exception e)
            {
                db.Rollback();
                throw;
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


