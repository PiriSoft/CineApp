using CineApp.Core.Entities.Abstract;
using CineApp.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace CineApp.Entities.Dtos.UserOperationClaimDtos
{
    public class UserOperationClaimDto:IDto
    {
        public int UserId { get; set; }
        public IEnumerable<OperationClaim> OperationClaims { get; set; }
    }
}
