/********************************************************************************
**文 件 名:YL_IT_FirstConfirmEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_IT_FirstConfirm
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:46:24
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_IT_FirstConfirm
{	
	/// <summary>
	/// YL_IT_FirstConfirmEntity
	/// </summary>	
	public class YL_IT_FirstConfirmEntity:BaseEntity<YL_IT_FirstConfirmEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_IT_FirstConfirmEntity()
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
	  /// 确认单号
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 型号
	  /// </summary>	
	  public string Model { get; set; }

	  
	  /// <summary>
	  /// 客户
	  /// </summary>	
	  public string Customer { get; set; }

	  
	  /// <summary>
	  /// 确认日期
	  /// </summary>	
	  public DateTime? ConfirmDate { get; set; }

	  
	  /// <summary>
	  /// 项目
	  /// </summary>	
	  public string Project { get; set; }

	  
	  /// <summary>
	  /// 质量
	  /// </summary>	
	  public string Quality { get; set; }

	  
	  /// <summary>
	  /// U相确认标准
	  /// </summary>	
	  public string ConfirmStandard_U { get; set; }

	  
	  /// <summary>
	  /// U相实测
	  /// </summary>	
	  public string ActualMeasure_U { get; set; }

	  
	  /// <summary>
	  /// U相确认时间
	  /// </summary>	
	  public DateTime? ConfirmDate_U { get; set; }

	  
	  /// <summary>
	  /// V相确认标准
	  /// </summary>	
	  public string ConfirmStandard_V { get; set; }

	  
	  /// <summary>
	  /// V相实测
	  /// </summary>	
	  public string ActualMeasure_V { get; set; }

	  
	  /// <summary>
	  /// V相确认时间
	  /// </summary>	
	  public DateTime? ConfirmDate_V { get; set; }

	  
	  /// <summary>
	  /// W相确认标准
	  /// </summary>	
	  public string ConfirmStandard_W { get; set; }

	  
	  /// <summary>
	  /// W相实测
	  /// </summary>	
	  public string ActualMeasure_W { get; set; }

	  
	  /// <summary>
	  /// W相确认时间
	  /// </summary>	
	  public DateTime? ConfirmDate_W { get; set; }

	  
	  /// <summary>
	  /// 创建日期
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

