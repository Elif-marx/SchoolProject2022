using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete.School
{
    public class User:IEntity
    {
		[Key]
		public int Id { get; set; }
		public string? Email { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Password { get; set; }
        public ICollection<OperationClaim>? OperationClaims  { get; set; }

    }
}
