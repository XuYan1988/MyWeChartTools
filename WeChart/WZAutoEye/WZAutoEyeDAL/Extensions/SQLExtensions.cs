using WZAutoEye.WZAutoEyeMVC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.DAL
{
    public class SQLExtensions
    {
        /// <summary>
        /// 封装的数据库保存类
        /// </summary>
        /// <param name="db">相关数据库连接</param>
        public static void SaveChanges(SQLDBConnect db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                //发生错误，写入物理文件数据库错误日志
                //LogHelper.AddErrorLog((new StackTrace()).GetFrame(1).GetMethod().ReflectedType.Name, (new StackTrace()).GetFrame(1).GetMethod().Name, ex.Message + "（内部错误：" + ex.InnerException + "）");
                throw new Exception("数据库操作失败：" + ex.Message);
            }
        }
    }
}
