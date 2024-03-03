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
        dgvHotels = new DataGridView();
        
        SuspendLayout();

        lbl1.Text = "Список готелів";
        lbl1.AutoSize = true;
        lbl1.Location = new Point(400 - lbl1.ClientSize.Width / 2, 40);
        lbl1.Name = "lbl1";

        
        btnCreateHotel.Text = "Додати";
        btnCreateHotel.Location = new Point(10, 70);
        btnCreateHotel.Size = new Size(120, 38);
        btnCreateHotel.Name = "btnCreate";
        btnCreateHotel.Click += btnCreateHotel_Click;

        dgvHotels.Size = new Size(780, 330);
        dgvHotels.Location = new Point(10, 110);
        dgvHotels.Columns.Add("colId", "Id");
        dgvHotels.Columns.Add("colName", "Назва");
        dgvHotels.Columns.Add("colAddress", "Адреса");
        dgvHotels.Columns.Add("colDescription", "Опис");
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lbl1);
        Controls.Add(btnCreateHotel);
        Controls.Add(dgvHotels);
        Load += HotelMainForm_Load;
        Text = "HotelMainForm";
        ResumeLayout(true);
    }

    #endregion

    private Label lbl1;
    private Button btnCreateHotel;
    private DataGridView dgvHotels;
}