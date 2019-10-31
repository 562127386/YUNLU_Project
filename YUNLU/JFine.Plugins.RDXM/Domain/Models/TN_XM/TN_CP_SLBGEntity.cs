/********************************************************************************
**文 件 名:TN_CP_SLBGEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-10-13 12:18:48
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
	/// TN_CP_SLBGEntity
	/// </summary>	
	public class TN_CP_SLBGEntity:BaseEntity<TN_CP_SLBGEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TN_CP_SLBGEntity()
		{
            this.Id= System.Guid.NewGuid().ToString();

 		}

	#region 实体成员

	  
	  /// <summary>
	  /// 主键
	  /// </summary>	
	  public string Id { get; set; }

	  
	  /// <summary>
	  /// BindId
	  /// </summary>	
	  public string BindId { get; set; }

	  
	  /// <summary>
	  /// 项目编码
	  /// </summary>	
	  public string ProjectNo { get; set; }

	  
	  /// <summary>
	  /// 项目名称
	  /// </summary>	
	  public string ProjectName { get; set; }

	  
	  /// <summary>
	  /// 设备编码
	  /// </summary>	
	  public string CPCode { get; set; }

	  
	  /// <summary>
	  /// 设备名称
	  /// </summary>	
	  public string CPName { get; set; }

	  
	  /// <summary>
	  /// 数量
	  /// </summary>	
	  public string Quantity { get; set; }

	  
	  /// <summary>
	  /// 单位
	  /// </summary>	
	  public string Unit { get; set; }

	  
	  /// <summary>
	  /// 变更前税率
	  /// </summary>	
	  public string OldRate { get; set; }

	  
	  /// <summary>
	  /// 变更后税率
	  /// </summary>	
	  public string Rate { get; set; }

	  
	  /// <summary>
	  /// 出厂价格
	  /// </summary>	
	  public string TaxPrice { get; set; }

	  
	  /// <summary>
	  /// 每一品目应交税费
	  /// </summary>	
	  public string NoTaxTotal { get; set; }

	  
	  /// <summary>
	  /// 每一品目含税价格
	  /// </summary>	
      public decimal? TaxTotal { get; set; }

	  
	  /// <summary>
	  /// 每一品目出厂价格
	  /// </summary>	
	  public string NoTaxPrice { get; set; }

	  
	  /// <summary>
	  /// 变更后每一品目应交税费
	  /// </summary>	
	  public string NoTaxTotal1 { get; set; }

	  
	  /// <summary>
	  /// 变更后每一品目含税价格
	  /// </summary>	
      public decimal? TaxTotal1 { get; set; }

	  
	  /// <summary>
	  /// 变更后每一品目出厂价格
	  /// </summary>	
	  public string NoTaxPrice1 { get; set; }

	  
	  /// <summary>
	  /// 创建日期
	  /// </summary>	
	  public DateTime? CreateDate { get; set; }

	  
	  /// <summary>
	  /// 创建用户账户
	  /// </summary>	
	  public string CreateUserId { get; set; }

	  
	  /// <summary>
	  /// 创建用户名称
	  /// </summary>	
	  public string CreateUserName { get; set; }

	  
	  /// <summary>
	  /// 最后修改时间
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 最后修改用户
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 最后修改用户名称
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion
    }
}

