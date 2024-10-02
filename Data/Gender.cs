using System.ComponentModel.DataAnnotations;

namespace Conference.Api.Data
{
    public class Gender : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}