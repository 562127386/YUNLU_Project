/********************************************************************************
**文 件 名:YL_IT_InspectRollMap
**命名空间:JFine.Plugins.YUNLU.Busines.YL_IT_InspectRoll
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:47:09
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/

using JFine.Plugins.YUNLU.Domain.Models.YL_IT_InspectRoll;
using JFine.Data.Common;
using System.Data.Entity.ModelConfiguration;
namespace JFine.Plugins.YUNLU.Mapping.YL_IT_InspectRoll
{	
	/// <summary>
	/// YL_IT_InspectRollMap
	/// </summary>	
	public class YL_IT_InspectRollMap:JFEntityTypeConfiguration<YL_IT_InspectRollEntity>
	{
	   public YL_IT_InspectRollMap()
	   {
	      this.ToTable("YL_IT_InspectRoll");
		  this.HasKey(t=>t.Id);
	   }
    }
}

