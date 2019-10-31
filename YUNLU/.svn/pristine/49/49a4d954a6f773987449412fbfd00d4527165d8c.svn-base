using JFine.Common.Code;
using JFine.Common.Data;
using JFine.Common.Json;
using JFine.Common.Offices;
using JFine.Data.EL;
using JFine.Sequence;
using JFine.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using JFine.Web.Base.MVC.Handler;
using JFine.Data.Repository;

namespace JFine.Web.Areas.SysCommon.Controllers
{
    public class CommonController : JFControllerBase2
    {
        #region 视图
        //
        // GET: /SysCommon/Common/
        public override ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 功能图标
        /// </summary>
        /// GET: /SysCommon/Common/
        /// <returns></returns>
        [HttpGet]
        public ActionResult Icon()
        {
            return View();
        }

        /// <summary>
        /// 上传Excel数据
        /// </summary>
        /// GET: /SysCommon/Common/
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpLoadExcelData()
        {
            return View();
        }

        /// <summary>
        /// 上传Excel数据-设备
        /// </summary>
        /// GET: /SysCommon/Common/
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpLoadExcelDataCP()
        {
            return View();
        }

        /// <summary>
        /// 上传Excel数据-国内配套合同
        /// </summary>
        /// GET: /SysCommon/Common/
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpLoadExcelDataHT()
        {
            return View();
        }

        /// <summary>
        /// 通过bootstrap file input 上传文件
        /// </summary>
        /// GET: /SysCommon/Common/
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpLoadBF()
        {
            return View();
        }
        /// <summary>
        /// 通过bootstrap file input 上传多个文件
        /// </summary>
        /// GET: /SysCommon/Common/
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpLoadMultiBF()
        {
            return View();
        }
        #endregion

        #region 获取数据
        public ActionResult GetServerTime()
        {//获取服务器时间
            Hashtable ht_result = new Hashtable();

            ht_result.Add("status", "T");
            ht_result.Add("msg", DateTimeHelper.ShortDateTimeS);

            return Json(ht_result);
        }
        /// <summary>
        /// 文字转声音
        /// </summary>
        public void GetVoice()
        {
            string text = Request["voice"] ?? "";
            Response.ContentType = "application/wav";
            using (MemoryStream ms = new MemoryStream())
            {
                Thread thread = new Thread(() =>
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    try
                    {
                        synth.Rate = 0;
                        synth.Volume = 80;

                        /*输出到文件
                        string savePath = Server.MapPath(ConstantUtil.FILE_VOICE_URL);//Server.MapPath 获得虚拟服务器物理路径
                        string saveFullPath = savePath + "voice.wav";//文件路径
                        synth.SetOutputToWaveFile(saveFullPath);
                        synth.Speak(text);
                        synth.SetOutputToNull();
                         * */
                        synth.SetOutputToWaveStream(ms);
                        synth.Speak(text);
                    }
                    catch (Exception ex)
                    {
                        synth.Dispose();
                        Response.Write(ex.Message);
                    }
                });
                thread.Start();
                thread.Join();
                ms.Position = 0;
                if (ms.Length > 0)
                {
                    ms.WriteTo(Response.OutputStream);
                }
                Response.End();
            }
        }
        #endregion

