
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:14:17
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
    [HandlerPlugin("RDXM")]
    /// <summary>
    /// TN_XMController
    /// </summary>	
    public class TN_XMController : JFControllerBase
    {
        private TN_XMBLL tN_XMBll = new TN_XMBLL();

        #region View
        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {

            return View("~/Plugins/JFine.RDXM/Views/TN_XM/Index.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Form()
        {
            //ViewBag.Id = Request["keyValue"];
            //if (string.IsNullOrEmpty(ViewBag.Id))
            //{
            //    TN_XMEntity htEntityEntity = new TN_XMEntity();
            //    htEntityEntity.Code = SequenceHelper.getRuleCode("1002");

            //    ViewBag.Code = htEntityEntity.Code;
            //    tN_XMBll.SaveForm("", htEntityEntity);
            //    ViewBag.Id = htEntityEntity.Id;
            //}
            return View("~/Plugins/JFine.RDXM/Views/TN_XM/Form.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult Details2()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_XM/Details2.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Details()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XM/Details.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult DetailsFJ()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XM/DetailsFJ.cshtml");
        }

        /// <summary>
        ///项目事项
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult ProjectItem()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XM/ProjectItem.cshtml");
        }
        /// <summary>
        /// 项目事项列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetProjectItemGridJson(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_XMBll.GetPageListBySql(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
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
            TN_XMBaseBLL tN_XMBaseBll = new TN_XMBaseBLL();
            var data = tN_XMBaseBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                /*    treeModel.id = item.Name;
                    treeModel.text = item.Name;
                    treeModel.parentId = "0";
                    treeList.Add(treeModel);    */

                bool hasChildren = string.IsNullOrEmpty(item.ParentCode);
                treeModel.text = item.Name;
                treeModel.id = item.Code;
                treeModel.parentId = item.ParentCode ?? "0";
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeSelectJson());

        }
      
        /// <summary>
        /// 获取项目编码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult GetCode(string code)
        {
            TN_XMBaseBLL tN_XMBaseBll = new TN_XMBaseBLL();
            var data = tN_XMBaseBll.GetListBySql("and Code like '%" + code.Trim() + "%'").ToList();
            return Content(data.ToJson());
        }

        /// <summary>
        /// 获取公司ID
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult GetCompanyId(string Name)
        {
            TN_XMBaseBLL tN_XMBaseBll = new TN_XMBaseBLL();
            var data = tN_XMBaseBll.GetListByCompany("and Name = '" + Name.Trim() + "'").ToList();
            return Content(data.ToJson());
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
                rows = tN_XMBll.GetPageList2(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 列表 - 采购合同下关联项目
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson3(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_XMBll.GetPageList3(pagination, queryJson),
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
            var data = tN_XMBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_XMEntity item in data)
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
            var data = tN_XMBll.GetForm(keyValue);
            return Content(data.ToJson());
        }
        #endregion

        #region 数据处理


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_XMEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_XMEntity tN_XMEntity)
        {
            ViewBag.Id = Request["keyValue"];
            //if (string.IsNullOrEmpty(ViewBag.Id))
            //{
            //    //TN_XMEntity htEntityEntity = new TN_XMEntity();
            //    tN_XMEntity.Code = SequenceHelper.getRuleCode("1002");

            //    ViewBag.Code = tN_XMEntity.Code;
            //    //tN_XMBll.SaveForm("", htEntityEntity);
            //    //ViewBag.Id = htEntityEntity.Id;
            //}
            if (tN_XMEntity.BaseSubName != null)
            {
                tN_XMEntity.BaseSubName =
                    tN_XMEntity.BaseSubName.Trim();
            }

            //var currentUser = OnlineUser.Operator.GetCurrent();
            //tN_XMEntity.CompanyId = currentUser.CompanyId;
            //tN_XMEntity.CompanyName = currentUser.CompanyName;
            //if (tN_XMEntity.BaseCode == "&nbsp;" && tN_XMEntity.BaseName == "&nbsp;" || tN_XMEntity.BaseCode == null  && tN_XMEntity.BaseName == null)
            //{
            //    tN_XMEntity.BaseCode =  tN_XMEntity.BaseSubCode;
            //    tN_XMEntity.BaseSubCode = null;
            //    tN_XMEntity.BaseName = tN_XMEntity.BaseSubName;
            //    tN_XMEntity.BaseSubName = null;

            //}
            tN_XMBll.SaveForm(keyValue, tN_XMEntity);
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
            tN_XMBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}