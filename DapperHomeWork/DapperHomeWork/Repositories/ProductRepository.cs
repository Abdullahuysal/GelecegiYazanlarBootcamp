using Dapper;
using DapperHomeWork.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperHomeWork.Repositories
{
    public class ProductRepository : IProductRepository
    {
        string sqlcon = "Data Source=DESKTOP-2DE1HM4\\SQLEXPRESS;Database=DapperIntro;Integrated Security=True";
        public string Add(Product product)
        {
            using (IDbConnection db = new SqlConnection(sqlcon))
            {
                var rowsaffected=db.Execute(@"INSERT INTO [dbo].[Products]
                        ([ProductName]
                        ,[ProductQuantity]
                        ,[ProductPrice])
                        VALUES
                        (@ProductName,
                         @ProductQuantity,
                         @ProductPrice)",
                         new
                         {
                             product.ProductName,
                             product.ProductQuantity,
                             product.ProductPrice
                         });
                return Messages.AddSuccesfull;
            }
          
                
        }

        public string Delete(int productId)
        {
            using (IDbConnection db = new SqlConnection(sqlcon))
            {
                var sqlstate = "Delete Products Where ProductId=@ProductId";
                db.Execute(sqlstate, new { ProductId = productId });
            }
            return Messages.DeleteSuccessfull;
        }

        public List<Product> GetAll()
        {
            using (IDbConnection db = new SqlConnection(sqlcon))
            {
                
                return db.Query<Product>("Select * FROM Products").ToList();
            }
            
        }

        public Product GetById(int ProductId)
        {
            using (IDbConnection db = new SqlConnection(sqlcon))
            {
                return db.Query<Product>("Select * From Products Where ProductId=@ProductId",new {ProductId=ProductId}).SingleOrDefault();
            }
        }
    }
}
