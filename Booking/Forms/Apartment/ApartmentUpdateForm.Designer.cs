using System.ComponentModel;

namespace Booking.Forms.Apartment;

partial class ApartmentUpdateForm
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
        lblName = new Label();
        lblArrowName = new Label();
        txtName = new TextBox();
        lblNumberOfRooms = new Label();
        lblArrowNumberOfRooms = new Label();
        txtNumberOfRooms = new TextBox();
        lblNumberOfBeds = new Label();
        lblArrowNumberOfBeds = new Label();
        txtNumberOfBeds = new TextBox();
        lblPricePerNight = new Label();
        lblArrowPricePerNight = new Label();
        txtPricePerNight = new TextBox();
        btnConfirmUpdate = new Button();
        
        SuspendLayout();
        
        lblName.AutoSize = true;
        lblName.Location = new Point(10, 40);
        lblName.Name = "lblName";
        
        lblArrowName.AutoSize = true;
        lblArrowName.Location = new Point(10, 40);
        lblArrowName.Name = "lblArrowName";
        lblArrowName.Text = "\u2192";
        
        txtName.Location = new Point(10, 40);
        txtName.Size = new Size(250, 30);
        txtName.Name = "txtName";
        txtName.TabIndex = 0;
        
        
        lblNumberOfRooms.AutoSize = true;
        lblNumberOfRooms.Location = new Point(10, 80);
        lblNumberOfRooms.Name = "lblNumberOfRooms";
        
        lblArrowNumberOfRooms.AutoSize = true;
        lblArrowNumberOfRooms.Location = new Point(10, 80);
        lblArrowNumberOfRooms.Name = "lblArrowNumberOfRooms";
        lblArrowNumberOfRooms.Text = "\u2192";
        
        txtNumberOfRooms.Location = new Point(10, 80);
        txtNumberOfRooms.Size = new Size(250, 30);
        txtNumberOfRooms.Name = "txtNumberOfRooms";
        txtNumberOfRooms.TabIndex = 1;
        
        
        lblNumberOfBeds.AutoSize = true;
        lblNumberOfBeds.Location = new Point(10, 120);
        lblNumberOfBeds.Name = "lblNumberOfBeds";
        
        lblArrowNumberOfBeds.AutoSize = true;
        lblArrowNumberOfBeds.Location = new Point(10, 120);
        lblArrowNumberOfBeds.Name = "lblArrowNumberOfBeds";
        lblArrowNumberOfBeds.Text = "\u2192";
        
        txtNumberOfBeds.Location = new Point(10, 120);
        txtNumberOfBeds.Size = new Size(250, 30);
        txtNumberOfBeds.Name = "txtNumberOfBeds";
        txtNumberOfBeds.TabIndex = 2;
        
        
        lblPricePerNight.AutoSize = true;
        lblPricePerNight.Location = new Point(10, 160);
        lblPricePerNight.Name = "lblPricePerNight";
        
        lblArrowPricePerNight.AutoSize = true;
        lblArrowPricePerNight.Location = new Point(10, 160);
        lblArrowPricePerNight.Name = "lblArrowPricePerNight";
        lblArrowPricePerNight.Text = "\u2192";
        
        txtPricePerNight.Location = new Point(10, 160);
        txtPricePerNight.Size = new Size(250, 30);
        txtPricePerNight.Name = "txtPricePerNight";
        txtPricePerNight.TabIndex = 3;
        
        
        
        btnConfirmUpdate.Text = "Змінити";
        btnConfirmUpdate.Location = new Point(10, 230);
        btnConfirmUpdate.Size = new Size(780, 38);
        btnConfirmUpdate.Name = "btnConfirmUpdate";
        btnConfirmUpdate.Click += btnConfirmUpdate_Click;
        
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblName);
        Controls.Add(lblArrowName);
        Controls.Add(txtName);
        Controls.Add(lblNumberOfRooms);
        Controls.Add(lblArrowNumberOfRooms);
        Controls.Add(txtNumberOfRooms);
        Controls.Add(lblNumberOfBeds);
        Controls.Add(lblArrowNumberOfBeds);
        Controls.Add(txtNumberOfBeds);
        Controls.Add(lblPricePerNight);
        Controls.Add(lblArrowPricePerNight);
        Controls.Add(txtPricePerNight);
        Controls.Add(btnConfirmUpdate);
        Load += ApartmentUpdateForm_Load;
        Text = "ApartmentUpdateForm";
        
        ResumeLayout(true);
    }

    #endregion
    
    
    private Label lblName;
    private Label lblArrowName;
    private TextBox txtName;
    private Label lblNumberOfRooms;
    private Label lblArrowNumberOfRooms;
    private TextBox txtNumberOfRooms;
    private Label lblNumberOfBeds;
    private Label lblArrowNumberOfBeds;
    private TextBox txtNumberOfBeds;
    private Label lblPricePerNight;
    private Label lblArrowPricePerNight;
    private TextBox txtPricePerNight;
    private Button btnConfirmUpdate;
}