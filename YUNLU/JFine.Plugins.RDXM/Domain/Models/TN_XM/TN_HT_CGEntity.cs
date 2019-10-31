/********************************************************************************
**文 件 名:TN_HT_CGEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 15:27:11
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
	/// TN_HT_CGEntity
	/// </summary>	
	public class TN_HT_CGEntity:BaseEntity<TN_HT_CGEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TN_HT_CGEntity()
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
	  /// 合同编码
	  /// </summary>	
	  public string Code { get; set; }

	  
	  /// <summary>
	  /// 合同名称
	  /// </summary>	
	  public string Name { get; set; }

	  
	  /// <summary>
	  /// 合同类型
	  /// </summary>	
	  public string HTType { get; set; }

	  
	  /// <summary>
	  /// 采购组织
	  /// </summary>	
	  public string CGOrganization { get; set; }

	  
	  /// <summary>
	  /// 设备包
	  /// </summary>	
	  public string CPpackage { get; set; }

      /// <summary>
      /// 已付金额
      /// </summary>
      public decimal? paidAmount { get; set; }

      /// <summary>
      /// 未付金额
      /// </summary>
      public decimal? unpaidAmount { get; set; }

      /// <summary>
      /// 合同金额
      /// </summary>	
      public decimal? Amount { get; set; }

      /// <summary>
      /// 支付方式
      /// </summary>	
      public string PayType { get; set; }


      /// <summary>
      /// 资金来源
      /// </summary>	
      public string FundSource { get; set; }

	  /// <summary>
	  /// 计划终止日期
	  /// </summary>	
	  public DateTime? EndTime { get; set; }

	  
	  /// <summary>
	  /// 供应商
	  /// </summary>	
	  public string Supplier { get; set; }

	  
	  /// <summary>
	  /// 币种
	  /// </summary>	
	  public string currency { get; set; }

	  
	  /// <summary>
	  /// 合同签订日期
	  /// </summary>	
	  public DateTime? SigningDate { get; set; }

	  
	  /// <summary>
	  /// 部门
	  /// </summary>	
	  public string Department { get; set; }

	  
	  /// <summary>
	  /// 人员
	  /// </summary>	
	  public string Personnel { get; set; }

	  
	  /// <summary>
	  /// 交货地点
	  /// </summary>	
	  public string Place { get; set; }

	  
	  /// <summary>
	  /// 预付款
	  /// </summary>	
      public decimal? AdvancePayment { get; set; }

	  
	  /// <summary>
	  /// 预付款限额 
	  /// </summary>	
      public string Limit { get; set; }

	  
	  /// <summary>
	  /// 合同状态
	  /// </summary>	
	  public string HTState { get; set; }

	  
	  /// <summary>
	  /// 创建时间
	  /// </summary>	
	  public DateTime? CreateDate { get; set; }

	  
	  /// <summary>
	  /// 创建人ID
	  /// </summary>	
	  public string CreateUserId { get; set; }

	  
	  /// <summary>
	  /// 创建人姓名
	  /// </summary>	
	  public string CreateUserName { get; set; }

	  
	  /// <summary>
	  /// 更新时间
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 更新人ID
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 更新人姓名
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion
    }
}

