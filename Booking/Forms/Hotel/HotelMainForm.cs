using Booking.Forms.Apartment;
using Booking.Forms.Floor;
using Domain.Entities;
using Infrastructure.Data;

namespace Booking.Forms.Hotel;

public partial class HotelMainForm : Form
{
    ApplicationDbContext context = new();

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

    private void btnUpdateHotel_Click(object sender, EventArgs e)
    {
        HotelEntity? hotel = GetSelectedHotel();
        if (hotel == null)
        {
            MessageBox.Show("Виберіть рядок, який бажаєте змінити", "Увага");
            return;
        }

        HotelUpdateForm dlg = new() { PreviousHotel = hotel };

        if (dlg.ShowDialog() == DialogResult.OK)
        {
            UpdateHotelDgv();
        }
    }

    private void btnDeleteHotel_Click(object sender, EventArgs e)
    {
        HotelEntity? hotel = GetSelectedHotel();
        if (hotel == null)
        {
            MessageBox.Show("Виберіть рядок, який бажаєте видалити", "Увага");
            return;
        }

        MessageBox.Show("Успішно видалено готель", "Повідомлення");

        context.Hotels.Remove(hotel);
        context.SaveChanges();

        UpdateHotelDgv();
    }

    private void HotelMainForm_Load(object sender, EventArgs e)
    {
        UpdateHotelDgv();
    }

    private void UpdateHotelDgv()
    {
        var list = context.Hotels.ToList();
        dgvHotels.Rows.Clear();
        foreach (var hotel in list)
        {
            object[] row = [hotel.Id, hotel.Name, hotel.Address, hotel.Description];
            dgvHotels.Rows.Add(row);
        }
    }

    private HotelEntity? GetSelectedHotel()
    {
        var rowIndex = dgvHotels.CurrentCell.RowIndex;

        return context.Hotels.ToList()[rowIndex];
    }

    private void dgvHotels_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        if (e is { RowIndex: >= 0, ColumnIndex: >= 0 })
        {
            lvFloors.Items.Clear();
            int hotelId = (int)dgvHotels.Rows[e.RowIndex].Cells[0].Value;
            var floors = GetFloors(hotelId);
            foreach (var floor in floors)
            {
                ListViewItem lvFloorsItem = new ListViewItem();
                lvFloorsItem.Text = floor.Name;
                lvFloorsItem.Tag = floor.Id;
                lvFloors.Items.Add(lvFloorsItem);
            }
        }
    }

    private List<FloorEntity> GetFloors(int hotelId)
    {
        var list = context.Floors.Where(x => x.HotelId == hotelId).ToList();
        return list;
    }

    private void LoadFloors(int hotelId)
    {
        lvFloors.Items.Clear();
        using (ApplicationDbContext context = new ApplicationDbContext())
        {
            var floors = context.Floors.Where(x => x.HotelId == hotelId).ToList();
            foreach (var floor in floors)
            {
                ListViewItem lvFloorsItem = new ListViewItem();
                lvFloorsItem.Text = floor.Name;
                lvFloorsItem.Tag = floor.Id;
                lvFloors.Items.Add(lvFloorsItem);
            }
        }
    }

    private void btnAddFloor_Click(object sender, EventArgs e)
    {
        var hotel = GetSelectedHotel();

        if (hotel == null) return;

        int rowIndex = dgvHotels.CurrentCell.RowIndex;
        if (rowIndex >= 0)
        {
            FloorCreateForm dlg = new FloorCreateForm();
            dlg.hotel = hotel;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadFloors(hotel.Id);
            }
        }
    }
    
    private void lvFloors_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        // Get the item that was double-clicked
        ListViewItem item = lvFloors.SelectedItems.Count > 0 ? lvFloors.SelectedItems[0] : null;
        if (item != null)
        {
            ApartmentListForm dlg = new ();
            dlg.FloorId = (int)item.Tag;
            dlg.ShowDialog();

        }
    }
}