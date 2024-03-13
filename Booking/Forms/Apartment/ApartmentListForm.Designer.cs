using System.ComponentModel;

namespace Booking.Forms.Apartment;

partial class ApartmentListForm
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
        btnApartmentCreate = new Button();
        btnApartmentUpdate = new Button();
        dgvApartments = new DataGridView();
        lbl1 = new Label();
        lblPricePerNight1 = new Label();
        txtPricePerNightMin = new NumericUpDown();
        lblPricePerNight2 = new Label();
        txtPricePerNightMax = new NumericUpDown();
        lblNumberOfBeds1 = new Label();
        txtNumberOfBedsMin = new NumericUpDown();
        lblNumberOfBeds2 = new Label();
        txtNumberOfBedsMax = new NumericUpDown();
        lblNumberOfRooms1 = new Label();
        txtNumberOfRoomsMin = new NumericUpDown();
        lblNumberOfRooms2 = new Label();
        txtNumberOfRoomsMax = new NumericUpDown();
        btnSearch = new Button();
        
        SuspendLayout();
        

        btnApartmentCreate.Location = new Point(470, 10);
        btnApartmentCreate.Size = new Size(120, 30);
        btnApartmentCreate.Name = "btnApartmentCreate";
        btnApartmentCreate.Text = "Додати номер";
        btnApartmentCreate.Click += btnApartmentCreate_Click;
        btnApartmentCreate.TabIndex = 10;
        

        btnApartmentUpdate.Location = new Point(470, 60);
        btnApartmentUpdate.Size = new Size(120, 30);
        btnApartmentUpdate.Name = "btnApartmentUpdate";
        btnApartmentUpdate.Text = "Оновити дані про номер";
        btnApartmentUpdate.Click += btnApartmentUpdate_Click;
        btnApartmentUpdate.TabIndex = 11;
        
        
        dgvApartments.AllowUserToAddRows = false;
        dgvApartments.AllowUserToDeleteRows = false;
        dgvApartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvApartments.Size = new Size(780, 280);
        dgvApartments.Location = new Point(10, 160);
        dgvApartments.ReadOnly = true;
        dgvApartments.CellEnter += dgvApartments_CellEnter;
        dgvApartments.Columns.Add("colId", "Id");
        dgvApartments.Columns.Add("colName", "Назва");
        dgvApartments.Columns.Add("colNumberOfRooms", "Число кімнат");
        dgvApartments.Columns.Add("colNumberOfBeds", "Число спальних місць");
        dgvApartments.Columns.Add("colPricePerNight", "Ціна за 1 ніч");
        dgvApartments.TabIndex = 15;

        int filterLeftEdge = 20;
        
        lbl1.Text = "Фільтри пошуку:";
        lbl1.AutoSize = true;
        lbl1.Location = new Point(filterLeftEdge, 20);
        lbl1.Name = "lbl1";
        
        
        lblPricePerNight1.Text = "Ціна за 1 ніч:";
        lblPricePerNight1.AutoSize = true;
        lblPricePerNight1.Location = new Point(filterLeftEdge, 60);
        lblPricePerNight1.Name = "lblPricePerNight1";
        
                
        lblNumberOfBeds1.Text = "Число спальних місць:";
        lblNumberOfBeds1.AutoSize = true;
        lblNumberOfBeds1.Location = new Point(filterLeftEdge, 90);
        lblNumberOfBeds1.Name = "lblNumberOfBeds1";
        
                
        lblNumberOfRooms1.Text = "Число кімнат:";
        lblNumberOfRooms1.AutoSize = true;
        lblNumberOfRooms1.Location = new Point(filterLeftEdge, 120);
        lblNumberOfRooms1.Name = "lblNumberOfRooms1";
            
            
        txtPricePerNightMin.Location = new Point(100, 60);
        txtPricePerNightMin.Size = new Size(80, 30);
        txtPricePerNightMin.TabIndex = 1;
        txtPricePerNightMin.Maximum = 500000;
        txtPricePerNightMin.Minimum = 0;
        txtPricePerNightMin.Increment = 1;
        
        
            
        txtNumberOfBedsMin.Location = new Point(100, 90);
        txtNumberOfBedsMin.Size = new Size(80, 30);
        txtNumberOfBedsMin.TabIndex = 3;
        txtNumberOfBedsMin.Maximum = 255;
        txtNumberOfBedsMin.Minimum = 0;
        txtNumberOfBedsMin.Increment = 1;
        
            
        txtNumberOfRoomsMin.Location = new Point(100, 120);
        txtNumberOfRoomsMin.Size = new Size(80, 30);
        txtNumberOfRoomsMin.TabIndex = 5;
        txtNumberOfRoomsMin.Maximum = 255;
        txtNumberOfRoomsMin.Minimum = 0;
        txtNumberOfRoomsMin.Increment = 1;
        
        
        lblPricePerNight2.Text = "до: ";
        lblPricePerNight2.AutoSize = true;
        lblPricePerNight2.Location = new Point(100, 60);
        lblPricePerNight2.Name = "lblPricePerNight2";
        
                
        lblNumberOfBeds2.Text = "до: ";
        lblNumberOfBeds2.AutoSize = true;
        lblNumberOfBeds2.Location = new Point(100, 90);
        lblNumberOfBeds2.Name = "lblNumberOfBeds2";
        
                
        lblNumberOfRooms2.Text = "до: ";
        lblNumberOfRooms2.AutoSize = true;
        lblNumberOfRooms2.Location = new Point(100, 120);
        lblNumberOfRooms2.Name = "lblNumberOfRooms2";
        
            
        txtPricePerNightMax.Location = new Point(100, 60);
        txtPricePerNightMax.Size = new Size(80, 30);
        txtPricePerNightMax.TabIndex = 2;
        txtPricePerNightMax.Maximum = 500000;
        txtPricePerNightMax.Minimum = 0;
        txtPricePerNightMax.Increment = 100;
        
            
        txtNumberOfBedsMax.Location = new Point(100, 90);
        txtNumberOfBedsMax.Size = new Size(80, 30);
        txtNumberOfBedsMax.TabIndex = 4;
        txtNumberOfBedsMax.Maximum = 255;
        txtNumberOfBedsMax.Minimum = 0;
        txtNumberOfBedsMax.Increment = 1;
        
            
        txtNumberOfRoomsMax.Location = new Point(100, 120);
        txtNumberOfRoomsMax.Size = new Size(80, 30);
        txtNumberOfRoomsMax.TabIndex = 6;
        txtNumberOfRoomsMax.Maximum = 255;
        txtNumberOfRoomsMax.Minimum = 0;
        txtNumberOfRoomsMax.Increment = 1;
        
        
        btnSearch.Location = new Point(100, 60);
        btnSearch.Size = new Size(120, 90);
        btnSearch.Name = "btnSearch";
        btnSearch.Text = "Пошук";
        btnSearch.Click += btnSearch_Click;
        btnSearch.TabIndex = 7;
        
        
        
        
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnApartmentCreate);
        Controls.Add(btnApartmentUpdate);
        Controls.Add(dgvApartments);
        Controls.Add(lbl1);
        Controls.Add(lblPricePerNight1);
        Controls.Add(txtPricePerNightMin);
        Controls.Add(lblPricePerNight2);
        Controls.Add(txtPricePerNightMax);
        Controls.Add(lblNumberOfBeds1);
        Controls.Add(txtNumberOfBedsMin);
        Controls.Add(lblNumberOfBeds2);
        Controls.Add(txtNumberOfBedsMax);
        Controls.Add(lblNumberOfRooms1);
        Controls.Add(txtNumberOfRoomsMin);
        Controls.Add(lblNumberOfRooms2);
        Controls.Add(txtNumberOfRoomsMax);
        Controls.Add(btnSearch);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Margin = new Padding(4, 4, 4, 4);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Номери на поверсі";
        
        ResumeLayout(true);
    }

    #endregion

    private Button btnApartmentCreate;
    private Button btnApartmentUpdate;
    private DataGridView dgvApartments;
    private Label lbl1;
    private Label lblPricePerNight1;
    private NumericUpDown txtPricePerNightMin;
    private Label lblPricePerNight2;
    private NumericUpDown txtPricePerNightMax;
    private Label lblNumberOfBeds1;
    private NumericUpDown txtNumberOfBedsMin;
    private Label lblNumberOfBeds2;
    private NumericUpDown txtNumberOfBedsMax;
    private Label lblNumberOfRooms1;
    private NumericUpDown txtNumberOfRoomsMin;
    private Label lblNumberOfRooms2;
    private NumericUpDown txtNumberOfRoomsMax;
    private Button btnSearch;
}