        #region 上传文件数据

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <returns></returns>
        public JsonResult Upload()
        {
            Hashtable ht_result = new Hashtable();

            try
            {
                HttpPostedFileBase file = Request.Files["Filedata"];
                if (file != null)
                {
                    string oldFileName = file.FileName;//原文件名
                    int size = file.ContentLength;//附件大小

                    string extenstion = oldFileName.Substring(oldFileName.LastIndexOf(".") + 1);//后缀名
                    //if (extenstion != "doc" && extenstion != "docx")
                    //{
                    //    ht_result.Add("status", "F");
                    //    ht_result.Add("msg", "只可以选择Word文件");
                    //    return JsonHelper.HashtableToJson(ht_result);
                    //}
                    string filename = DateTimeHelper.GetToday("yyyyMMddHHmmssfff") + "_" + oldFileName; //文件重命名
                    string savePath = Server.MapPath(ConstantUtil.FILE_TARGET_URL);//Server.MapPath 获得虚拟服务器相对路径
                    string saveFullPath = savePath + filename;//文件路径
                    if (!(Directory.Exists(savePath)))
                    {//判断路径是否存在---不存在创建路径
                        Directory.CreateDirectory(savePath);
                    }
                    if ((System.IO.File.Exists(saveFullPath)))
                    {//判断文件是否已经存在，存在删除
                        System.IO.File.Delete(saveFullPath);
                    }

                    file.SaveAs(saveFullPath);
                    bool uploaded = System.IO.File.Exists(saveFullPath);

                    if (uploaded)
                    {
                        ht_result.Add("status", "T");
                        ht_result.Add("msg", "上传成功！");
                        ht_result.Add("filename_o", oldFileName);
                        ht_result.Add("filename", filename);
                        ht_result.Add("path", ConstantUtil.FILE_TARGET_URL + filename);
                        return Json(ht_result); ;
                    }

                }
                ht_result.Add("status", "F");
                ht_result.Add("msg", "加载文件失败");
                return Json(ht_result); ;
            }
            catch (Exception ex)
            {
                ht_result.Add("status", "F");
                ht_result.Add("msg", "加载文件失败:" + ex.ToString());
                return Json(ht_result);
            }
        }

