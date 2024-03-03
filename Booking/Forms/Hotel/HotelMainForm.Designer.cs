using System.ComponentModel;
using System.Data;

namespace Booking.Forms.Hotel;

partial class HotelMainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbl1 = new Label();
        btnCreateHotel = new Button();
        btnUpdateHotel = new Button();
        btnDeleteHotel = new Button();
        dgvHotels = new DataGridView();
        lvFloors = new ListView();
        btnAddFloor = new Button();
        
        ((System.ComponentModel.ISupportInitialize)dgvHotels).BeginInit();
        SuspendLayout();

        lbl1.Text = "Список готелів";
        lbl1.AutoSize = true;
        lbl1.Location = new Point(400 - lbl1.ClientSize.Width / 2, 20);
        lbl1.Name = "lbl1";

        
        btnCreateHotel.Text = "Додати";
        btnCreateHotel.Location = new Point(10, 60);
        btnCreateHotel.Size = new Size(120, 38);
        btnCreateHotel.Name = "btnCreateHotel";
        btnCreateHotel.Click += btnCreateHotel_Click;
        btnCreateHotel.TabIndex = 0;
        
        
        btnUpdateHotel.Text = "Змінити";
        btnUpdateHotel.Location = new Point(140, 60);
        btnUpdateHotel.Size = new Size(120, 38);
        btnUpdateHotel.Name = "btnUpdateHotel";
        btnUpdateHotel.Click += btnUpdateHotel_Click;
        btnUpdateHotel.TabIndex = 1;
        
        
        btnDeleteHotel.Text = "Видалити";
        btnDeleteHotel.Location = new Point(270, 60);
        btnDeleteHotel.Size = new Size(120, 38);
        btnDeleteHotel.Name = "btnDeleteHotel";
        btnDeleteHotel.Click += btnDeleteHotel_Click;
        btnDeleteHotel.TabIndex = 2;
        
        
        dgvHotels.AllowUserToAddRows = false;
        dgvHotels.AllowUserToDeleteRows = false;
        dgvHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHotels.Size = new Size(780, 330);
        dgvHotels.Location = new Point(10, 110);
        dgvHotels.ReadOnly = true;
        dgvHotels.CellEnter += dgvHotels_CellEnter;
        dgvHotels.Columns.Add("colId", "Id");
        dgvHotels.Columns.Add("colName", "Назва");
        dgvHotels.Columns.Add("colAddress", "Адреса");
        dgvHotels.Columns.Add("colDescription", "Опис");
        dgvHotels.TabIndex = 3;
        
        
        lvFloors.Location = new Point(800, 110);
        lvFloors.Name = "lvFloors";
        lvFloors.Size = new Size(420, 330);
        lvFloors.TabIndex = 5;
        lvFloors.UseCompatibleStateImageBehavior = false;
        lvFloors.View = View.List;
        
        
        btnAddFloor.Location = new Point(800, 60);
        btnAddFloor.Name = "btnAddFloor";
        btnAddFloor.Size = new Size(420, 38);
        btnAddFloor.TabIndex = 4;
        btnAddFloor.Text = "Додати поверх";
        btnAddFloor.UseVisualStyleBackColor = true;
        btnAddFloor.Click += btnAddFloor_Click;
        
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new Size(1300, 490);
        MinimumSize = MaximumSize = ClientSize;
        Controls.Add(lbl1);
        Controls.Add(btnCreateHotel);
        Controls.Add(btnUpdateHotel);
        Controls.Add(btnDeleteHotel);
        Controls.Add(dgvHotels);
        Controls.Add(btnAddFloor);
        Controls.Add(lvFloors);
        Load += HotelMainForm_Load;
        Text = "HotelMainForm";
        
        ((System.ComponentModel.ISupportInitialize)dgvHotels).EndInit();
        ResumeLayout(true);
    }

    #endregion

    private Label lbl1;
    private Button btnCreateHotel;
    private Button btnUpdateHotel;
    private Button btnDeleteHotel;
    private DataGridView dgvHotels;
    private ListView lvFloors;
    private Button btnAddFloor;
}