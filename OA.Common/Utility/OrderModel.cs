using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Common.Utility
{
    public static class OrderModelUtility
    {
        public static OrderModel Order(string orderBy)
        {
            OrderModel result = new OrderModel();
            bool asc = true;
            result.asc = asc;
            string orderParams = string.Empty;
            if (string.IsNullOrEmpty(orderBy))
            {
                result.orderParam = "ID";

            }
            else
            {
                if (orderBy.Contains(":"))
                {
                    var paramsOrder = orderBy.Split(":");
                    if (paramsOrder.Length <= 2)
                    {
                        foreach (var item in paramsOrder)
                        {
                            if (item.ToLower().Contains("desc"))
                            {
                                result.asc = false;
                                continue;
                            }
                            else if (item.ToLower().Contains("asc"))
                            {
                                result.asc = true;
                                continue;
                            }
                            if (item.ToLower() == "date")
                            {
                                result.orderParam = "AddedDate";
                            }
                            else
                            {
                                result.orderParam = item;

                            }
                        }
                    }
                }
                else
                {
                    result.orderParam = orderBy;
                }
            }
            return result;
        }
    }

    public class OrderModel
    {
        public string orderParam { get; set; }
        public bool asc { get; set; }
    }
}
