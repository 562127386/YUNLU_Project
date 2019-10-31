/********************************************************************************
**文 件 名:YL_SpecialPurchaseEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_SpecialPurchase
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:45:29
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_SpecialPurchase
{	
	/// <summary>
	/// YL_SpecialPurchaseEntity
	/// </summary>	
	public class YL_SpecialPurchaseEntity:BaseEntity<YL_SpecialPurchaseEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_SpecialPurchaseEntity()
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
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? PurchaseDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Model { get; set; }

	  
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
	  public string DefectiveExplain { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UsageMethod { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? OnlineDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Deliver { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Supplier { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Customer { get; set; }

	  
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

