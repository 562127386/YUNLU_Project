

//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:18:30
//      ©为之团队
//------------------------------------------------------------------------------

using System;
using JFine.Domain.Models;
namespace JFine.Domain.Models.TN_XM
{	
	/// <summary>
	/// TN_HTEntity
	/// </summary>	
	public class TN_HTEntity:BaseEntity<TN_HTEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TN_HTEntity()
		{
            this.Id= System.Guid.NewGuid().ToString();

 		}

	#region 实体成员

	  
	  /// <summary>
	  /// 主键
	  /// </summary>	
	  public string Id { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string BindId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ProjectNo { get; set; }
      public string ProjectName { get; set; }

      /// <summary>
      /// 已付金额
      /// </summary>
      public decimal? paidAmount { get; set; }

      /// <summary>
      /// 未付金额
      /// </summary>
      public decimal? unpaidAmount { get; set; }


      /// <summary>
      /// 支付比例
      /// </summary>
      //public decimal? PayProportion { get; set; }
        
	  
	  /// <summary>
	  /// 合同编码
	  /// </summary>	
	  public string Code { get; set; }

	  
	  /// <summary>
	  /// 合同名称
	  /// </summary>	
	  public string Name { get; set; }

	  
	  /// <summary>
	  /// 甲方编码
	  /// </summary>	
	  public string ACode { get; set; }

	  
	  /// <summary>
	  /// 甲方名称
	  /// </summary>	
	  public string AName { get; set; }

	  
	  /// <summary>
	  /// 乙方编码
	  /// </summary>	
	  public string BCode { get; set; }

	  
	  /// <summary>
	  /// 乙方名称
	  /// </summary>	
	  public string BName { get; set; }

	  
	  /// <summary>
	  /// 签订日期
	  /// </summary>	
	  public DateTime? SignDate { get; set; }

	  
	  /// <summary>
	  /// 签订地点
	  /// </summary>	
	  public string SignPlace { get; set; }

	  
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
	  /// 合同文本
	  /// </summary>	
	  public string DEC { get; set; }

	  
	  /// <summary>
	  /// 备注
	  /// </summary>	
	  public string Remark { get; set; }

	  
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



