﻿/********************************************************************************
**文 件 名:YL_DefectiveRepairSignUpEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_DefectiveRepairSignUp
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:45:06
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_DefectiveRepairSignUp
{	
	/// <summary>
	/// YL_DefectiveRepairSignUpEntity
	/// </summary>	
	  class YL_DefectiveRepairSignUpEntity:BaseEntity<YL_DefectiveRepairSignUpEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_DefectiveRepairSignUpEntity()
		{
            this.Id= System.Guid.NewGuid().ToString();

 		}

	#region 实体成员

	  
	  /// <summary>
	  /// 主键
	  /// </summary>	
	  public string Id { get; set; }

	  
	  /// <summary>
	  /// 绑定Id
	  /// </summary>	
	  public string BindId { get; set; }

	  
	  /// <summary>
	  /// 返修单号
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 返修时间
	  /// </summary>	
	  public DateTime? RepairDate { get; set; }

	  
	  /// <summary>
	  /// 产品型号
	  /// </summary>	
	  public string Model { get; set; }

	  
	  /// <summary>
	  /// 不良现象说明
	  /// </summary>	
	  public string DefectiveExplain { get; set; }

	  
	  /// <summary>
	  /// 不良数量
	  /// </summary>	
	  public decimal? DefectiveQuantity { get; set; }

	  
	  /// <summary>
	  /// 责任班组
	  /// </summary>	
	  public string DutySquad { get; set; }

	  
	  /// <summary>
	  /// 返修方案
	  /// </summary>	
	  public string RepairScheme { get; set; }

	  
	  /// <summary>
	  /// 责任人
	  /// </summary>	
	  public string DutyMan { get; set; }

	  
	  /// <summary>
	  /// 返修状态
	  /// </summary>	
	  public string RepairStatus { get; set; }

	  
	  /// <summary>
	  /// LQC签名
	  /// </summary>	
	  public string Signature { get; set; }

	  
	  /// <summary>
	  /// 备注
	  /// </summary>	
	  public string Remark { get; set; }

	  
	  /// <summary>
	  /// 创建时间
	  /// </summary>	
	  public DateTime? CreateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CreateUserId { get; set; }

	  
	  /// <summary>
	  /// 创建人
	  /// </summary>	
	  public string CreateUserName { get; set; }

	  
	  /// <summary>
	  /// 最后更新时间
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 最后更新人
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion
    }
}
