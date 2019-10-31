/********************************************************************************
**文 件 名:YL_EvaluationReportEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_EvaluationReport
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:46:00
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_EvaluationReport
{	
	/// <summary>
	/// YL_EvaluationReportEntity
	/// </summary>	
	public class YL_EvaluationReportEntity:BaseEntity<YL_EvaluationReportEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_EvaluationReportEntity()
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
	  /// 鉴定单号
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 鉴定日期
	  /// </summary>	
	  public DateTime? EvalDate { get; set; }

	  
	  /// <summary>
	  /// 客户
	  /// </summary>	
	  public string Customer { get; set; }

	  
	  /// <summary>
	  /// 数量
	  /// </summary>	
	  public decimal? Quantity { get; set; }

	  
	  /// <summary>
	  /// 鉴定内容
	  /// </summary>	
	  public string EvalContent { get; set; }

	  
	  /// <summary>
	  /// 问题点
	  /// </summary>	
	  public string IssueSpot { get; set; }

	  
	  /// <summary>
	  /// 改善内容
	  /// </summary>	
	  public string RefineContent { get; set; }

	  
	  /// <summary>
	  /// 时间节点
	  /// </summary>	
	  public string RefineNode { get; set; }

	  
	  /// <summary>
	  /// 验证情况
	  /// </summary>	
	  public string EvalResult { get; set; }

	  
	  /// <summary>
	  /// EMC
	  /// </summary>	
	  public string EMC { get; set; }

	  
	  /// <summary>
	  /// 是否通过
	  /// </summary>	
	  public string IsPass { get; set; }

	  
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

