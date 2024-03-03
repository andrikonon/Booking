using Domain.Entities;
using Infrastructure.Data;

namespace Booking.Forms.Floor;

public partial class FloorCreateForm : Form
{
    public HotelEntity hotel;

    private ApplicationDbContext context = new();
    
    public FloorCreateForm()
    {
        InitializeComponent();
    }
    
    private void FloorCreateForm_Load(object sender, EventArgs e)
    {
        lblHotelName.Text = hotel.Name;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        FloorEntity floor = new FloorEntity
        {
            Name = txtName.Text,
            HotelId = hotel.Id,
        };
        context.HotelFloors.Add(floor);
        context.SaveChanges();
        this.Close();
        this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}