
using JFine.Data.Common;
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-17 10:07:30
//     ©为之团队
//------------------------------------------------------------------------------
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using System.Data.Entity.ModelConfiguration;

namespace JFine.Plugins.RDXM.Mapping.TN_XM
{	
	/// <summary>
	/// TN_CPJSMap
	/// </summary>	
    public class TN_CPJSMap : JFEntityTypeConfiguration<TN_CPJSEntity>
	{
	   public TN_CPJSMap()
	   {
	      this.ToTable("TN_CPJS");
		  this.HasKey(t=>t.Id);
	   }
    }
}



