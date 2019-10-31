
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:22:17
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

namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{
    [HandlerPlugin("RDXM")]
    /// <summary>
    /// TN_JSController
    /// </summary>	
    public class TN_JSController : JFControllerBase
    {
        private TN_JSBLL tN_JSBll = new TN_JSBLL();

        #region View
        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_JS/Index.cshtml");
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
            if (string.IsNullOrEmpty(ViewBag.Id))
            {
                TN_JSEntity htEntityEntity = new TN_JSEntity();
                htEntityEntity.PayNo = SequenceHelper.getRuleCode("1004");
                ViewBag.Code = htEntityEntity.PayNo;
                tN_JSBll.SaveForm("", htEntityEntity);
                ViewBag.Id = htEntityEntity.Id;

            }
            return View("~/Plugins/JFine.RDXM/Views/TN_JS/Form.cshtml");
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Details()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_JS/Details.cshtml");
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public  ActionResult ReceiveDetails()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/ReceiveDetails.cshtml");
        }

        /// <summary>
        ///结算视图
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult JSReport()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_JS/JSReport.cshtml");
        }
        /// <summary>
        /// 结算列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetJSGridJson(Pagination pagination, string queryJson)
        {
           
            var data = new
            {
                rows = tN_JSBll.GetPageListBySql(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        #endregion



        /// <summary>
        /// 数据字典树形列表关联合同
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTreeJson()
        {
            var data = tN_JSBll.GetListBySql("").ToList();
            var treeList = new List<TreeViewModel>();
            foreach (TN_JSEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = string.IsNullOrEmpty(item.HTNo);
                tree.id = item.PayNo ;
                tree.text = item.PayAmount.ToString();
                tree.value = item.PayNo;
                tree.parentId = item.HTNo ?? "0";
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = hasChildren;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());


        }


        #region 数据获取
        public ActionResult GetCode(string keyValue)
        {
            var data = tN_JSBll.GetCode(keyValue.Trim());
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
            var data = tN_HTBll.GetListBySql("").ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_HTEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Name;
                treeModel.text = item.Name;
                treeModel.parentId = "0";
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
                rows = tN_JSBll.GetPageList(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
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
            var data = tN_JSBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.HTNo.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_JSEntity item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = data.Count(t => t.BindId == item.Id) == 0 ? false : true;
                treeModel.id = item.Id;
                treeModel.isLeaf = hasChildren;
                treeModel.parentId = item.BindId;
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
            var data = tN_JSBll.GetForm(keyValue);
            return Content(data.ToJson());
        }
        #endregion

        #region 数据处理


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_JSEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_JSEntity tN_JSEntity)
        {
            tN_JSBll.SaveForm(keyValue, tN_JSEntity);
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
            tN_JSBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}