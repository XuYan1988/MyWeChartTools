using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public class DGPageOrder
    {
        public DGPageOrder()
        {

        }

        public DGPageOrder(int pageCountValue, int pageIndexValue, string sortValue, string orderValue)
        {
            pageCount = pageCountValue;
            pageIndex = pageIndexValue;
            sort = sortValue;
            order = orderValue;
        }

        // 每页显示条数
        public int pageCount
        {
            get;
            set;
        }

        // 页数，从0开始
        public int pageIndex
        {
            get;
            set;
        }

        // ASC 或 DESC
        public string sort
        {
            get;
            set;
        }

        // 排序字段
        public string order
        {
            get;
            set;
        }
    }
}
