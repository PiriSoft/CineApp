using CineApp.Core.Entities.Abstract;

namespace CineApp.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
        public OperationClaim OperationClaim { get; set; }

    }
}
