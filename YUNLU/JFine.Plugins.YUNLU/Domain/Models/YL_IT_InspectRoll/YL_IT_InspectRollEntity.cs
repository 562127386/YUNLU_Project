/********************************************************************************
**文 件 名:YL_IT_InspectRollEntity
**命名空间:JFine.Plugins.YUNLU.Busines.YL_IT_InspectRoll
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:47:08
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Domain.Models;
namespace JFine.Plugins.YUNLU.Domain.Models.YL_IT_InspectRoll
{	
	/// <summary>
	/// YL_IT_InspectRollEntity
	/// </summary>	
	public class YL_IT_InspectRollEntity:BaseEntity<YL_IT_InspectRollEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public YL_IT_InspectRollEntity()
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
	  /// 巡检单号
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 记录时间
	  /// </summary>	
	  public DateTime? RecordDate { get; set; }

	  
	  /// <summary>
	  /// 记录人
	  /// </summary>	
	  public string RecordMan { get; set; }

	  
	  /// <summary>
	  /// 巡检人
	  /// </summary>	
	  public string InspectMan { get; set; }

	  
	  /// <summary>
	  /// 人员资质是否合格
	  /// </summary>	
	  public string IsQualify { get; set; }

	  
	  /// <summary>
	  /// 设备编号
	  /// </summary>	
	  public string DeviceCode { get; set; }

	  
	  /// <summary>
	  /// 设备状态
	  /// </summary>	
	  public string DeviceStatus { get; set; }

	  
	  /// <summary>
	  /// 产品型号
	  /// </summary>	
	  public string Model { get; set; }

	  
	  /// <summary>
	  /// 模具状态
	  /// </summary>	
	  public string MoldStatus { get; set; }

	  
	  /// <summary>
	  /// 文件是否齐全
	  /// </summary>	
	  public string IsIntact { get; set; }

	  
	  /// <summary>
	  /// 线包尺寸标准
	  /// </summary>	
	  public string RollSizeStandard { get; set; }

	  
	  /// <summary>
	  /// 线报尺寸实测
	  /// </summary>	
	  public string RollSizeMeasure { get; set; }

	  
	  /// <summary>
	  /// 圈数确认标准
	  /// </summary>	
	  public string CircleStandard { get; set; }

	  
	  /// <summary>
	  /// 圈数确认实测
	  /// </summary>	
	  public string CircleMeasure { get; set; }

	  
	  /// <summary>
	  /// 出线长度标准
	  /// </summary>	
	  public string ThreadLenStandard { get; set; }

	  
	  /// <summary>
	  /// 出线长度实测
	  /// </summary>	
	  public string ThreadLenMeasure { get; set; }

	  
	  /// <summary>
	  /// 张力标准
	  /// </summary>	
	  public string TensionStandard { get; set; }

	  
	  /// <summary>
	  /// 张力实测
	  /// </summary>	
	  public string TensionMeasure { get; set; }

	  
	  /// <summary>
	  /// 结论
	  /// </summary>	
	  public string Conculsion { get; set; }

	  
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
	  /// 最后修修改人
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

