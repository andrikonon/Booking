using Domain.Entities;
using Infrastructure.Data;

namespace Booking.Forms.Hotel;

public partial class HotelCreateForm : Form
{
    public HotelCreateForm()
    {
        InitializeComponent();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        using ApplicationDbContext context = new();
        HotelEntity hotel = new HotelEntity
        {
            Name = txtName.Text,
            Description = txtDescription.Text,
            Address = txtAddress.Text,
        };
        context.Hotels.Add(hotel);
        context.SaveChanges();
        this.Close();
        this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}