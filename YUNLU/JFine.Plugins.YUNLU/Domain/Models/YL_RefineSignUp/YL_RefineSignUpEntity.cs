/********************************************************************************
**文 件 名:YL_RefineSignUpEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_RefineSignUp
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:44:44
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_RefineSignUp
{	
	/// <summary>
	/// YL_RefineSignUpEntity
	/// </summary>	
	public class YL_RefineSignUpEntity:BaseEntity<YL_RefineSignUpEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_RefineSignUpEntity()
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
	  /// QC改善编号
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 现状
	  /// </summary>	
	  public string CurrentSituation { get; set; }

	  
	  /// <summary>
	  /// 改善方案及目标
	  /// </summary>	
	  public string Goal { get; set; }

	  
	  /// <summary>
	  /// 计划启动时间
	  /// </summary>	
	  public DateTime? Schedule_Start { get; set; }

	  
	  /// <summary>
	  /// 计划完成时间
	  /// </summary>	
	  public DateTime? Schedule_End { get; set; }

	  
	  /// <summary>
	  /// 验证完成情况
	  /// </summary>	
	  public string VerifyFulfill { get; set; }

	  
	  /// <summary>
	  /// 持续情况
	  /// </summary>	
	  public string DurationCondition { get; set; }

	  
	  /// <summary>
	  /// 主导人
	  /// </summary>	
	  public string Dominant { get; set; }

	  
	  /// <summary>
	  /// 参与人
	  /// </summary>	
	  public string Participation { get; set; }

	  
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
	  /// 最后修改人
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 最后修改时间
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion
    }
}

