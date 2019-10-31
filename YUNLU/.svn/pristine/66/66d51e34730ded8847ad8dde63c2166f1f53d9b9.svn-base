/********************************************************************************
**文 件 名:TNRD_TransactionProtocolEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:41:24
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Common.Code;
using JFine.Domain.Models;
namespace JFine.Plugins.RDXM.Domain.Models.TN_XM
{	
	/// <summary>
	/// TNRD_TransactionProtocolEntity
	/// </summary>	
	public class TNRD_TransactionProtocolEntity:BaseEntity<TNRD_TransactionProtocolEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TNRD_TransactionProtocolEntity()
		{
            this.Id= System.Guid.NewGuid().ToString();

 		}
        public override void Create()
        {
            this.TransactionNum = "TR" + DateTime.Now.ToString("yyyymmdd") + CommonHelper.RndNum(4);
            base.Create();
        }

        #region 实体成员


        /// <summary>
        /// 
        /// </summary>	
        public string Id { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string BindId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Status { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string TransactionNum { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ContractCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ContractName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ProjectCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ProjectName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string AdjunctName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Url { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string TransactionA_Code { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string TransactionA_Name { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string TransactionB_Code { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string TransactionB_Name { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string SupplierCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Supplier { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? SignDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string SignName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? CreateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CreateUserId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CreateUserName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion
    }
}

