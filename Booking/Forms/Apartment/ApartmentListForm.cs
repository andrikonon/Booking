using Domain.Entities;
using Infrastructure.Data;

namespace Booking.Forms.Apartment;

public partial class ApartmentListForm : Form
{
    public int FloorId { get; set; }

    private ApplicationDbContext context = new();
    
    public ApartmentListForm()
    {
        InitializeComponent();
        AlignItems();
    }

    private void AlignItems()
    {
        int rightEdge1 = ((int[]) [lblPricePerNight1.ClientSize.Width,
            lblNumberOfBeds1.ClientSize.Width,
            lblNumberOfRooms1.ClientSize.Width]).Max();
        rightEdge1 += lblPricePerNight1.Location.X;
        rightEdge1 += 10;

        txtPricePerNightMin.Location = txtPricePerNightMin.Location with { X = rightEdge1 };
        txtNumberOfBedsMin.Location = txtNumberOfBedsMin.Location with { X = rightEdge1 };
        txtNumberOfRoomsMin.Location = txtNumberOfRoomsMin.Location with { X = rightEdge1 };
        
        int rightEdge2 = ((int[]) [txtPricePerNightMin.ClientSize.Width,
            txtNumberOfBedsMin.ClientSize.Width,
            txtNumberOfRoomsMin.ClientSize.Width]).Max();
        rightEdge2 += rightEdge1;
        rightEdge2 += 10;
        
        lblPricePerNight2.Location = lblPricePerNight2.Location with {X = rightEdge2};
        lblNumberOfBeds2.Location = lblNumberOfBeds2.Location with {X = rightEdge2};
        lblNumberOfRooms2.Location = lblNumberOfRooms2.Location with {X = rightEdge2};
        
        int rightEdge3 = ((int[]) [lblPricePerNight2.ClientSize.Width,
            lblNumberOfBeds2.ClientSize.Width,
            lblNumberOfRooms2.ClientSize.Width]).Max();
        rightEdge3 += rightEdge2;

        txtPricePerNightMax.Location = txtPricePerNightMax.Location with {X = rightEdge3};
        txtNumberOfBedsMax.Location = txtNumberOfBedsMax.Location with {X = rightEdge3};
        txtNumberOfRoomsMax.Location = txtNumberOfRoomsMax.Location with {X = rightEdge3};
        
        int rightEdge4 = ((int[]) [txtPricePerNightMax.ClientSize.Width,
            txtNumberOfBedsMax.ClientSize.Width,
            txtNumberOfRoomsMax.ClientSize.Width]).Max();
        rightEdge4 += rightEdge3;
        rightEdge4 += 20;

        btnSearch.Location = btnSearch.Location with { X = rightEdge4 };

        int rightEdge5 = btnSearch.ClientSize.Width;
        rightEdge5 += rightEdge4;
        rightEdge5 += 20;

        btnApartmentCreate.Location = btnApartmentCreate.Location with { X = rightEdge5 };
        btnApartmentUpdate.Location = btnApartmentUpdate.Location with { X = rightEdge5 };

    }

    private void btnApartmentCreate_Click(object sender, EventArgs e)
    {
        ApartmentCreateForm apartmentCreateForm = new();
        apartmentCreateForm.FloorId = FloorId;
        if (apartmentCreateForm.ShowDialog() == DialogResult.OK)
        {

        }
    }

    private void btnApartmentUpdate_Click(object sender, EventArgs e)
    {
        // ApartmentUpdateForm apartmentUpdateForm = new();
        // apartmentUpdateForm.PreviousApartment = ...
    }

    private void dgvApartments_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        decimal PriceMin = decimal.Parse(txtPricePerNightMin.Text);
        decimal PriceMax = decimal.Parse(txtPricePerNightMax.Text);

        int NumberOfRoomsMin = int.Parse(txtNumberOfRoomsMin.Text);
        int NumberOfRoomsMax = int.Parse(txtNumberOfRoomsMax.Text);
        
        int NumberOfBedsMin = int.Parse(txtNumberOfBedsMin.Text);
        int NumberOfBedsMax = int.Parse(txtNumberOfBedsMax.Text);
        var matchingApartments = context
            .Apartments
            .Where(ap => PriceMin <= ap.PricePerNight && ap.PricePerNight <= PriceMax)
            .Where(ap => NumberOfRoomsMin <= ap.NumberOfRooms && ap.NumberOfRooms <= NumberOfRoomsMax)
            .Where(ap => NumberOfBedsMin <= ap.NumberOfBeds && ap.NumberOfBeds <= NumberOfBedsMax)
            .ToList();
        UpdateApartmentsDgv(matchingApartments);
    }
    
    private void UpdateApartmentsDgv(List<ApartmentEntity>? list = null)
    {
        list ??= context.Apartments.Where(ap => ap.FloorId == FloorId).ToList();
        dgvApartments.Rows.Clear();
        foreach (var apartment in list)
        {
            object[] row = [apartment.Id, apartment.Number, apartment.NumberOfRooms, apartment.NumberOfBeds, apartment.PricePerNight];
            dgvApartments.Rows.Add(row);
        }
    }
}