using Infrastructure.Data;

namespace Booking.Forms.Hotel;

public partial class HotelMainForm : Form
{
    public HotelMainForm()
    {
        InitializeComponent();
    }
    
    private void btnCreateHotel_Click(object sender, EventArgs e)
    {
        HotelCreateForm dlg = new();
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            UpdateHotelDgv();
        }
    }

    private void HotelMainForm_Load(object sender, EventArgs e)
    {
        UpdateHotelDgv();
    }

    private void UpdateHotelDgv()
    {
        ApplicationDbContext context = new();
        var list = context.Hotels.ToList();
        dgvHotels.Rows.Clear();
        foreach (var hotel in list)
        {
            object[] row = [hotel.Id, hotel.Name, hotel.Address, hotel.Description];
            dgvHotels.Rows.Add(row);
        }
    }
}