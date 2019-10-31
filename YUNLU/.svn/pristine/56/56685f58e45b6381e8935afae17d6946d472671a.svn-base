/********************************************************************************
**文 件 名:TN_XM_ZT_LOGController
**命名空间:JFine.Plugins.RDXM.Busines.TN_XM
**描    述:
**
**
**版 本 号:V1.0.0.0
**创 建 人:此代码由T4模板自动生成
**创建日期:2018-09-21 17:47:51
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
using JFine.Domain.Models.TN_XM;
using JFine.Busines.TN_XM;

namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{	
	/// <summary>
	/// TN_XM_ZT_LOGController
	/// </summary>	
	public class TN_XM_ZT_LOGController:JFControllerBase
	{
		 private TN_XM_ZT_LOGBLL tN_XM_ZT_LOGBll = new TN_XM_ZT_LOGBLL();
         private TN_XMBLL tN_XMBll = new TN_XMBLL();

        #region View
        //
        // GET: /TN_XM/
        public override ActionResult Index()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/Print.cshtml");
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
            return View();
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
            var data = tN_XM_ZT_LOGBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.ProjectName.Contains(keyword), "");
            }
            var treeList = new List<TreeSelectModel>();
            foreach (TN_XM_ZT_LOGEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.Id;
                treeModel.text = item.ProjectName;
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
                rows = tN_XM_ZT_LOGBll.GetPageList(pagination, queryJson),
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
            var data = tN_XM_ZT_LOGBll.GetList().ToList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.TreeWhere(t => t.ProjectName.Contains(keyword), "");
            }
            var treeList = new List<TreeGridModel>();
            foreach (TN_XM_ZT_LOGEntity item in data)
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
            var data = tN_XM_ZT_LOGBll.GetForm(keyValue);
            return Content(data.ToJson());
        }
        #endregion

        #region 数据处理
        

        /// <summary>
        /// 保存功能表单
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="TN_XM_ZT_LOGEntity">功能实体</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveForm(string keyValue, TN_XM_ZT_LOGEntity tN_XM_ZT_LOGEntity)
        {
            TN_XMEntity tN_XMEntity = new TN_XMEntity();
            tN_XMEntity.ProjectState = tN_XM_ZT_LOGEntity.State;
            String key = tN_XM_ZT_LOGEntity.BindId;
            tN_XMBll.SaveForm(key, tN_XMEntity);
            tN_XM_ZT_LOGBll.SaveForm(keyValue, tN_XM_ZT_LOGEntity);
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
            tN_XM_ZT_LOGBll.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #endregion

    }
}

