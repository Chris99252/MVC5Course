using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            return base.All().Where(p => p.IsDelete == false);
        }

        public Client Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }

        public ObjectResult<Product> QueryProduct()
        {
            return ((FabricsEntities)this.UnitOfWork.Context).QueryProduct();
        }

        public void Delete(Client client)
        {
            //client.IsDelete = true;

            var db = ((FabricsEntities)this.UnitOfWork.Context);
            foreach (var item in db.Order.ToList())
            {
                db.OrderLine.RemoveRange(item.OrderLine);
            }
            db.Order.RemoveRange(client.Order);
        }

        internal IQueryable<Client> 在首頁取得客戶資料(int num)
        {
            return this.All().Take(num);
        }
    }

	public  interface IClientRepository : IRepository<Client>
	{

	}
}