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
using JFine.Busines.TN_XM;
using System.Text;
using JFine.Data.Repository;

namespace JFine.Plugins.RDXM.Areas.TN_XM.Controllers
{	
	/// <summary>
	/// TN_XM_ZT_LOGController
	/// </summary>	
	public class TN_BB_DYController:JFControllerBase
	{
        private TN_CG_CPBLL tN_CG_CPBll = new TN_CG_CPBLL();
        private TN_HTBLL tN_HTBll = new TN_HTBLL();
        private TN_HT_CGBLL tN_HT_CGBLL = new TN_HT_CGBLL();
        private TN_XMBLL tN_XMBll = new TN_XMBLL();

         #region View
         //亚行项目设备卡片
         // GET: /TN_XM/
        public ActionResult CPKPrint(string keyValue)
         {
            var model = tN_CG_CPBll.GetListBySql(keyValue);
            ViewBag.model = model;
            var str  = "and Id ='" + model.BindId + "'";
            var model2 = tN_HT_CGBLL.GetListBySql(str);
            ViewBag.model2 = model2.First();

             return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CPKPrint.cshtml");
         }

        //亚行项目验收款支付证明
        // GET: /TN_XM/
        public ActionResult XMYSPrint(string keyValue)
        {
            var model = tN_CG_CPBll.GetListBySql(keyValue);
            ViewBag.model = model;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/XMYSPrint.cshtml");
        }


        //主项目合计
        // GET: /TN_XM/
        public ActionResult XMHJPrint()
        {
            var strSql = new StringBuilder();
            strSql.Append(@"select * from View_XM_HJ where 1=1");
            var  model = new RepositoryFactory().BaseRepository().FindTable(strSql.ToString());
            ViewBag.model = model;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/XMHJPrint.cshtml");
        }


        //项目报表打印
        // GET: /TN_XM/
        public ActionResult XMBBPrint(string keyValue)
        {
            string queryJson = "{\"keyValue\":\"" + keyValue + "\"}";
            var model = tN_XMBll.GetPageList3(null, queryJson,1);
            ViewBag.model = model;
            string queryJson2 = "{\"ProjectNo\":\"" + model.Rows[0]["RulesCode"] + "-" + model.Rows[0]["Code"] + "\"}";
            var data2 = tN_HTBll.GetPageList2(null, queryJson2, 1);
            ViewBag.data2 = data2;
            var data3 = tN_CG_CPBll.GetPageList2(null, queryJson, 1);
            ViewBag.data3 = data3;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/XMBBPrint.cshtml");
        }

        //项目报表打印
        // GET: /TN_XM/
        public ActionResult XMBBPrint2(string keyValue,string BeginDate,string EndDate)
        {
            string queryJson = "{\"keyValue\":\"" + keyValue + "\"}";
            var model = tN_XMBll.GetPageList3(null, queryJson, 1);
            ViewBag.model = model;
            string queryJson2 = "{\"ProjectNo\":\"" + model.Rows[0]["RulesCode"] + "-" + model.Rows[0]["Code"] + "\",\"BeginDate\":\"" + BeginDate + "\",\"EndDate\":\"" + EndDate + "\"}";
            var data2 = tN_HTBll.GetPageList4(null, queryJson2, 1);
            ViewBag.data2 = data2;
            var data3 = tN_CG_CPBll.GetPageList2(null, queryJson, 1);
            ViewBag.data3 = data3;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/XMBBPrint2.cshtml");
        }


        //亚行项目履约保函退还证明
        // GET: /TN_XM/
        public ActionResult LYBHPrint(string keyValue)
        {
            var model = tN_CG_CPBll.GetListBySql(keyValue);
            ViewBag.model = model;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/LYBHPrint.cshtml");
        }

        //亚行项目设备台账
        // GET: /TN_XM/
        public ActionResult CPTZPrint(string ProjectName, string HTName, string Name)
        {
            string queryJson = "{\"ProjectName\":\"" + ProjectName + "\",\"HTName\":\"" + HTName + "\",\"Name\":\"" + Name + "\"}";
            var data = tN_CG_CPBll.GetPageList2(null, queryJson,1);
            ViewBag.data = data;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CPTZPrint.cshtml");
        }

        //亚行项目设备到货验收单
        // GET: /TN_XM/
        public ActionResult CPJSPrint()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CPJSPrint.cshtml");
        }

        //亚行合同台账
        // GET: /TN_XM/
        public ActionResult CGHTTZPrint(string ProjectName, string HTName, string Name)
        {
            string queryJson = "{\"ProjectName\":\"" + ProjectName + "\",\"HTName\":\"" + HTName + "\",\"Name\":\"" + Name + "\"}";
            var data = tN_HT_CGBLL.GetPageList3(queryJson);
            ViewBag.data = data;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CGHTTZPrint.cshtml");
        }

        //公开招标评委及采购代表未派单
        // GET: /TN_XM/
        public ActionResult CGZBPrint()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CGZBPrint.cshtml");
        }

        //亚行项目及设备信息统计表
        // GET: /TN_XM/
        public ActionResult CPTJPrint()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CPTJPrint.cshtml");
        }

        //亚行项目合同台账
        // GET: /TN_XM/
        public ActionResult XMHTTZPrint(string ProjectName, string SignDate1, string SignDate2, string Name)
        {
            string queryJson = "{\"ProjectName\":\"" + ProjectName + "\",\"SignDate1\":\"" + SignDate1 + "\",\"SignDate2\":\"" + SignDate2 + "\",\"Name\":\"" + Name + "\"}";
            var data = tN_HTBll.GetPageList2(null, queryJson, 1);
            ViewBag.data = data;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/XMHTTZPrint.cshtml");
        }

        //亚行项目年度设备采购计划表
        // GET: /TN_XM/
        public ActionResult CGJHPrint()
        {
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/CGJHPrint.cshtml");
        }


        //项目节点及过程管理
        // GET: /TN_XM/
        public ActionResult XMJDPrint(String keyword)
        {
            string queryJson = "{\"keyword\" :\"" + keyword + "\"}";
            System.Data.DataTable model = tN_XMBll.GetAdjunctReport(queryJson);
            System.Data.DataTable dt1 = model.Copy();
            dt1.Columns.Remove("BaseSubName");
            dt1.Columns.Remove("Name");
            dt1.Columns.Remove("CompanyName");
            ViewBag.dynamicColumn = dt1;
            var s = dt1.Rows[0][0];

            ViewBag.model = model;
            return View("~/Plugins/JFine.RDXM/Views/TN_BB_DY/XMJDPrint.cshtml");
        }

        #endregion
    }
}

