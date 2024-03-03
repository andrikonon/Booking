using Infrastructure.Data;

namespace Booking.Forms.Apartment;

public partial class ApartmentListForm : Form
{
    public int FloorId { get; set; }

    private ApplicationDbContext context;
    
    public ApartmentListForm()
    {
        InitializeComponent();
    }

    private void btnApartmentCreate_Click(object sender, EventArgs e)
    {
        ApartmentCreateForm apartmentCreateForm = new();
        apartmentCreateForm.FloorId = FloorId;
        if (apartmentCreateForm.ShowDialog() == DialogResult.OK)
        {

        }
    }
}