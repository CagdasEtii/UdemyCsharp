namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();


        static Repository(){
            _categories.Add(new Category{CategoryId = 1, CategoryName = "Cep Telefonu"});
            _categories.Add(new Category{CategoryId = 2, CategoryName = "Bilgisayar"});
            
            _products.Add(new Product{
                ProductId = 1, 
                ProductName = "iPhone 14", 
                ProductPrice = 40000, 
                ProductCategoryId = 1, 
                IsActive = true, 
                ProductImage = "1.jpg", 
                ProductDescription = "iPhone 14 256 GB"
                }
            );

            _products.Add(new Product{
                ProductId = 2, 
                ProductName = "iPhone 15", 
                ProductPrice = 50000, 
                ProductCategoryId = 1, 
                IsActive = true, 
                ProductImage = "2.jpg", 
                ProductDescription = "iPhone 15 500 GB"
                }
            );

            _products.Add(new Product{
                ProductId = 3, 
                ProductName = "iPhone 16", 
                ProductPrice = 60000, 
                ProductCategoryId = 1, 
                IsActive = true, 
                ProductImage = "3.jpg", 
                ProductDescription = "iPhone 16 1 TB"
                }
            );

            _products.Add(new Product{
                ProductId = 4, 
                ProductName = "iPhone 17", 
                ProductPrice = 70000, 
                ProductCategoryId = 1, 
                IsActive = true, 
                ProductImage = "4.jpg", 
                ProductDescription = "iPhone 17 2 TB"
                }
            );


            _products.Add(new Product{
                ProductId = 5, 
                ProductName = "Macbook Air", 
                ProductPrice = 75000, 
                ProductCategoryId = 2, 
                IsActive = true, 
                ProductImage = "5.jpg", 
                ProductDescription = "Macbook Air 2021"
                }
            );

            _products.Add(new Product{
                ProductId = 6, 
                ProductName = "Macbook Pro", 
                ProductPrice = 100000, 
                ProductCategoryId = 2, 
                IsActive = true, 
                ProductImage = "6.jpg", 
                ProductDescription = "Macbook Pro 2021"
                }
            );
        }


        public static List<Product> Products{ 
            get{
                return _products;
            }  
        }
        
        
        public static List<Category> Categories{ 
            get{
                return _categories;
            }  
        }
    }
}