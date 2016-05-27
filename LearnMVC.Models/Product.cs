using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMVC.Models
{
    /// <summary>
    /// Product:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Product
    {
        public Product()
        { }
        #region Model
        private Guid _uuid;
        private string _name;
        private string _category;
        private decimal _price;
        private decimal _org_price;
        private string _brand;
        private string _title;
        private string _header;
        private string _description;
        private string _image_url;
        private int _special;
        private DateTime _update_datetime;
        private DateTime _product_datetime;
        private int _is_top;
        private int _is_soldout;
        private Guid _seller_id;
        /// <summary>
        /// 
        /// </summary>
        public Guid uuid
        {
            set { _uuid = value; }
            get { return _uuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal org_price
        {
            set { _org_price = value; }
            get { return _org_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string brand
        {
            set { _brand = value; }
            get { return _brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string header
        {
            set { _header = value; }
            get { return _header; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string image_url
        {
            set { _image_url = value; }
            get { return _image_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int special
        {
            set { _special = value; }
            get { return _special; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime update_datetime
        {
            set { _update_datetime = value; }
            get { return _update_datetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime product_datetime
        {
            set { _product_datetime = value; }
            get { return _product_datetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_top
        {
            set { _is_top = value; }
            get { return _is_top; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_soldout
        {
            set { _is_soldout = value; }
            get { return _is_soldout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid seller_id
        {
            set { _seller_id = value; }
            get { return _seller_id; }
        }
        #endregion Model

    }
}
