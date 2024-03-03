using System.ComponentModel;

namespace Booking.Forms.Hotel;

partial class HotelUpdateForm
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
        lblAddress = new Label();
        lblArrowAddress = new Label();
        txtAddress = new TextBox();
        lblDescription = new Label();
        lblArrowDescription = new Label();
        txtDescription = new TextBox();
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
        
        lblAddress.AutoSize = true;
        lblAddress.Location = new Point(10, 80);
        lblAddress.Name = "lblAddress";
        
        lblArrowAddress.AutoSize = true;
        lblArrowAddress.Location = new Point(10, 80);
        lblArrowAddress.Name = "lblArrowAddress";
        lblArrowAddress.Text = "\u2192";
        
        txtAddress.Location = new Point(10, 80);
        txtAddress.Size = new Size(250, 30);
        txtAddress.Name = "txtAddress";
        txtAddress.TabIndex = 1;
        
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 120);
        lblDescription.Name = "lblDescription";
        
        lblArrowDescription.AutoSize = true;
        lblArrowDescription.Location = new Point(10, 120);
        lblArrowDescription.Name = "lblArrowDescription";
        lblArrowDescription.Text = "\u2192";
        
        txtDescription.Location = new Point(10, 120);
        txtDescription.Size = new Size(250, 90);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.TabIndex = 2;
        
        
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
        Controls.Add(lblAddress);
        Controls.Add(lblArrowAddress);
        Controls.Add(txtAddress);
        Controls.Add(lblDescription);
        Controls.Add(lblArrowDescription);
        Controls.Add(txtDescription);
        Controls.Add(btnConfirmUpdate);
        Load += HotelUpdateForm_Load;
        Text = "HotelUpdateForm";
        
        ResumeLayout(true);
    }

    #endregion

    private Label lblName;
    private Label lblArrowName;
    private TextBox txtName;
    private Label lblAddress;
    private Label lblArrowAddress;
    private TextBox txtAddress;
    private Label lblDescription;
    private Label lblArrowDescription;
    private TextBox txtDescription;
    private Button btnConfirmUpdate;
}