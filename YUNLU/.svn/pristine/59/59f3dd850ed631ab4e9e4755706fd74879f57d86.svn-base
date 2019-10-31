
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-16 16:14:21
//    ©为之团队
//------------------------------------------------------------------------------
using JFine.Plugins.RDXM.Busines.TN_XM;
using JFine.Common.UI;
using JFine.Common.Json;
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using JFine.Web.Base.MVC.Handler;
using JFine.Busines.TN_XM;
using JFine.Domain.Models.TN_XM;
using JFine.Code.Online;
using System.Text;
using JFine.Data.Repository;

namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{	
	/// <summary>
	/// TN_CPController
	/// </summary>	
    public class TN_CPController : JFControllerBase
	{
		 private TN_CPBLL tN_CPBll = new TN_CPBLL();

        #region View
        //
        // GET: /TN_XM/
         public override ActionResult Index()
         {
             return View("~/Plugins/JFine.RDXM/Views/TN_CP/Index.cshtml");
         }

         /// <summary>
         /// Form表单
         /// </summary>
         /// <returns></returns>
         [HttpGet]
         [HandlerAuthorize]
         public override ActionResult Form()
         {

             return View("~/Plugins/JFine.RDXM/Views/TN_CP/Form.cshtml");
         }


         /// <summary>
         /// Form2表单
         /// </summary>
         /// <returns></returns>
         [HttpGet]
         [HandlerAuthorize]
         public ActionResult Form2()
         {

             return View("~/Plugins/JFine.RDXM/Views/TN_CP/Form2.cshtml");
         }

         public override ActionResult Details()
         {
             return View("~/Plugins/JFine.RDXM/Views/TN_CP/Details.cshtml");
         }


         public ActionResult DetailsFJ()
         {
             return View("~/Plugins/JFine.RDXM/Views/TN_CP/DetailsFJ.cshtml");
         }


        #endregion

        #region 数据获取
      

		/// <summary>
        /// 列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
		[HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            var strSql = new StringBuilder();
            var currentUser = OnlineUser.Operator.GetCurrent();
            if (!currentUser.IsSystem && currentUser.CompanyId != "30a557b1-5a76-4dab-af63-75838ecd2439")
            {
                strSql.Append(@" select a.*,b.ProjectName,c.CompanyId from TN_CP a,TN_HT b,TN_XM c where a.HTNo = b.Code and b.ProjectNo = c.Code  and c.CompanyId = '" + currentUser.CompanyId + "'");
            }
            else
            {
                strSql.Append(@" select a.*,b.ProjectName from TN_CP a,TN_HT b where a.HTNo = b.Code");
            }
            var table = new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
            var data = new
            {
                rows = table,
                //rows = tN_CPBll.GetPageList(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson2(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_CPBll.GetPageList(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson3(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_CPBll.GetPageList3(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 功能列表 
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns>返回树形Json</returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson(string keyword)
        {
            TN_HTBLL tN_HTBll = new TN_HTBLL();
            //var current  = OnlineUser.Operator.GetCurrent();
            var data = tN_HTBll.GetListBySql3("and ProjectNo = '" + keyword+"'").ToList();
            //if (!string.IsNullOrEmpty(keyword))
            //{
            //    data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            //}
            var treeList = new List<TreeSelectModel>();
            foreach (TN_HTEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Code;
                treeModel.text = item.Name;
                treeModel.parentId = "0";
                treeModel.data = item;
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeSelectJson());

        }



        public ActionResult GetCode(string keyValue)
        {
            var data = tN_CPBll.GetCode(keyValue.Trim());
            return Content(data.ToJson());
        }
        /// <summary>
        /// 功能实体 返回对象Json
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = tN_CPBll.GetForm(keyValue);
            return Content(data.ToJson());
        }
        #endregion

        #region 数据处理

        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_CPEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_CPEntity tN_CPEntity)
        {
            tN_CPBll.SaveForm(keyValue, tN_CPEntity);
            return Success("保存成功。");
        }

		/// <summary>
        /// 删除功能
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            tN_CPBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

        #region 数据验证
       
        #endregion
    }
}