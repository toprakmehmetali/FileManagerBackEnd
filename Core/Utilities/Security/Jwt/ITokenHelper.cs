using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;


namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserBase user, List<OperationClaim> operationClaims);
    }
}
