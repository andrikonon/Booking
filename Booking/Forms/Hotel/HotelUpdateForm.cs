using Domain.Entities;

namespace Booking.Forms.Hotel;

public partial class HotelUpdateForm : Form
{
    public HotelEntity PreviousHotel;
    
    public HotelUpdateForm()
    {
        InitializeComponent();
    }

    private void HotelUpdateForm_Load(object sender, EventArgs e)
    {
        lblName.Text = $"Назва: {PreviousHotel.Name}";
        lblAddress.Text = $"Адреса: {PreviousHotel.Address}";
        lblDescription.Text = $"Опис: {PreviousHotel.Description}";

        lblArrowName.Location = lblArrowName.Location with
        {
            X = lblName.ClientSize.Width + lblName.Location.X + 10
        };

        lblArrowAddress.Location = lblArrowAddress.Location with
        {
            X = lblAddress.ClientSize.Width + lblAddress.Location.X + 10
        };

        lblArrowDescription.Location = lblArrowDescription.Location with
        {
            X = lblDescription.ClientSize.Width + lblDescription.Location.X + 10
        };

        txtName.Location = txtName.Location with { X = lblArrowName.ClientSize.Width + lblArrowName.Location.X + 10 };
        txtAddress.Location = txtAddress.Location with { X = lblArrowAddress.ClientSize.Width + lblArrowAddress.Location.X + 10 };
        txtDescription.Location = txtDescription.Location with { X = lblArrowDescription.ClientSize.Width + lblArrowDescription.Location.X + 10 };

    }

    private void btnConfirmUpdate_Click(object sender, EventArgs e)
    {
        
    }
}