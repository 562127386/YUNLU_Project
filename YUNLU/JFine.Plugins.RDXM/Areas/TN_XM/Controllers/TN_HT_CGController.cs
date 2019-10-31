/********************************************************************************
**文 件 名:TN_HT_CGController
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-20 14:56:45
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
using JFine.Plugins.RDXM.Domain.Models.TN_XM;
using JFine.Web.Base.MVC.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Text;
using JFine.Data.Repository;
using JFine.Domain.Models.TN_XM;
using System.Data.Common;
using JFine.Data.Common;

namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{
    /// <summary>
    /// TN_HT_CGController
    /// </summary>	
    public class TN_HT_CGController : JFControllerBase
    {
        private TN_HT_CGBLL tN_HT_CGBll = new TN_HT_CGBLL();

        #region View
        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT_CG/Index.cshtml");
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
            return View("~/Plugins/JFine.RDXM/Views/TN_HT_CG/Form2.cshtml");
        }

        /// <summary>
        /// 查看信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public override ActionResult Details()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT_CG/Details2.cshtml");
        }
        /// <summary>
        /// 添加采购合同附件
        /// </summary>
        /// <returns></returns>
        public ActionResult DetailsFJ()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT_CG/DetailsFJ.cshtml");
        }

        /// <summary>
        /// 出入库单据管理
        /// </summary>
        /// <returns></returns>
        public ActionResult BankFJ()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_HT_CG/BankFJ.cshtml");
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
            var data = tN_HT_CGBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_HT_CGEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.CPpackage;
                treeModel.text = item.CPpackage;
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
                rows = tN_HT_CGBll.GetPageList(pagination, queryJson),
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
                rows = tN_HT_CGBll.GetPageList2(pagination, queryJson),
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
            var data = tN_HT_CGBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.Name.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_HT_CGEntity item in data)
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
            var data = tN_HT_CGBll.GetForm(keyValue);
            return Content(data.ToJson());
        }

        /// <summary>
        /// 功能实体 返回对象Json 根据名称获取信息
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>

        public ActionResult GetCode(string keyValue)
        {
            //var data = tN_HT_CGBll.GetPageListBySql("",keyValue);
            //return Content(data.ToJson());
            //TN_XMBLL tN_XMBll = new TN_XMBLL();
            var data = tN_HT_CGBll.GetListBySql("and CPpackage like '%" + keyValue.Trim() + "%'").ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSelectJson(string WHCode)
        {
            var data = tN_HT_CGBll.GetList().ToList();
            List<object> list = new List<object>();
            foreach (var item in data)
            {
                list.Add(new { id = item.Code, text = item.Name, contractId = item.Id });
            }
            return Content(list.ToJson());
        }

        #endregion

        #region 数据处理


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_HT_CGEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm2(string keyValue, TN_HT_CGEntity tN_HT_CGEntity, string items)
        {
            ViewBag.Id = Request["keyValue"];
            if (string.IsNullOrEmpty(keyValue))
            {
                tN_HT_CGEntity.paidAmount = tN_HT_CGEntity.AdvancePayment;
                tN_HT_CGEntity.unpaidAmount = tN_HT_CGEntity.Amount - tN_HT_CGEntity.paidAmount;
            }
            else
            {
                var data = tN_HT_CGBll.GetForm(keyValue);
                if (tN_HT_CGEntity.Amount != data.Amount)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select sum(PaymentAmount) as sumPayAmont from TN_FK_MX where BindId =@keyValue");
                    List<DbParameter> dbParameter = new List<DbParameter>();
                    //DbParameter dbp = DbParameters.CreateDbParameter("@keyValue", keyValue);
                    dbParameter.Add(DbParameters.CreateDbParameter("@keyValue", keyValue, DbType.AnsiString));
                    string str = new RepositoryFactory().BaseRepository().getString(sb.ToString(), "sumPayAmont", dbParameter);
                    if (str != null && str != "")
                    {
                        decimal sumPayAmont = Convert.ToDecimal(str);
                        tN_HT_CGEntity.paidAmount = sumPayAmont;
                        tN_HT_CGEntity.unpaidAmount = tN_HT_CGEntity.Amount - sumPayAmont;
                    }
                    else
                    {
                        tN_HT_CGEntity.paidAmount = 0;
                        tN_HT_CGEntity.unpaidAmount = tN_HT_CGEntity.Amount;
                    }
                }
            }
            tN_HT_CGBll.SaveForm2(keyValue, tN_HT_CGEntity, items);

            return Success("保存成功。");
        }


        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_HT_CGEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_HT_CGEntity tN_HT_CGEntity)
        {
            tN_HT_CGBll.SaveForm(keyValue, tN_HT_CGEntity);

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
            tN_HT_CGBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}

