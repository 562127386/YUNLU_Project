/********************************************************************************
**文 件 名:TNRD_TransactionProtocol_DEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:42:02
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.RDXM.Domain.Models.TN_XM
{	
	/// <summary>
	/// TNRD_TransactionProtocol_DEntity
	/// </summary>	
	public class TNRD_TransactionProtocol_DEntity:BaseEntity<TNRD_TransactionProtocol_DEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TNRD_TransactionProtocol_DEntity()
		{
            this.Id= System.Guid.NewGuid().ToString();

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
	  public string PCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string PName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Unit { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Spec { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public decimal? Quantity { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public decimal? Price { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public decimal? Amount { get; set; }

	  
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

