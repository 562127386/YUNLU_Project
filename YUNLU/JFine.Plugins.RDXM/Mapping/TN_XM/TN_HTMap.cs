
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:18:29
//     ©为之团队
//------------------------------------------------------------------------------
using JFine.Domain.Models.TN_XM;
using JFine.Data.Common;
using System.Data.Entity.ModelConfiguration;
namespace JFine.Mapping.TN_XM
{	
	/// <summary>
	/// TN_HTMap
	/// </summary>	
	public class TN_HTMap:JFEntityTypeConfiguration<TN_HTEntity>
	{
	   public TN_HTMap()
	   {
	      this.ToTable("TN_HT");
		  this.HasKey(t=>t.Id);
	   }
    }
}



