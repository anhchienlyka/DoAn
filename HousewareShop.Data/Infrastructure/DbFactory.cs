using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HousewareShopDbContext dbContext;

        public HousewareShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HousewareShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
