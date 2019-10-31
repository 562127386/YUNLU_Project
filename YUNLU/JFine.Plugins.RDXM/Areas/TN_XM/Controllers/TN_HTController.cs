
//------------------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2018-08-03 17:18:31
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
    /// TN_HTController
    /// </summary>	
    [HandlerPlugin("RDXM")]
    public class TN_HTController : JFControllerBase
    {
        private TN_HTBLL tN_HTBll = new TN_HTBLL();
      
        #region View
        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/Index.cshtml");
        }
        public override ActionResult Details()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/Details.cshtml");
        }

        //支付明细查看
        public ActionResult DetailsFJ()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/DetailsFJ.cshtml");
        }

        //金额汇总
        public ActionResult AmountSum()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/AmountSum.cshtml");
        }


        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Form()
        {
            var current = OnlineUser.Operator.GetCurrent();
            ViewBag.ACode = current.CompanyId;
            ViewBag.AName = current.CompanyName;

            return View("~/Plugins/JFine.RDXM/Views/TN_HT/Form.cshtml");
        }

        /// <summary>
        ///合同
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult ItemHT()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/ItemHT.cshtml");
        }
        /// <summary>
        /// 合同列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHTGridJson(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_HTBll.GetPageListBySql(pagination, queryJson),
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
            TN_XMBLL tN_XMBll = new TN_XMBLL();
            //var current  = OnlineUser.Operator.GetCurrent();
            var data = tN_XMBll.GetListBySql2("").ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_XMEntity item in data)
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
        /// 功能列表 
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns>返回树形Json</returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson2(string keyword)
        {
            TN_HTBLL tN_HTBll = new TN_HTBLL();
            //var current  = OnlineUser.Operator.GetCurrent();
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
        /// ReceiveIndex表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult ReceiveIndex()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/ReceiveIndex.cshtml");
        }

        /// <summary>
        /// ReceiveForm表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public  ActionResult ReceiveForm()
        {
            ViewBag.Id = Request["keyValue"];          
            return View("~/Plugins/JFine.RDXM/Views/TN_HT/ReceiveForm.cshtml");
        }

        #endregion

        #region 数据获取

        /// <summary>
        /// 数据字典树形列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson()
        {
            var data = tN_HTBll.GetListBySql("").ToList();
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
        /// 数据字典树形列表关联付款
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTreeJson2()
        {
            var data = tN_HTBll.GetListBySql("").ToList();
            var treeList = new List<TreeViewModel>();
            foreach (TN_HTEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                //bool hasChildren = data.Count(t => item.Code.Equals(t.ProjectNo)) == 0 ? false : true; ;
                tree.id = item.Code;
                tree.text = item.Name;
                tree.value = item.Code;
                tree.parentId = item.ProjectNo;
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = true;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());


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

            //DataTable rows = tN_HTBll.GetPageList2(pagination, queryJson);
            //DataColumn dc = new DataColumn();
            //dc.DataType = System.Type.GetType("System.Decimal");
            //dc.AllowDBNull = false;
            //dc.Caption = "PayProportion";
            //dc.ColumnName = "PayProportion";
            //dc.DefaultValue = "0";
            //dc.Expression = "paidAmount/Amount";
            //rows.Columns.Add(dc);

            var data = new
            {
                rows = tN_HTBll.GetPageList2(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 金额汇总列表 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson3(Pagination pagination, string queryJson)
        {

            var data = new
            {
                rows = tN_HTBll.GetPageList3(pagination, queryJson),
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
            var data = tN_HTBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_HTEntity item in data)
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
            var data = tN_HTBll.GetForm(keyValue);
            return Content(data.ToJson());
        }
        #endregion

        #region 数据处理


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_HTEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_HTEntity tN_HTEntity)
        {
            ViewBag.Id = Request["keyValue"];
            if (string.IsNullOrEmpty(ViewBag.Id))
            {
                //TN_HTEntity htEntityEntity = new TN_HTEntity();
                //tN_HTEntity.Code = SequenceHelper.getRuleCode("1003");
                //ViewBag.Code = tN_HTEntity.Code;
                //tN_HTBll.SaveForm("", tN_HTEntity);
                //ViewBag.Id = htEntityEntity.Id;
 
                tN_HTEntity.paidAmount = 0;
                tN_HTEntity.unpaidAmount = tN_HTEntity.Amount;

            }

                tN_HTBll.SaveForm(keyValue, tN_HTEntity);
            
            return Success("保存成功。");
        }



        public ActionResult GetCode(string name)
        {
            TN_XMBLL tN_XMBll = new TN_XMBLL();
            var data = tN_XMBll.GetListBySql("and Name like '%" + name.Trim() + "%'").ToList();
            return Content(data.ToJson());
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
            tN_HTBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}