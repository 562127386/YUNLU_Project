﻿/********************************************************************************
**文 件 名:YL_CustomerFeedbackEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_CustomerFeedback
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:44:20
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_CustomerFeedback
{	
	/// <summary>
	/// YL_CustomerFeedbackEntity
	/// </summary>	
	public class YL_CustomerFeedbackEntity:BaseEntity<YL_CustomerFeedbackEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_CustomerFeedbackEntity()
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
	  /// 投诉单编号
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 客户
	  /// </summary>	
	  public string Customer { get; set; }

	  
	  /// <summary>
	  /// 反馈日期
	  /// </summary>	
	  public DateTime? Feedback_Date { get; set; }

	  
	  /// <summary>
	  /// 型号
	  /// </summary>	
	  public string Model { get; set; }

	  
	  /// <summary>
	  /// 台数
	  /// </summary>	
	  public int? SetNumber { get; set; }

	  
	  /// <summary>
	  /// 生产日期
	  /// </summary>	
	  public DateTime? ProduceDate { get; set; }

	  
	  /// <summary>
	  /// 投诉问题
	  /// </summary>	
	  public string Feedback_Issue { get; set; }

	  
	  /// <summary>
	  /// 问题产生分析
	  /// </summary>	
	  public string EmergeAnalysis { get; set; }

	  
	  /// <summary>
	  /// 问题流出分析
	  /// </summary>	
	  public string OutflowAnalysis { get; set; }

	  
	  /// <summary>
	  /// 解决方案
	  /// </summary>	
	  public string Solution { get; set; }

	  
	  /// <summary>
	  /// 验证结果
	  /// </summary>	
	  public string VerifyResult { get; set; }

	  
	  /// <summary>
	  /// 2个月后验证结果
	  /// </summary>	
	  public string VerifyResult_Later { get; set; }

	  
	  /// <summary>
	  /// 验证人
	  /// </summary>	
	  public string VerifyMan { get; set; }

	  
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
	  /// 最后修改时间
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 最后修改人
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion
    }
}
