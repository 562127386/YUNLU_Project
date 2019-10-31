/********************************************************************************
**文 件 名:TNRD_StockOutEntity
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2019-07-12 15:42:54
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using System;
using JFine.Common.Code;
using JFine.Domain.Models;
namespace JFine.Plugins.RDXM.Domain.Models.TN_XM
{	
	/// <summary>
	/// TNRD_StockOutEntity
	/// </summary>	
	public class TNRD_StockOutEntity:BaseEntity<TNRD_StockOutEntity>, ICreate, IModify
	{

		/// <summary>
        /// 默认构造函数
        /// </summary>
        public TNRD_StockOutEntity()
		{
            this.Id= System.Guid.NewGuid().ToString();

 		}
        public override void Create()
        {
            this.OrderNum = "CK" + DateTime.Now.ToString("yyyymmdd") + CommonHelper.RndNum(4);
            base.Create();
        }

        #region 实体成员


        /// <summary>
        /// 
        /// </summary>	
        public string Id { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string BindId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string OrderNum { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Category { get; set; }

	  
	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Status { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string FirmCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string FirmName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ProjectCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string ProjectName { get; set; }

	  /// <summary>
      /// 转让项目编码
      /// </summary>
      public string TranProjectCode { get; set; }
        /// <summary>
        /// 转让项目名称
        /// </summary>
      public string TranProjectName { get; set; }
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string OperatorCode { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string OperatorName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string RelateOrderNum { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string Remark { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? CreateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CreateUserId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string CreateUserName { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public DateTime? UpdateDate { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserId { get; set; }

	  
	  /// <summary>
	  /// 
	  /// </summary>	
	  public string UpdateUserName { get; set; }

 
  #endregion


    }
}

