/********************************************************************************
**文 件 名:TN_CG_CPEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 18:28:48
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
	/// TN_CG_CPEntity
	/// </summary>	
	public class TN_CG_CPEntity:BaseEntity<TN_CG_CPEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TN_CG_CPEntity()
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
	  /// 采购合同编号
	  /// </summary>	
	  public string CGCode { get; set; }

	  
	  /// <summary>
	  /// 采购合同
	  /// </summary>	
	  public string CGName { get; set; }

	  
	  /// <summary>
	  /// 设备包
	  /// </summary>	
	  public string CPpackage { get; set; }

	  
	  /// <summary>
	  /// 设备分类
	  /// </summary>	
	  public string Classify { get; set; }

	  
	  /// <summary>
	  /// 设备编码
	  /// </summary>	
	  public string CPCode { get; set; }

	  
	  /// <summary>
	  /// 设备名称
	  /// </summary>	
	  public string Name { get; set; }

	  
	  /// <summary>
	  /// 规格
	  /// </summary>	
	  public string Specifications { get; set; }

	  
	  /// <summary>
	  /// 型号
	  /// </summary>	
	  public string Model { get; set; }

	  
	  /// <summary>
	  /// 单位
	  /// </summary>	
	  public string Unit { get; set; }

	  
	  /// <summary>
	  /// 数量
	  /// </summary>	
      public decimal? Quantity { get; set; }

      /// <summary>
      /// 第二批次已付数量
      /// </summary>	
      public decimal? PayQuantity { get; set; }

	  
	  /// <summary>
	  /// 无税单价
	  /// </summary>	
	  public string NoTaxPrice { get; set; }

	  
	  /// <summary>
	  /// 含税单价
	  /// </summary>	
	  public string TaxPrice { get; set; }

	  
	  /// <summary>
	  /// 无税金额
	  /// </summary>	
	  public string NoTaxTotal { get; set; }

	  
	  /// <summary>
	  /// 税率
	  /// </summary>	
	  public string Rate { get; set; }

	  
	  /// <summary>
	  /// 税额
	  /// </summary>	
	  public string Tax { get; set; }

	  
	  /// <summary>
	  /// 价税合计
	  /// </summary>	
      public decimal? TaxTotal { get; set; }

	  
	  /// <summary>
	  /// 设备状态
	  /// </summary>	
	  public string EquipmentState { get; set; }

	  
	  /// <summary>
	  /// 收货单位
	  /// </summary>	
	  public string ReceivingUnit { get; set; }

	  
	  /// <summary>
	  /// 收货地址
	  /// </summary>	
	  public string ShippingAddress { get; set; }

	  
	  /// <summary>
	  /// 货物描述
	  /// </summary>	
      public string Description { get; set; }

	  
	  /// <summary>
	  /// 财务组织
	  /// </summary>	
	  public string Financial { get; set; }

	  
	  /// <summary>
	  /// 客户
	  /// </summary>	
	  public string Customer { get; set; }

	  
	  /// <summary>
	  /// 扣税类别
	  /// </summary>	
	  public string TaxCategory { get; set; }

	  
	  /// <summary>
	  /// 不可抵扣税率
	  /// </summary>	
	  public string InvalidTaxRate { get; set; }

	  
	  /// <summary>
	  /// 不可抵扣税额
	  /// </summary>	
	  public string InvalidTaxPrice { get; set; }

	  
	  /// <summary>
	  /// 计成本金额
	  /// </summary>	
	  public string TotalCost { get; set; }

	  
	  /// <summary>
	  /// 备注
	  /// </summary>	
	  public string Remark { get; set; }

	  
	  /// <summary>
	  /// 入库时间
	  /// </summary>	
	  public DateTime? StorageTime { get; set; }

	  
	  /// <summary>
	  /// 出库时间
	  /// </summary>	
	  public DateTime? OutboundTime { get; set; }

	  
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

