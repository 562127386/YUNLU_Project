
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
using JFine.Web.Base.MVC.Handler;
using System.Data;
using JFine.Sequence;
using System.Text;
using JFine.Data.Repository;
using JFine.Common.Data;


namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{	
	/// <summary>
    /// TN_FK_MXController
	/// </summary>	
    public class TN_FK_MXController : JFControllerBase
	{
        private TN_FK_MXDBLL TN_FK_MXDBLL = new TN_FK_MXDBLL();

        #region View
        //
        // GET: /OECTask/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_FK_MX/Index.cshtml");
        }

        //
        // GET: /OECTask/
        public  ActionResult Index2()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_FK_MX/Index2.cshtml");
        }

        //付款管理
        // GET: /OECTask/
        public ActionResult Index3()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_FK_MX/Index3.cshtml");
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
            return View("~/Plugins/JFine.RDXM/Views/TN_FK_MX/Form.cshtml");
        }

        /// <summary>
        /// Form表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAuthorize]
        public  ActionResult Form2()
        {
            ViewBag.Id = Request["keyValue"];
            return View("~/Plugins/JFine.RDXM/Views/TN_FK_MX/Form2.cshtml");
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
            return View("~/Plugins/JFine.RDXM/Views/TN_FK_MX/Form3.cshtml");
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
            var data = TN_FK_MXDBLL.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.HTName.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_FK_MXEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Id;
                treeModel.text = item.HTName;
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
                rows = TN_FK_MXDBLL.GetPageList(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }


        /// <summary>
        /// 付款管理
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson3(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = TN_FK_MXDBLL.GetPageList3(pagination, queryJson),
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
            var data = TN_FK_MXDBLL.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.HTName.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_FK_MXEntity item in data)
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
            var data = TN_FK_MXDBLL.GetForm(keyValue);
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
        public ActionResult SaveForm(TN_FK_MXEntity TN_FK_MXEntity)
        {
            TN_HTEntity htEntityEntity = new TN_HTEntity();
            var strSql = new StringBuilder();
            var bindId = TN_FK_MXEntity.BindId;
            strSql.Append(@"SELECT Amount,paidAmount,unpaidAmount
                            FROM   TN_HT
                            WHERE  1=1 and Id='" + bindId + "'");
            DataTable dt = new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
            if (DataTableHelper.IsExistRows(dt)) 
            {
                //需付总金额
                decimal  amount = Convert.ToDecimal(dt.Rows[0]["Amount"].ToString());
                //已付金额
                decimal pAmount = Convert.ToDecimal(dt.Rows[0]["paidAmount"].ToString());
                //未付金额
                decimal  unpAmount = Convert.ToDecimal(dt.Rows[0]["unpaidAmount"].ToString());

                var  pAmount2 = pAmount + TN_FK_MXEntity.PaymentAmount;
                var  unpAmount2 =  amount  -  Convert.ToDecimal(pAmount2.ToString());
                var strSql1 = new StringBuilder();
                strSql1.Append(@"UPDATE TN_HT
                            SET   paidAmount = " + pAmount2 + ", unpaidAmount = " + unpAmount2 + " WHERE  1=1 and Id='" + bindId + "'");
                new RepositoryFactory().BaseRepository().FindTable(strSql1.ToString());
            }
          
     

              //this.BaseRepository()FindList(strSql.ToString());
            //ViewBag.Id = Request["keyValue"];
            //if (string.IsNullOrEmpty(ViewBag.Id))
            //{
                //TN_FK_MXEntity fkmxEntityEntity = new TN_FK_MXEntity();
                //TN_FK_MXDBLL.SaveForm("", TN_FK_MXEntity);
                //ViewBag.Id = fkmxEntityEntity.Id;

            //}
            TN_FK_MXDBLL.SaveForm("", TN_FK_MXEntity);
            return Success("保存成功。");
        }

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
        public ActionResult SaveForm2(TN_FK_MXEntity TN_FK_MXEntity,string items)
        {
            TN_HTEntity htEntityEntity = new TN_HTEntity();
            var strSql = new StringBuilder();
            var bindId = TN_FK_MXEntity.BindId;
            strSql.Append(@"SELECT Amount,paidAmount,unpaidAmount
                            FROM   TN_HT_CG
                            WHERE  1=1 and Id='" + bindId + "'");
            DataTable dt = new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
            if (DataTableHelper.IsExistRows(dt))
            {
                //需付总金额
                decimal amount = Convert.ToDecimal(dt.Rows[0]["Amount"].ToString());
                //已付金额
                decimal pAmount = Convert.ToDecimal(dt.Rows[0]["paidAmount"].ToString());
                //未付金额
                decimal unpAmount = Convert.ToDecimal(dt.Rows[0]["unpaidAmount"].ToString());

                var pAmount2 = pAmount + TN_FK_MXEntity.PaymentAmount;
                var unpAmount2 = amount - Convert.ToDecimal(pAmount2.ToString());
                var strSql1 = new StringBuilder();
                strSql1.Append(@"UPDATE TN_HT_CG
                            SET   paidAmount = " + pAmount2 + ", unpaidAmount = " + unpAmount2 + " WHERE  1=1 and Id='" + bindId + "'");
                new RepositoryFactory().BaseRepository().FindTable(strSql1.ToString());
            }



            //this.BaseRepository()FindList(strSql.ToString());
            //ViewBag.Id = Request["keyValue"];
            //if (string.IsNullOrEmpty(ViewBag.Id))
            //{
            //TN_FK_MXEntity fkmxEntityEntity = new TN_FK_MXEntity();
            //TN_FK_MXDBLL.SaveForm("", TN_FK_MXEntity);
            //ViewBag.Id = fkmxEntityEntity.Id;

            //}
            TN_FK_MXDBLL.SaveForm2("", TN_FK_MXEntity,items);
            return Success("保存成功。");
        }


        private object BaseRepository()
        {
            throw new NotImplementedException();
        }

		/// <summary>
        /// 删除功能-国内配套合同
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm1(string keyValue)
        {
            TN_HTEntity htEntityEntity = new TN_HTEntity();
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT *
                            FROM   TN_FK_MX
                            WHERE  1=1 and Id='" + keyValue + "'");
            TN_FK_MXEntity tN_FK_MXEntity = new RepositoryFactory().BaseRepository().FindEntityFromSql<TN_FK_MXEntity>(strSql.ToString());
            var strSql2 = new StringBuilder();
            strSql2.Append(@"SELECT Amount,paidAmount,unpaidAmount
                            FROM   TN_HT
                            WHERE  1=1 and Id='" + tN_FK_MXEntity.BindId + "'");
            DataTable dt = new RepositoryFactory().BaseRepository().FindTable(strSql2.ToString());
            if (DataTableHelper.IsExistRows(dt))
            {
                //需付总金额
                decimal amount = Convert.ToDecimal(dt.Rows[0]["Amount"].ToString());
                //已付金额
                decimal pAmount = Convert.ToDecimal(dt.Rows[0]["paidAmount"].ToString());
                //未付金额
                decimal unpAmount = Convert.ToDecimal(dt.Rows[0]["unpaidAmount"].ToString());

                var pAmount2 = pAmount - tN_FK_MXEntity.PaymentAmount;
                var unpAmount2 = amount - Convert.ToDecimal(pAmount2.ToString());
                var strSql1 = new StringBuilder();
                strSql1.Append(@"UPDATE TN_HT
                            SET   paidAmount = " + pAmount2 + ", unpaidAmount = " + unpAmount2 + " WHERE  1=1 and Id='" + tN_FK_MXEntity.BindId + "'");
                new RepositoryFactory().BaseRepository().FindTable(strSql1.ToString());
            }

            TN_FK_MXDBLL.DeleteForm(keyValue);
            return Success("删除成功。");
        }


        /// <summary>
        /// 删除功能—采购合同
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm2(string keyValue)
        {
            TN_HTEntity htEntityEntity = new TN_HTEntity();
            var strSql = new StringBuilder();
            strSql.Append(@"SELECT *
                            FROM   TN_FK_MX
                            WHERE  1=1 and Id='" + keyValue + "'");
            TN_FK_MXEntity tN_FK_MXEntity = new RepositoryFactory().BaseRepository().FindEntityFromSql<TN_FK_MXEntity>(strSql.ToString());
            var strSql2 = new StringBuilder();
            strSql2.Append(@"SELECT Amount,paidAmount,unpaidAmount
                            FROM   TN_HT_CG
                            WHERE  1=1 and Id='" + tN_FK_MXEntity.BindId + "'");
            DataTable dt = new RepositoryFactory().BaseRepository().FindTable(strSql2.ToString());
            if (DataTableHelper.IsExistRows(dt))
            {
                //需付总金额
                decimal amount = Convert.ToDecimal(dt.Rows[0]["Amount"].ToString());
                //已付金额
                decimal pAmount = Convert.ToDecimal(dt.Rows[0]["paidAmount"].ToString());
                //未付金额
                decimal unpAmount = Convert.ToDecimal(dt.Rows[0]["unpaidAmount"].ToString());

                var pAmount2 = pAmount - tN_FK_MXEntity.PaymentAmount;
                var unpAmount2 = amount - Convert.ToDecimal(pAmount2.ToString());
                var strSql1 = new StringBuilder();
                strSql1.Append(@"UPDATE TN_HT_CG
                            SET   paidAmount = " + pAmount2 + ", unpaidAmount = " + unpAmount2 + " WHERE  1=1 and Id='" + tN_FK_MXEntity.BindId + "'");
                new RepositoryFactory().BaseRepository().FindTable(strSql1.ToString());
            }

            TN_FK_MXDBLL.DeleteForm(keyValue);
            return Success("删除成功。");
        }
        #endregion

        #region 数据验证
       
        #endregion
    }
}