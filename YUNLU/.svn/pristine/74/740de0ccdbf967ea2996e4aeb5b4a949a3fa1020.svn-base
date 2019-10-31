
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:08:45
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
    /// TN_XMBaseController
    /// </summary>	
    public class TN_XMBaseController : JFControllerBase
    {
        private TN_XMBaseBLL tN_XMBaseBll = new TN_XMBaseBLL();

        #region View
        //
        // GET: /TN_XM/
        public ActionResult Index3()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/Index3.cshtml");
        }

        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/Index.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Form()
        {

            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/Form2.cshtml");
        }

        /// <summary>
        /// 查看主项目信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Details()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/Details2.cshtml");
        }

        /// <summary>
        /// 主项目添加附件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult DetailsFJ()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/DetailsFJ.cshtml");
        }

        /// <summary>
        /// 项目报表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public  ActionResult Project()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/Project3.cshtml");
        }
        /// <summary>
        /// 项目报表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult Project2()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_XMBase/Project2.cshtml");
        }
        /// <summary>
        /// 项目列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetProjectGridJson(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_XMBaseBll.GetPageListBySql(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        /// <summary>
        /// 项目列表树形 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetProjectGridJson2(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_XMBaseBll.GetPageListBySql2(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 项目列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetProjectGridJsonXM(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_XMBaseBll.GetPageListBySqlXM(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

     
        /// <summary>
        /// 数据字典树形列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson()
        {
            var data = tN_XMBaseBll.GetListBySql("").ToList();
            var treeList = new List<TreeViewModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = string.IsNullOrEmpty(item.ParentCode);
                tree.id = item.Code;
                tree.text = item.Name;
                tree.value = item.Code;
                tree.parentId = item.ParentCode??"0";
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = hasChildren;               
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
        }
         
        /// <summary>
        /// 数据字典树形列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson2()
        {
            var data = tN_XMBaseBll.GetListBySql2("").ToList();
            var treeList = new List<TreeViewModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = data.Count(t => item.Code.Equals(t.ParentCode)) == 0 ? false : true; ;
                tree.id = item.Code;
                tree.text = item.Name;
                tree.value = item.Code;
                tree.parentId = item.ParentCode??"0";
                tree.isexpand = false;
                tree.complete = true;
                tree.hasChildren = hasChildren;               
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
        }

        /// <summary>
        /// 数据字典树形列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson3()
        {
            var data = tN_XMBaseBll.GetListBySql3("").ToList();
            var treeList = new List<TreeViewModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = data.Count(t => item.Code.Equals(t.ParentCode)) == 0 ? false : true; ;
                tree.id = item.Code;
                tree.text = item.Name;
                tree.value = item.Code;
                tree.parentId = item.ParentCode ?? "0";
                tree.isexpand = false;
                tree.complete = true;
                tree.hasChildren = hasChildren;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
        }
         


                /// <summary>
        /// 数据字典树形列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson5()
        {
            var data = tN_XMBaseBll.GetListBySql5("").ToList();
            var treeList = new List<TreeViewModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = (item.Code == null || data.Count(t => item.Code.Equals(t.ParentCode)) == 0 )? false : true; ;
                tree.id = item.Code;
                tree.text = item.Name;
                tree.value = item.Code;
                tree.parentId = item.ParentCode ?? "0";
                tree.isexpand = false;
                tree.complete = true;
                tree.hasChildren = hasChildren;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
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
            var data = tN_XMBaseBll.GetTreeList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Name;
                treeModel.text = item.Name;
                treeModel.parentId = item.ParentCode;
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
                rows = tN_XMBaseBll.GetPageList(pagination, queryJson),
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
        public ActionResult GetTreeGridJson(Pagination pagination,string queryJson)
        {
            var data = tN_XMBaseBll.GetPageListBySql(pagination, queryJson).ToList();
           
            var treeList = new List<TreeGridModel>();
            foreach (TN_XMBaseEntity item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = string.IsNullOrEmpty(item.ParentCode);
                treeModel.parentId = item.ParentCode ?? "0";
                if (!string.IsNullOrEmpty(queryJson))
                { 
                hasChildren = false;
                treeModel.parentId =  "0";
                }
                 
                treeModel.id = item.Code;
                treeModel.isLeaf = hasChildren;
               
                treeModel.expanded = hasChildren;
                treeModel.entityJson = item.ToJson();
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeGridJson());
        }
        
        /// <summary>
        /// 根据项目名称返回编码 Json
        /// </summary>
        /// <param name="keyValue">项目名称</param>
        /// <returns></returns>
      
        public ActionResult GetParentCode(string keyValue)
        {
            var data = tN_XMBaseBll.GetParentCode(keyValue.Trim());
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
            var data = tN_XMBaseBll.GetForm(keyValue);
            return Content(data.ToJson());
        }
        #endregion

        #region 数据处理


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_XMBaseEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_XMBaseEntity tN_XMBaseEntity)
        {
            ViewBag.Id = Request["keyValue"];
            if (string.IsNullOrEmpty(ViewBag.Id))
            {


                //TN_XMBaseEntity htEntityEntity = new TN_XMBaseEntity();
                if (tN_XMBaseEntity.ParentName == "0")
                {
                    tN_XMBaseEntity.Code = SequenceHelper.getRuleCode("1002");
                }
                else
                {
                    tN_XMBaseEntity.Code = SequenceHelper.getRuleCode("1001");
                }
                ViewBag.Code = tN_XMBaseEntity.Code;
                // tN_XMBaseBll.SaveForm("", htEntityEntity);
                ViewBag.Id = tN_XMBaseEntity.Id;

            }
            //if (tN_XMEntity.BaseCode == "&nbsp;" && tN_XMEntity.BaseName == "&nbsp;" || tN_XMEntity.BaseCode == null  && tN_XMEntity.BaseName == null)
            //{
            //    tN_XMEntity.BaseCode =  tN_XMEntity.BaseSubCode;
            //    tN_XMEntity.BaseSubCode = null;
            //    tN_XMEntity.BaseName = tN_XMEntity.BaseSubName;
            //    tN_XMEntity.BaseSubName = null;

            //}



            tN_XMBaseBll.SaveForm(keyValue, tN_XMBaseEntity);
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
            tN_XMBaseBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}