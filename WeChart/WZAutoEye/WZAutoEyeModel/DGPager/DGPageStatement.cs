using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public class DGPageStatement
    {
        public DGPageStatement()
        {

        }

        public DGPageStatement(string SelectStr, string FromStr, string WhereStr)
        {
            SelectStatement = SelectStr;
            FromStatement = FromStr;
            WhereStatement = WhereStr;
        }

        // Select 字段, 字符串不应该包括"select"
        public string SelectStatement
        {
            get;
            set;
        }

        // From及Join语句, 字符串不应该包括"from"
        public string FromStatement
        {
            get;
            set;
        }

        // Where条件语句, 字符串不应该包括"where"
        public string WhereStatement
        {
            get;
            set;
        }
    }
}