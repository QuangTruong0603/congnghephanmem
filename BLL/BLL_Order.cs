using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public  class BLL_Order
    {

        private DAL_Order dAL_Order = new DAL_Order();


        public DataTable getAllOrder()
        {
            return dAL_Order.getAllOrder();
        }


        public DataTable getOrderByStatus(string status)
        {
            return dAL_Order.getOrderByStatus(status);
        }

        public Dictionary<string, string> getOrderById(int id) {
            return dAL_Order.getOrderById(id);
        }

        public DataTable getOrderDetailById(int id)
        {
            return dAL_Order.getOrderDetailById(id);
        }

        public DataTable getOneOrderById(int id)
        {
            return dAL_Order.getOneOrderById(id);
        }


        public List<DTO_BillDetail> getListProductOfOrder(int id)
        {
            return dAL_Order.getListProductOfOrder(id);
        }

        public Boolean deleteOrder(int id)
        {
            return dAL_Order.deleteOrder(id);   
        }


        public Boolean addProductOrderDetail(int orderId, int productid, string size, int quantity, int price)
        {
            return dAL_Order.addProductOrderDetail(orderId, productid, size, quantity, price);
        }

        public Boolean deleteProductOrderDetail(int orderId, int productid)
        {
            return dAL_Order.deleteProductOrderDetail(orderId, productid);
        }

        public Boolean updateOrder(int orderid, string name, string address, string phone, string status, string paychek, int delivery)
        {
            return dAL_Order.updateOrder(orderid, name, address, phone, status, paychek, delivery);
        }

    }
}
