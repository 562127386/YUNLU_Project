

//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:08:46
//      ©为之团队
//------------------------------------------------------------------------------

using System;
using JFine.Domain.Models;
namespace JFine.Domain.Models.TN_XM
{	
	/// <summary>
	/// TN_XMBaseEntity
	/// </summary>	
	public class TN_XMBaseEntity:BaseEntity<TN_XMBaseEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TN_XMBaseEntity()
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
	  /// 编码
	  /// </summary>	
	  public string Code { get; set; }

	  
	  /// <summary>
	  /// 名称
	  /// </summary>	
	  public string Name { get; set; }
  
	  /// <summary>
	  /// 上级项目编码
	  /// </summary>	
      public string ParentCode { get; set; }
      /// <summary>
      /// 上级项目名称
      /// </summary>	
      public string ParentName { get; set; }
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
	  /// 负责人电话
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

 
  #endregion
    }
}



