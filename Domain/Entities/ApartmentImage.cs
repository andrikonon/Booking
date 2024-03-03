using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("tblApartmentImage")]
public class ApartmentImage
{
    [Key]
    public int Id { get; set; }
    [Required, StringLength(200)]
    public string Name { get; set; }
    public short Priority { get; set; }
    [ForeignKey("Apartment")]
    public int ApartmentId { get; set; }
    public virtual ApartmentEntity Apartment { get; set; }
}