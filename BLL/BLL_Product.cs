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

    
    public class BLL_Product
    {

        private DAL_Productcs dAL_Productcs = new DAL_Productcs();
 

        public BLL_Product() { }

        public DataTable getProductManage()
        {
            return dAL_Productcs.getProductManage();
        }

        public DataTable getProductManageKD()
        {
            return dAL_Productcs.getProductManageKD();
        }
        public DataTable getProductManageKKD()
        {
            return dAL_Productcs.getProductManageKKD();
        }




        public Boolean DisableProduct(String sku)
        {
            return dAL_Productcs.DisableProduct(sku);
        }

        public DataTable findProduct(String barcode)
        {
            return dAL_Productcs.findOneProduct(barcode);
        }


        public Boolean checkBarcode(String barcode)
        {
            return dAL_Productcs.checkBarcodeProduct(barcode);
        }

        public Boolean checkBarcode2(String barcode)
        {
            return dAL_Productcs.checkBarcodeProduct2(barcode);
        }

        public Boolean enableproduct(String sku)
        {
            return dAL_Productcs.enableProduct(sku);
        }




        public String checkProduct(DTO_Product product, String filename, String path)
        {
            String sku = product.product_barcode.ToString();


            if(product.product_name == "" || product.product_barcode == "" || product.procduct_image == "")
            {
                return "Vui lòng nhập đầy đủ thông tin";
            }

          
            if(product.product_price < 1000)
            {
                return "Giá bán phải lớn hơn hoặc bằng 1000 VND";
            }

            if (dAL_Productcs.checkBarcodeProduct(sku) == false)
            {
                return "Mã sản phẩm đã tồn tại trong dữ liệu cửa hàng";
            }


            return "OK";

        }

        public String checkProductNoBarcode(DTO_Product product, String filename, String path)
        {
            String sku = product.product_barcode.ToString();


            if (product.product_name == "" || product.product_barcode == "" || product.procduct_image == "")
            {
                return "Vui lòng nhập đầy đủ thông tin";
            }


            if (product.product_price < 1000)
            {
                return "Giá bán phải lớn hơn hoặc bằng 1000 VND";
            }


            return "OK";

        }




        public String newFilenName(String name)
        {
            return dAL_Productcs.newFileName(name);
        }


        public Boolean addNewProduct(DTO_Product product)
        {

            return  dAL_Productcs.addProduct(product);

     
        }

        public DTO_Product getProductBarcode(String barcode)
        {
            return dAL_Productcs.getProduct(barcode);
        }


        public Boolean updateProduct(DTO_Product p)
        {
            return dAL_Productcs.updateProduct(p);
        }
    }
}
