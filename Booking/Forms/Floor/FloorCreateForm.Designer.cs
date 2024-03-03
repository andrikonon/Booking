using System.ComponentModel;

namespace Booking.Forms.Floor;

partial class FloorCreateForm
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
        lblHotelName = new Label();
        lblName = new Label();
        txtName = new TextBox();
        btnCreate = new Button();
        btnCancel = new Button();
        
        SuspendLayout();
        
        lblHotelName.AutoSize = true;
        lblHotelName.Location = new Point(10, 100);
        lblHotelName.ForeColor = Color.DarkBlue;
        lblHotelName.Name = "lblHotelName";
        lblHotelName.Text = "Назва готелю";
        
        lblName.AutoSize = true;
        lblName.Location = new Point(10, 10);
        lblName.ForeColor = Color.DarkBlue;
        lblName.Name = "lblName";
        lblName.Text = "Назва поверху";
        
        txtName.Location = new Point(10, 50);
        txtName.Size = new Size(450, 30);
        txtName.TabIndex = 0;

        btnCreate.Location = new Point(470, 10);
        btnCreate.Size = new Size(120, 30);
        btnCreate.Name = "btnCreate";
        btnCreate.Text = "Створити";
        btnCreate.Click += btnCreate_Click;

        btnCancel.Location = new Point(470, 50);
        btnCancel.Size = new Size(120, 30);
        btnCancel.Name = "btnCancel";
        btnCancel.Text = "Скасувати";
        btnCancel.Click += btnCancel_Click;
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblName);
        Controls.Add(lblHotelName);
        Controls.Add(txtName);
        Controls.Add(btnCreate);
        Controls.Add(btnCancel);
        Load += FloorCreateForm_Load;
        Text = "FloorCreateForm";
        ResumeLayout(true);
    }

    #endregion
    
    private Label lblName;
    private Label lblHotelName;
    private TextBox txtName;
    private Button btnCreate;
    private Button btnCancel;
    
}