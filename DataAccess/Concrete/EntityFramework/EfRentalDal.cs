using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from rnt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on rnt.CarId equals ca.CarId
                             join cst in context.Customers
                             on rnt.CustomerId equals cst.Id
                             join usr in context.Users
                             on cst.UserId equals usr.Id
                             select new RentalDetailDto
                             {
                                 Id = rnt.Id,
                                 CarName = ca.CarName,
                                 CustomerName = cst.CompanyName,
                                 CarId = ca.CarId,
                                 RentDate = rnt.RentDate,
                                 ReturnDate = rnt.ReturnDate,
                                 UserName = usr.FirstName + " " + usr.LastName
                             };
                return result.ToList();
            }
        }
    }
}
