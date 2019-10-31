/********************************************************************************
**文 件 名:TN_CG_CPController
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 14:50:35
**修 改 人:
**修改日期:
**修改描述:
**
**
**版权所有: ©为之团队
*********************************************************************************/
using JFine.Plugins.RDXM.Busines.TN_XM;
using JFine.Common.UI;
using JFine.Common.Json;
using JFine.Common.Extend;
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using JFine.Web.Base.MVC.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using JFine.Busines.TN_XM;

namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{
    /// <summary>
    /// TN_CG_CPController
    /// </summary>	
    public class TN_CG_CPController : JFControllerBase
    {
        private TN_CG_CPBLL tN_CG_CPBll = new TN_CG_CPBLL();
        private TN_XMBLL tN_XMBll = new TN_XMBLL();

        #region View
        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Index.cshtml");
        }

        //
        // GET: /TN_XM/
        public ActionResult Index2()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Index2.cshtml");
        }

        //
        // GET: /TN_XM/
        public ActionResult Index3()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Index3.cshtml");
        }

        //
        // GET: /TN_XM/
        public ActionResult Index4()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Index4.cshtml");
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
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Form.cshtml");
        }


        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult Form2()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Form2.cshtml");
        }


        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult Form3()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Form3.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public ActionResult Form4()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Form4.cshtml");
        }

        //税率变更
        public ActionResult ChangeRate()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/ChangeRate.cshtml");
        }

        //金额汇总
        public ActionResult AmountSum()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/AmountSum.cshtml");
        }

        /// <summary>
        /// 设备查看
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Details()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/Details.cshtml");
        }

        /// <summary>
        /// 添加设备附件
        /// </summary>
        /// <returns></returns>
        public ActionResult DetailsFJ()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/DetailsFJ.cshtml");
        }

        /// <summary>
        /// 采购合同付款发票
        /// </summary>
        /// <returns></returns>
        public ActionResult DetailsFKFJ()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_CG_CP/DetailsFKFJ.cshtml");
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
            var data = tN_CG_CPBll.GetList().ToList();
            //var queryParam = keyword.ToJObject();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            //if (!queryParam["CGCode"].IsEmpty())
            //{
            //    string keyord = queryParam["CGCode"].ToString();
            //    data = data.TreeWhere(t => t.CGCode.Contains(keyord),"");
            //}
            //if (!queryParam["ProjectNo"].IsEmpty())
            //{
            //    string keyord = queryParam["ProjectNo"].ToString();
            //    data = data.TreeWhere(t => t.ProjectNo.Contains(keyord),"");
            //    //sb.Append(" and ProjectNo = '" + queryParam["ProjectNo"] + "'");
            //}
            var treeList = new List<TreeSelectModel>();
            foreach (TN_CG_CPEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Id;
                treeModel.text = item.Name;
                treeModel.parentId = item.BindId;
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
                rows = tN_CG_CPBll.GetPageListBySql(pagination, queryJson),
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
                rows = tN_CG_CPBll.GetPageList2(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 采购金额汇总
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson3(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_CG_CPBll.GetPageList3(pagination, queryJson),
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
        public ActionResult GetGridJson4(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = tN_CG_CPBll.GetPageList4(pagination, queryJson),
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
        public ActionResult GetGridJson5(Pagination pagination, string queryJson)
        {

            var data = new
            {
                rows = tN_CG_CPBll.GetPageList5(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }


        /// <summary>
        /// 列表——采购合同——下属项目——下属设备 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson6(Pagination pagination, string queryJson)
        {

            var data = new
            {
                rows = tN_CG_CPBll.GetPageList6(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 列表——采购合同——下属项目——下属设备 
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson7(Pagination pagination, string queryJson)
        {

            var data = new
            {
                rows = tN_CG_CPBll.GetPageList7(pagination, queryJson),
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
            var data = tN_CG_CPBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_CG_CPEntity item in data)
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
            var data = tN_CG_CPBll.GetForm(keyValue);
            return Content(data.ToJson());
        }


        /// <summary>
        /// 功能实体 返回对象Json
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetFormJson2(string keyValue)
        {
            var data = tN_CG_CPBll.GetForm2(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSelectJson(string ContractId)
        {
            var data = tN_CG_CPBll.GetList().ToList();
            List<object> list = new List<object>();
            if (!string.IsNullOrEmpty(ContractId))
            {
                data = data.FindAll(u => u.BindId == ContractId);
            }
            foreach (var item in data)
            {
                //根据项目名称获取乙方名称和编码
                var XM_Data = tN_XMBll.GetListBySql(" and Name='" + item.ProjectName + "'").FirstOrDefault();
                var TransactionB_Name = XM_Data.CompanyName;
                var TransactionB_Code = XM_Data.CompanyId;
                list.Add(new { id = item.ProjectNo, text = item.ProjectName, TransactionB_Name= TransactionB_Name,TransactionB_Code=TransactionB_Code });
            }
            return Content(list.Distinct().ToJson());
        }
        #endregion

        #region 数据处理


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_CG_CPEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_CG_CPEntity tN_CG_CPEntity)
        {
            tN_CG_CPBll.SaveForm(keyValue, tN_CG_CPEntity);
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
            tN_CG_CPBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}

