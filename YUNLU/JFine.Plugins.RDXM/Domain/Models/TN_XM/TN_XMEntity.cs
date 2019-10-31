

//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:14:17
//      ©为之团队
//------------------------------------------------------------------------------

using System;
using JFine.Domain.Models;
namespace JFine.Domain.Models.TN_XM
{	
	/// <summary>
	/// TN_XMEntity
	/// </summary>	
	public class TN_XMEntity:BaseEntity<TN_XMEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TN_XMEntity()
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
      /// 规则编码
      /// </summary>	
      public string RulesCode { get; set; }


	  
	  /// <summary>
	  /// 编码
	  /// </summary>	
	  public string Code { get; set; }

	  
	  /// <summary>
	  /// 名称
	  /// </summary>	
	  public string Name { get; set; }


      /// <summary>
      /// 设备包
      /// </summary>
      public string CPpackage { get; set; }

	  
	  /// <summary>
	  /// 主项目编码
	  /// </summary>	
	  public string BaseCode { get; set; }

	  
	  /// <summary>
	  /// 主项目名称
	  /// </summary>	
	  public string BaseName { get; set; }

	  
	  /// <summary>
	  /// 一级项目编码
	  /// </summary>	
	  public string BaseSubCode { get; set; }

	  
	  /// <summary>
	  /// 一级项目名称
	  /// </summary>	
	  public string BaseSubName { get; set; }

	  
	  /// <summary>
	  /// 开始时间
	  /// </summary>	
      public DateTime? BeginDate { get; set; }

	  
	  /// <summary>
	  /// 结束时间
	  /// </summary>	
      public DateTime? EndDate { get; set; }

	  
	  /// <summary>
	  /// 项目描述
	  /// </summary>	
	  public string DEC { get; set; }

	  
	  /// <summary>
	  /// 项目负责人
	  /// </summary>	
	  public string Principal { get; set; }

	  
	  /// <summary>
	  /// 项目负责人电话
	  /// </summary>	
	  public string Phone { get; set; }

	  
	  /// <summary>
	  /// 施工单位
	  /// </summary>	
	  public string ConstructionUnit { get; set; }

	  
	  /// <summary>
	  /// 施工单位负责人
	  /// </summary>	
	  public string CPrincipal { get; set; }

	  
	  /// <summary>
	  /// 施工单位负责人电话
	  /// </summary>	
	  public string CPhone { get; set; }

	  
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

        /// <summary>
        /// 公司编码
        /// </summary>
      public string CompanyId { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
      public string CompanyName { get; set; }

     
       /// <summary>
       /// 项目状态
       /// </summary>
      public string ProjectState { get; set; }

        /// <summary>
        /// 财政配套资金或清洁能源供热补贴申请额度（元）
        /// </summary>
        public decimal? FiscalCapital { get; set; }

        /// <summary>
        /// 已到位资金(元)
        /// </summary>
        public decimal? ArriveCapital { get; set; }

        /// <summary>
        /// 项目审计年份
        /// </summary>
        public string AuditYear { get; set; }

        /// <summary>
        /// 项目地点
        /// </summary>
        public string Place { get; set; }

        #endregion
    }
}



