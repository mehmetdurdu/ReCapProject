﻿using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utitilies.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
