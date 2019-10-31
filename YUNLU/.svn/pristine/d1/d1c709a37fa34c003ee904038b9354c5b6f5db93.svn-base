
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-16 16:08:25
//    ©为之团队
//------------------------------------------------------------------------------
using JFine.Busines.TN_XM;
using JFine.Common.UI;
using JFine.Common.Json;
using JFine.Domain.Models.TN_XM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using JFine.Web.Base.MVC.Handler;
using JFine.Sequence;
using JFine.Code.Online;


namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{	
	/// <summary>
    /// TN_FJController
	/// </summary>	
    [HandlerPlugin("RDXM")]
    public class TN_FJController : JFControllerBase
	{
        private TN_FJBLL tN_FJBLL = new TN_FJBLL();

        #region View
        //
        // GET: /OECTask/
        public override ActionResult Index()
        {
            return View("");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Form()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_FJ/Form.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public  ActionResult XMForm()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_FJ/XMForm.cshtml");
        }

        /// <summary>
        /// 出入库单据管理Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult BankForm()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_FJ/BankForm.cshtml");
        }

        /// <summary>
        /// 主项目附件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult XMBaseForm()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_FJ/XMBaseForm.cshtml");
        }

        #endregion

        #region 数据获取
        /// <summary>
        /// 功能列表 
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns>返回树形Json</returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson(string keyword)
        {
            var data = tN_FJBLL.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.AccessoryName.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_FJEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Id;
                treeModel.text = item.AccessoryName;
                treeModel.parentId = item.BINDID;
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeSelectJson());
        
		}

		/// <summary>
        /// 列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
		[HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_FJBLL.GetPageList(pagination, queryJson),
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
                rows = tN_FJBLL.GetPageList2(pagination, queryJson),
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
        //[HttpGet]
        //[HandlerAjaxOnly]
        //public ActionResult GetGridJson2(Pagination pagination, string queryJson)
        //{
        //    var data = new
        //    {
        //        rows = tN_FJBLL.GetPageList2(pagination, queryJson),
        //        total = pagination.total,
        //        page = pagination.page,
        //        records = pagination.records
        //    };
        //    return Content(data.ToJson());
        //}

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
                rows = tN_FJBLL.GetPageList3(pagination, queryJson),
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
        public ActionResult GetListBySql(Pagination pagination, string queryJson)
        {
            var data = tN_FJBLL.GetListBySql(queryJson);
            return Content(data.ToJson());
        }


        /// <summary>
        /// 获取目录级功能列表 
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns>返回树形Json</returns>
        [HttpGet]
        public ActionResult GetTreeGridJson(string keyword)
        {
            var data = tN_FJBLL.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.AccessoryName.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_FJEntity item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = data.Count(t => t.BINDID == item.Id) == 0 ? false : true;
                treeModel.id = item.Id;
                treeModel.isLeaf = hasChildren;
                treeModel.parentId = item.BINDID;
                treeModel.expanded = hasChildren;
                treeModel.entityJson = item.ToJson();
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeGridJson());
        }

        /// <summary>
        /// 功能实体 返回对象Json
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = tN_FJBLL.GetForm(keyValue);
            return Content(data.ToJson());
        }

        #endregion

        #region 数据处理

        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="OECTaskPlanDEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_FJEntity tN_FJEntity)
        {

            tN_FJBLL.SaveForm(keyValue, tN_FJEntity);
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
            tN_FJBLL.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

        #region 数据验证
       
        #endregion
    }
}