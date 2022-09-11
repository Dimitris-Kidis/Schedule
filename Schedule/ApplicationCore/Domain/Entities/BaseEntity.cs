using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //???????????????????????
        public int Id { get; set; }

        //???????????????????????
        //public string CreatedBy { get; set; } = null!;
        //public string? LastModifiedBy { get; set; }
        //public DateTimeOffset CreatedAt { get; set; }
        //public DateTimeOffset? LastModifiedAt { get; set; }
    }
}