        /// <summary>
        /// 上传文件 Bootstrap File Input 
        /// </summary>
        /// <returns></returns>
        public JsonResult UploadBFI()
        {
            Hashtable ht_result = new Hashtable();

            try
            {
                string modelName = Request["modelName"];//获取文件所属的模块
                HttpPostedFileBase file = Request.Files["uploadBF"];
                //HttpFileCollectionBase file = Request.Files;

                if (file != null)
                {
                    string oldFileName = file.FileName;//原文件名
                    int size = file.ContentLength;//附件大小

                    string extenstion = oldFileName.Substring(oldFileName.LastIndexOf(".") + 1);//后缀名
                    string filename = DateTimeHelper.GetToday("yyyyMMddHHmmssfff") + "_" + oldFileName; //文件重命名
                    string savePath = Server.MapPath(string.IsNullOrEmpty(modelName) ? @"\Content\Files\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\" : @"\Content\Files\" + modelName + @"\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\");//Server.MapPath 获得虚拟服务器相对路径
                    string saveFullPath = savePath + filename;//文件路径
                    if (!(Directory.Exists(savePath)))
                    {//判断路径是否存在---不存在创建路径
                        Directory.CreateDirectory(savePath);
                    }
                    if ((System.IO.File.Exists(saveFullPath)))
                    {//判断文件是否已经存在，存在删除
                        System.IO.File.Delete(saveFullPath);
                    }

                    file.SaveAs(saveFullPath);
                    bool uploaded = System.IO.File.Exists(saveFullPath);

                    if (uploaded)
                    {
                        ht_result.Add("status", "T");
                        ht_result.Add("msg", "上传成功！");
                        ht_result.Add("filename_o", oldFileName);
                        ht_result.Add("filename", filename);
                        ht_result.Add("path", (string.IsNullOrEmpty(modelName) ? @"\Content\Files\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\" : @"\Content\Files\" + modelName + @"\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\") + filename);
                        return Json(ht_result);
                    }

                }
                ht_result.Add("status", "F");
                ht_result.Add("msg", "加载文件失败");
                return Json(ht_result); ;
            }
            catch (Exception ex)
            {
                ht_result.Add("status", "F");
                ht_result.Add("msg", "加载文件失败:" + ex.ToString());
                return Json(ht_result);
            }
        }
        /// <summary>
        /// 多文件上传
        /// </summary>
        /// <returns></returns>
        public JsonResult UploadMultiBFI()
        {
            Hashtable ht_result = new Hashtable();
            List<Hashtable> list_file = new List<Hashtable>();
            try
            {
                string modelName = Request["modelName"];//获取文件所属的模块
                var fileArray = Request.Files;
                //HttpFileCollectionBase file = Request.Files;
                for (int i = 0; i < fileArray.Count; i++)
                {
                    string oldFileName = fileArray[i].FileName;//原文件名
                    int size = fileArray[i].ContentLength;//附件大小
                    Hashtable ht_file = new Hashtable();
                    string extenstion = oldFileName.Substring(oldFileName.LastIndexOf(".") + 1);//后缀名
                    string filename = DateTimeHelper.GetToday("yyyyMMddHHmmssfff") + "_" + oldFileName; //文件重命名
                    string savePath = Server.MapPath(string.IsNullOrEmpty(modelName) ? @"\Content\Files\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\" : @"\Content\Files\" + modelName + @"\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\");//Server.MapPath 获得虚拟服务器相对路径
                    string saveFullPath = savePath + filename;//文件路径
                    if (!(Directory.Exists(savePath)))
                    {//判断路径是否存在---不存在创建路径
                        Directory.CreateDirectory(savePath);
                    }
                    if ((System.IO.File.Exists(saveFullPath)))
                    {//判断文件是否已经存在，存在删除
                        System.IO.File.Delete(saveFullPath);
                    }

                    fileArray[i].SaveAs(saveFullPath);
                    bool uploaded = System.IO.File.Exists(saveFullPath);

                    if (uploaded)
                    {
                        ht_file.Add("status", "T");
                        ht_file.Add("msg", "上传成功！");
                        ht_file.Add("filename_o", oldFileName);
                        ht_file.Add("filename", filename);
                        ht_file.Add("path", (string.IsNullOrEmpty(modelName) ? @"\Content\Files\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\" : @"\Content\Files\" + modelName + @"\" + DateTimeHelper.GetToday("yyyyMMdd") + @"\") + filename);
                        list_file.Add(ht_file);
                    }
                }

                if (list_file.Count > 0)
                {
                    return Json(list_file); ;
                }
                ht_result.Add("status", "F");
                ht_result.Add("msg", "加载文件失败");
                return Json(ht_result); ;
            }
            catch (Exception ex)
            {
                ht_result.Add("status", "F");
                ht_result.Add("msg", "加载文件失败:" + ex.ToString());
                return Json(ht_result);
            }
        }


        /// <summary>
        /// 通过excel文件上传标的数据
        /// </summary>
        /// <returns></returns>
        public JsonResult Upload_bd_Excel()
        {
            Hashtable ht_result = new Hashtable();
            List<StringBuilder> sqls = new List<StringBuilder>();
            List<object> objs = new List<object>();

            string tablename = "TN_XM";
            string bindid = Request["bindid"] ?? "";

            string virPath = ConstantUtil.FILE_TEMP_URL;
            ExcelHelper excel = new ExcelHelper();
            DataTable dt = excel.upExcelToDatatable(HttpContext, virPath, ref ht_result);
            if (dt != null)
            {
                //判断主项目名称
                DataRow[] arrayDR = dt.Select("BaseName is null or BaseName='' ");
                if (arrayDR != null && arrayDR.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有主项目名称为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断子项目名称
                DataRow[] arrayDR1 = dt.Select("BaseSubName is null or BaseSubName='' ");
                if (arrayDR1 != null && arrayDR1.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有子项目名称为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断事项名称
                DataRow[] arrayDR2 = dt.Select("Name is null or Name='' ");
                if (arrayDR2 != null && arrayDR2.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有事项名称为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断事项编号
                DataRow[] arrayDR3 = dt.Select("RulesCode is null or RulesCode='' ");
                if (arrayDR3 != null && arrayDR3.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有事项编号为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断所属公司
                DataRow[] arrayDR4 = dt.Select("CompanyName is null or CompanyName='' ");
                if (arrayDR4 != null && arrayDR4.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有所属公司为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断项目状态
                DataRow[] arrayDR5 = dt.Select("ProjectState is null or ProjectState = '' ");
                if (arrayDR5 != null && arrayDR5.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有项目状态为空的数据，请完善！";
                    return Json(ht_result);
                }

                List<Hashtable> bdlist = DataTableHelper.DataTableToList(dt);
                List<Hashtable> keylist = new List<Hashtable>();
                for (int i = 0; i < bdlist.Count; i++)
                {
                    //DataRow[] array_Code = dt.Select("RulesCode ='" + bdlist[i]["RulesCode"].ToString().Trim() + "'");
                    //if (array_Code.Length > 1)
                    //{
                    //    ht_result["status"] = "F";
                    //    ht_result["msg"] = "导入失败,标的（" + bdlist[i]["RulesCode"].ToString() + "）重复，请修正！";
                    //    return Json(ht_result);
                    //}
                    //DataRow[] array_Name = dt.Select("Name ='" + bdlist[i]["Name"].ToString().Trim() + "'");
                    //if (array_Name.Length > 1)
                    //{
                    //    ht_result["status"] = "F";
                    //    ht_result["msg"] = "导入失败,标的（" + bdlist[i]["Name"].ToString() + "）重复，请修正！";
                    //    return Json(ht_result);
                    //}
                    //try
                    //{
                    //    double temp_d = double.Parse(bdlist[i]["QUANTITY"].ToString());
                    //    if (temp_d <= 0)
                    //    {
                    //        ht_result["status"] = "F";
                    //        ht_result["msg"] = "导入失败,标的（" + bdlist[i]["NUMBER"].ToString() + "）的数量必须大于0，请修正！";
                    //        return Json(ht_result);
                    //    }

                    //}
                    //catch (Exception e)
                    //{
                    //    ht_result["status"] = "F";
                    //    ht_result["msg"] = "导入失败,标的（" + bdlist[i]["NUMBER"].ToString() + "）的数量非法，请修正！";
                    //    return Json(ht_result);
                    //}
                    ////标底价 不填 默认为0
                    //if (bdlist[i]["HISPRICE"] == null || bdlist[i]["HISPRICE"].ToString().Trim() == "")
                    //{
                    //    bdlist[i]["HISPRICE"] = "0";
                    //}

                    bdlist[i].Add("ID", SequenceHelper.getSnowflakeID());
                    //bdlist[i].Add("BINDID", bindid);

                    var strSql = new StringBuilder();
                    strSql.Append(@"SELECT Code
                            FROM   TN_XM_Base
                            WHERE  1=1 and Name = '" + bdlist[i]["BASESUBNAME"] + "'");
                    var BaseCode = DataFactory.SqlDataBase().getString(strSql, null, "Code");
                    strSql.Clear();
                    strSql.Append(@"SELECT ParentCode
                            FROM   TN_XM_Base
                            WHERE  1=1 and ParentName = '" + bdlist[i]["BASENAME"] + "'");
                    var BaseSubCode = DataFactory.SqlDataBase().getString(strSql, null, "ParentCode");

                    bdlist[i].Add("BaseCode", BaseCode);
                    bdlist[i].Add("BaseSubCode", BaseSubCode);


                    Hashtable key_ht = new Hashtable();
                    //key_ht.Add("NUMBER", bdlist[i]["NUMBER"].ToString());
                    //key_ht.Add("BINDID", bindid);
                    keylist.Add(key_ht);
                }

                //生成子表sql
                SqlUtil.getBatchSqls(bdlist, tablename, keylist, ref sqls, ref objs);
                //执行sql
                int result = DataFactory.SqlDataBase().BatchExecuteByListSql(sqls, objs);

                if (result >= 0)
                {
                    ht_result["status"] = "T";
                    ht_result["msg"] = "操作成功！";
                }
                else
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "操作失败！";
                }
            }

            return Json(ht_result);
        }

        /// <summary>
        /// 通过excel文件上传标的数据
        /// </summary>
        /// <returns></returns>
        public JsonResult Upload_bd_Excel_CP()
        {
            Hashtable ht_result = new Hashtable();
            List<StringBuilder> sqls = new List<StringBuilder>();
            List<object> objs = new List<object>();

            string tablename = "TN_CG_CP";
            string bindid = Request["bindid"] ?? "";

            string virPath = ConstantUtil.FILE_TEMP_URL;
            ExcelHelper excel = new ExcelHelper();
            DataTable dt = excel.upExcelToDatatable(HttpContext, virPath, ref ht_result);
            if (dt != null)
            {
                ////判断项目名称
                //DataRow[] arrayDR = dt.Select("ProjectName is null or ProjectName='' ");
                //if (arrayDR != null && arrayDR.Length > 0)
                //{
                //    ht_result["status"] = "F";
                //    ht_result["msg"] = "导入失败，含有项目名称为空的数据，请完善！";
                //    return Json(ht_result);
                //}
                //判断项目编码
                DataRow[] arrayDR1 = dt.Select("ProjectNo is null or ProjectNo='' ");
                if (arrayDR1 != null && arrayDR1.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有项目编码为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断采购合同名称
                //DataRow[] arrayDR2 = dt.Select("CGName is null or CGName='' ");
                //if (arrayDR != null && arrayDR.Length > 0)
                //{
                //    ht_result["status"] = "F";
                //    ht_result["msg"] = "导入失败，含有采购合同名称为空的数据，请完善！";
                //    return Json(ht_result);
                //}
                //判断采购合同编码
                DataRow[] arrayDR3 = dt.Select("CGCode is null or CGCode='' ");
                if (arrayDR3 != null && arrayDR3.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有采购合同编码为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断设备包
                //DataRow[] arrayDR4 = dt.Select("CPpackage is null or CPpackage='' ");
                //if (arrayDR4 != null && arrayDR4.Length > 0)
                //{
                //    ht_result["status"] = "F";
                //    ht_result["msg"] = "导入失败，含有设备包为空的数据，请完善！";
                //    return Json(ht_result);
                //}
                //判断设备分类
                DataRow[] arrayDR5 = dt.Select("Classify is null or Classify = '' ");
                if (arrayDR5 != null && arrayDR5.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有设备分类为空的数据，请完善！";
                    return Json(ht_result);
                }

                //判断设备编码
                DataRow[] arrayDR6 = dt.Select("CPCode is null or CPCode = '' ");
                if (arrayDR6 != null && arrayDR6.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有设备编码为空的数据，请完善！";
                    return Json(ht_result);
                }
                //判断设备名称
                DataRow[] arrayDR7 = dt.Select("Name is null or Name = '' ");
                if (arrayDR7 != null && arrayDR7.Length > 0)
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "导入失败，含有设备名称为空的数据，请完善！";
                    return Json(ht_result);
                }
                List<Hashtable> bdlist = DataTableHelper.DataTableToList(dt);
                List<Hashtable> keylist = new List<Hashtable>();
                for (int i = 0; i < bdlist.Count; i++)
                {
                    //DataRow[] array_Code = dt.Select("RulesCode ='" + bdlist[i]["RulesCode"].ToString().Trim() + "'");
                    //if (array_Code.Length > 1)
                    //{
                    //    ht_result["status"] = "F";
                    //    ht_result["msg"] = "导入失败,标的（" + bdlist[i]["RulesCode"].ToString() + "）重复，请修正！";
                    //    return Json(ht_result);
                    //}
                    //DataRow[] array_Name = dt.Select("Name ='" + bdlist[i]["Name"].ToString().Trim() + "'");
                    //if (array_Name.Length > 1)
                    //{
                    //    ht_result["status"] = "F";
                    //    ht_result["msg"] = "导入失败,标的（" + bdlist[i]["Name"].ToString() + "）重复，请修正！";
                    //    return Json(ht_result);
                    //}
                    //try
                    //{
                    //    double temp_d = double.Parse(bdlist[i]["QUANTITY"].ToString());
                    //    if (temp_d <= 0)
                    //    {
                    //        ht_result["status"] = "F";
                    //        ht_result["msg"] = "导入失败,标的（" + bdlist[i]["NUMBER"].ToString() + "）的数量必须大于0，请修正！";
                    //        return Json(ht_result);
                    //    }

                    //}
                    //catch (Exception e)
                    //{
                    //    ht_result["status"] = "F";
                    //    ht_result["msg"] = "导入失败,标的（" + bdlist[i]["NUMBER"].ToString() + "）的数量非法，请修正！";
                    //    return Json(ht_result);
                    //}
                    ////标底价 不填 默认为0
                    //if (bdlist[i]["HISPRICE"] == null || bdlist[i]["HISPRICE"].ToString().Trim() == "")
                    //{
                    //    bdlist[i]["HISPRICE"] = "0";
                    //}

                    bdlist[i].Add("ID", SequenceHelper.getSnowflakeID());
                    //bdlist[i].Add("BINDID", bindid);

                    var strSql = new StringBuilder();
                    strSql.Append(@"SELECT Name
                            FROM   TN_XM
                            WHERE  1=1 and RulesCode+" + "'" + "-" + "'" + "+Code = '" + bdlist[i]["PROJECTNO"] + "'");
                    var ProjectName = DataFactory.SqlDataBase().getString(strSql, null, "Name");
                    strSql.Clear();
                    strSql.Append(@"SELECT Name
                            FROM   TN_HT_CG
                            WHERE  1=1 and Code = '" + bdlist[i]["CGCODE"] + "'");
                    var CGName = DataFactory.SqlDataBase().getString(strSql, null, "Name");
                    strSql.Clear();
                    strSql.Append(@"SELECT CPpackage
                            FROM   TN_HT_CG
                            WHERE  1=1 and Code = '" + bdlist[i]["CGCODE"] + "'");
                    var CPpackage = DataFactory.SqlDataBase().getString(strSql, null, "CPpackage");
                    strSql.Clear();
                    strSql.Append(@"SELECT id
                            FROM   TN_HT_CG
                            WHERE  1=1 and Code = '" + bdlist[i]["CGCODE"] + "'");
                    var id = DataFactory.SqlDataBase().getString(strSql, null, "id");
                    bdlist[i].Add("ProjectName", ProjectName);
                    bdlist[i].Add("CGName", CGName);
                    bdlist[i].Add("CPpackage", CPpackage);
                    bdlist[i].Add("BindId", id);


                    Hashtable key_ht = new Hashtable();
                    //key_ht.Add("NUMBER", bdlist[i]["NUMBER"].ToString());
                    //key_ht.Add("BINDID", bindid);
                    keylist.Add(key_ht);
                }

                //生成子表sql
                SqlUtil.getBatchSqls(bdlist, tablename, keylist, ref sqls, ref objs);
                //执行sql
                int result = DataFactory.SqlDataBase().BatchExecuteByListSql(sqls, objs);

                if (result >= 0)
                {
                    ht_result["status"] = "T";
                    ht_result["msg"] = "操作成功！";
                }
                else
                {
                    ht_result["status"] = "F";
                    ht_result["msg"] = "操作失败！";
                }
            }

            return Json(ht_result);
        }

        #endregion

        #region 下载文件数据
        /// <summary>
        ///下载excel模板
        /// </summary>
        /// <param name="context"></param>
        public void downloadExcelModule()
        {
            string filename = (Request["filename"] ?? "").ToString().Trim();
            string head = (Request["head"] ?? "").ToString().Trim();

            DataTable dt = new DataTable();

            Response.ContentType = "application/vnd.ms-excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Charset = "gb2312";
            Response.HeaderEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename + ".xls");
            MemoryStream ms = getMSFromDatatable(dt, head, 1);
            Response.BinaryWrite(ms.ToArray());
            Response.End();
        }

        /// <summary>
        ///下载excel模板
        /// </summary>
        /// <param name="context"></param>
        public void downloadQuoteData_sup()
        {
            string filename = (Request["filename"] ?? "").ToString().Trim();
            string head = (Request["head"] ?? "").ToString().Trim();
            string txt_keyword = (Request["txt_keyword"] ?? "").ToString().Trim();
            string BeginDate1 = (Request["BeginDate1"] ?? "").ToString().Trim();
            string BeginDate2 = (Request["BeginDate2"] ?? "").ToString().Trim();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM TN_XM where 1=1 and (code like '%" + txt_keyword + "%' or name like '%" + txt_keyword + "%') ");
            sql.Append(" and BeginDate >= '" + BeginDate1 + "' and BeginDate <= '" + BeginDate2 + "' ");
            DataTable dt = new DataTable();
            dt = new RepositoryFactory().BaseRepository().FindTable(sql.ToString());

            dt = DataFactory.SqlDataBase().GetDataTableBySQL(sql);
            Response.ContentType = "application/vnd.ms-excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Charset = "gb2312";
            Response.HeaderEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename + ".xls");
            MemoryStream ms = getMSFromDatatable(dt, head, 1, 1);
            Response.BinaryWrite(ms.ToArray());
            Response.End();
        }

        /// <summary>
        ///下载excel模板
        /// </summary>
        /// <param name="context"></param>
        public void downloadQuoteData_sup_CP()
        {
            string filename = (Request["filename"] ?? "").ToString().Trim();
            string head = (Request["head"] ?? "").ToString().Trim();
            string Name = (Request["Name"] ?? "").ToString().Trim();
            string HTName = (Request["HTName"] ?? "").ToString().Trim();
            string ProjectName = (Request["ProjectName"] ?? "").ToString().Trim();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM TN_CG_CP where 1=1 ");
            //查询条件
            if (Name != "")
            {
                sql.Append(" and Name like '%" + Name + "%'");
            }
            //查询条件
            if (HTName != "")
            {
                sql.Append(" and CGName  like '%" + HTName + "%'");
            }
            //查询条件
            if (ProjectName != "")
            {
                sql.Append(" and ProjectName like '%" + ProjectName + "%'");
            }
            DataTable dt = new DataTable();
            dt = new RepositoryFactory().BaseRepository().FindTable(sql.ToString());

            dt = DataFactory.SqlDataBase().GetDataTableBySQL(sql);
            Response.ContentType = "application/vnd.ms-excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Charset = "gb2312";
            Response.HeaderEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename + ".xls");
            MemoryStream ms = getMSFromDatatable(dt, head, 1, 1);
            Response.BinaryWrite(ms.ToArray());
            Response.End();
        }
        #endregion

        #region 验证数据

        #endregion

        #region 辅助函数
        /// <summary>
        /// 获取导出excel流
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="head">表头数据（json格式）</param>
        /// <param name="ifJudgeKey">是否判断data是否含有Key 0：判断；非0：不判断 </param>
        /// <param name="type">表头格式0：Value；1：Key<Value> </param>
        /// <returns></returns>
        private MemoryStream getMSFromDatatable(DataTable data, string head, int ifJudgeKey = 0, int type = 0)
        {
            Dictionary<string, string> dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(head);
            Dictionary<string, string> dic_temp = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> de in dic)
            {
                if (ifJudgeKey == 0)
                {
                    if (data.Columns.Contains(de.Key))
                    {
                        if (type == 0)
                        {
                            dic_temp.Add(de.Key, de.Key + "<" + de.Value + ">");
                        }
                        else
                        {
                            dic_temp.Add(de.Key, de.Value);
                        }

                    }
                }
                else
                {
                    if (type == 0)
                    {
                        dic_temp.Add(de.Key, de.Key + "<" + de.Value + ">");
                    }
                    else
                    {
                        dic_temp.Add(de.Key, de.Value);
                    }
                }

            }
            NPOIHelper.ListColumnsName = dic_temp;
            MemoryStream ms = NPOIHelper.RetrunStream(data);
            return ms;
        }
        #endregion
    }
}