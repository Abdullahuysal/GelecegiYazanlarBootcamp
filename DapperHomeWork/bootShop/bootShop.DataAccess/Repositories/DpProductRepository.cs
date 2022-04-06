using bootShop.DataAccess.Data;
using bootShop.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Repositories
{
    public class DpProductRepository : IProductRepository
    {
        private string sqlCon = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=bootCampShopDb;Integrated Security=True";
      
        public  async Task<int> Add(Product entity)
        {
            using (IDbConnection db=new SqlConnection(sqlCon))
            {
                var rowsAffected = await db.ExecuteAsync(@"INSERT INTO [dbo].[Products]
                        ([Name]
                        ,[Descriptipn]
                        ,[ImageUrl]
                        ,[CategoryId])
                        VALUES
                        (@Name,
                         @Descriptipn,
                         @ImageUrl,
                         @CategoryId)",
                          new
                          {
                              entity.Name,
                              entity.Descriptipn,
                              entity.ImageUrl,
                              entity.CategoryId
                          }
                        );
                
                return rowsAffected;
            }
        }

        public async Task Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(sqlCon))
            {
                var sqlstate = "DELETE FROM Products Where Id=@Id ";
                await db.ExecuteAsync(sqlstate, new { Id = id });
            }
        }

        public async Task<IList<Product>> GetAllEntities()
        {
            using (IDbConnection db = new SqlConnection(sqlCon))
            {
                var sqlstate = "SELECT * FROM Products";
                var products= await db.QueryAsync<Product>(sqlstate);
                return products.ToList();
            }
        }

        public async Task<Product> GetEntityById(int id)
        {
            using (IDbConnection db = new SqlConnection(sqlCon))
            {
                var sqlstate = "SELECT * FROM Products WHERE Id=@Id";
                var product = await db.QuerySingleAsync<Product>(sqlstate,new {Id=id});
                return product;
            }
        }

        public async Task<IList<Product>> SearchProductsByName(string name)
        {
            using (IDbConnection db = new SqlConnection(sqlCon))
            {
                var sqlstate = "SELECT * FROM Products WHERE Name=@Name";
                var product = await db.QueryAsync<Product>(sqlstate, new { Name = name });
                return product.ToList();
            }
        }

        public async Task<int> Update(Product entity)
        {
            using (IDbConnection db = new SqlConnection(sqlCon))
            {
                var rowsAffected = await db.ExecuteAsync(@"UPDATE  [dbo].[Products] SET
                        ([Name]
                        ,[Descriptipn]
                        ,[ImageUrl]
                        ,[CategoryId])
                        VALUES
                        (@Name,
                         @Descriptipn,
                         @ImageUrl,
                         @CategoryId) WHERE Id=@Id",
                          new
                          {
                              entity.Name,
                              entity.Descriptipn,
                              entity.ImageUrl,
                              entity.CategoryId,
                              entity.Id
                          }
                        );
                return rowsAffected;
            }

        }
    }
}
