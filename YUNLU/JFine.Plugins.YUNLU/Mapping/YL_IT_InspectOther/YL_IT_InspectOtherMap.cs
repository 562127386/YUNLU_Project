/********************************************************************************
**文 件 名:YL_IT_InspectOtherMap
**命名空间:JFine.Plugins.YUNLU.Busines.YL_IT_InspectOther
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:47:23
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/

using JFine.Plugins.YUNLU.Domain.Models.YL_IT_InspectOther;
using JFine.Data.Common;
using System.Data.Entity.ModelConfiguration;
namespace JFine.Plugins.YUNLU.Mapping.YL_IT_InspectOther
{	
	/// <summary>
	/// YL_IT_InspectOtherMap
	/// </summary>	
	public class YL_IT_InspectOtherMap:JFEntityTypeConfiguration<YL_IT_InspectOtherEntity>
	{
	   public YL_IT_InspectOtherMap()
	   {
	      this.ToTable("YL_IT_InspectOther");
		  this.HasKey(t=>t.Id);
	   }
    }
}

