/********************************************************************************
**文 件 名:TNRD_StockOutDMap
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:43:07
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
	/// TNRD_StockOutDMap
	/// </summary>	
	public class TNRD_StockOutDMap:JFEntityTypeConfiguration<TNRD_StockOutDEntity>
	{
	   public TNRD_StockOutDMap()
	   {
	      this.ToTable("TNRD_StockOutD");
		  this.HasKey(t=>t.Id);
	   }
    }
}

