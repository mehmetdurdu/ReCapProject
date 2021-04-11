using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DatabaseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new DatabaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public UserDetailDto GetUserDetail(string userMail)
        {
            using (var context = new DatabaseContext())
            {
                var result =
                    (from u in context.Users
                     join c in context.Customers
                         on u.UserId equals c.UserId
                     where u.Email == userMail
                     select new UserDetailDto
                     {
                         UserId = u.UserId,
                         CustomerId = c.CustomerId,
                         FirstName = u.FirstName,
                         LastName = u.LastName,
                         Email = u.Email,
                         CompanyName = c.CompanyName
                     }).First();
                return result;
            }
        }
    }
}
