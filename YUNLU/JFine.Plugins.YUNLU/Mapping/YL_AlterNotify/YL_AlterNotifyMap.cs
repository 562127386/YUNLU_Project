/********************************************************************************
**文 件 名:YL_AlterNotifyMap
**命名空间:JFine.Plugins.YUNLU.Busines.YL_AlterNotify
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-17 16:43:07
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/

using JFine.Plugins.YUNLU.Domain.Models.YL_AlterNotify;
using JFine.Data.Common;
using System.Data.Entity.ModelConfiguration;
namespace JFine.Plugins.YUNLU.Mapping.YL_AlterNotify
{	
	/// <summary>
	/// YL_AlterNotifyMap
	/// </summary>	
	public class YL_AlterNotifyMap:JFEntityTypeConfiguration<YL_AlterNotifyEntity>
	{
	   public YL_AlterNotifyMap()
	   {
	      this.ToTable("YL_AlterNotify");
		  this.HasKey(t=>t.Id);
	   }
    }
}

