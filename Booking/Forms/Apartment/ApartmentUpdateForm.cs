using Domain.Entities;
using Infrastructure.Data;

namespace Booking.Forms.Apartment;

public partial class ApartmentUpdateForm : Form
{
    public ApartmentEntity PreviousApartment;
    private ApplicationDbContext context = new();
    
    public ApartmentUpdateForm()
    {
        InitializeComponent();
    }

    private void btnConfirmUpdate_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtNumberOfRooms.Text, out int numberOfRooms))
        {
            MessageBox.Show("Введіть ціле число кімнат", "Увага");
            return;
        }
        if (!int.TryParse(txtNumberOfRooms.Text, out int numberOfBeds))
        {
            MessageBox.Show("Введіть ціле число спальних місць", "Увага");
            return;
        }
        if (!decimal.TryParse(txtNumberOfRooms.Text, out decimal pricePerNight))
        {
            MessageBox.Show("Введіть ціну за 1 ніч", "Увага");
            return;
        }

        PreviousApartment.NumberOfRooms = numberOfRooms;
        PreviousApartment.NumberOfBeds = numberOfBeds;
        PreviousApartment.PricePerNight = pricePerNight;
        PreviousApartment.Number = txtName.Text;
        context.SaveChanges();
    }
    
    private void ApartmentUpdateForm_Load(object sender, EventArgs e)
    {
        lblName.Text = $"Назва: {PreviousApartment.Number}";
        lblNumberOfRooms.Text = $"Число кімнат: {PreviousApartment.NumberOfRooms}";
        lblNumberOfBeds.Text = $"Число спальних місць: {PreviousApartment.NumberOfBeds}";
        lblPricePerNight.Text = $"Ціна за 1 ніч: {PreviousApartment.PricePerNight}";

        lblArrowName.Location = lblArrowName.Location with
        {
            X = lblName.ClientSize.Width + lblName.Location.X + 10
        };

        lblArrowNumberOfRooms.Location = lblArrowNumberOfRooms.Location with
        {
            X = lblArrowNumberOfRooms.ClientSize.Width + lblArrowNumberOfRooms.Location.X + 10
        };

        lblArrowNumberOfBeds.Location = lblArrowNumberOfBeds.Location with
        {
            X = lblArrowNumberOfBeds.ClientSize.Width + lblArrowNumberOfBeds.Location.X + 10
        };

        lblArrowPricePerNight.Location = lblArrowPricePerNight.Location with
        {
            X = lblArrowPricePerNight.ClientSize.Width + lblArrowPricePerNight.Location.X + 10
        };

        txtName.Location = txtName.Location with { X = lblArrowName.ClientSize.Width + lblArrowName.Location.X + 10 };
        txtNumberOfRooms.Location = txtNumberOfRooms.Location with { X = lblArrowNumberOfRooms.ClientSize.Width + lblArrowNumberOfRooms.Location.X + 10 };
        txtNumberOfBeds.Location = txtNumberOfBeds.Location with { X = lblArrowNumberOfBeds.ClientSize.Width + lblArrowNumberOfBeds.Location.X + 10 };
        txtPricePerNight.Location = txtPricePerNight.Location with { X = lblArrowPricePerNight.ClientSize.Width + lblArrowPricePerNight.Location.X + 10 };

    }
}