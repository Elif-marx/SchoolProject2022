using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete.School
{
    public class OperationClaim
    {
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }

	}
}
