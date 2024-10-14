using System.ComponentModel.DataAnnotations;

namespace Conference.Api.Data
{
    public class ReferralSource : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
