using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("tblApartments")]
public class ApartmentEntity
{
    [Key]
    public int Id { get; set; }
    [Required, StringLength(20)]
    public string Number { get; set; }
    public int NumberOfRooms { get; set; }
    public int NumberOfBeds { get; set; }
    public decimal PricePerNight { get; set; }
    [ForeignKey("Floor")]
    public int FloorId { get; set; }
    public virtual FloorEntity Floor { get; set; }
    
    public ICollection<ApartmentImage> ApartmentImages { get; set; }
}