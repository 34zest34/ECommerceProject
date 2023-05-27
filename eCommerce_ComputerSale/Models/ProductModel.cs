namespace eCommerce_ComputerSale.Models
{
    public class ProductModel
    {
        public string Product_Code { get; set; } //p001
        public string ProductName { get; set; } // Dell Inspiron 14 5425 
        public string Description { get; set; } // AMD ......
        public string Brand_Code { get; set; } //B001
        public string Category_Id { get; set; } //C001
        public int Warrantry { get; set; } //2 years
        public int Qty { get; set;} // 30
        public double Product_Price { get; set;} //12000000
        
    }
}
