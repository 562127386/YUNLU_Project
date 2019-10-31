/********************************************************************************
**文 件 名:TN_CP_FKMXMap
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-10-27 11:46:05
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/

using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using JFine.Data.Common;
using System.Data.Entity.ModelConfiguration;
namespace JFine.Plugins.RDXM.Mapping.TN_XM
{	
	/// <summary>
	/// TN_CP_FKMXMap
	/// </summary>	
	public class TN_CP_FKMXMap:JFEntityTypeConfiguration<TN_CP_FKMXEntity>
	{
	   public TN_CP_FKMXMap()
	   {
	      this.ToTable("TN_CP_FKMX");
		  this.HasKey(t=>t.Id);
	   }
    }
}

