/********************************************************************************
**文 件 名:TNRD_SupplierEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-13 10:21:13
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
	/// TNRD_SupplierEntity
	/// </summary>	
	public class TNRD_SupplierEntity:BaseEntity<TNRD_SupplierEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TNRD_SupplierEntity()
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
	  public string SupCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string SupName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public int? Status { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CategoryCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CategoryName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Address { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ContactMan { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Phone { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Email { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Remark { get; set; }

	  
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

