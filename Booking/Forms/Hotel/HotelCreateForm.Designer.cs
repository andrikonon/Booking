using System.ComponentModel;
using Point = System.Drawing.Point;

namespace Booking.Forms.Hotel;

partial class HotelCreateForm
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
        txtName = new TextBox();
        lblAddress = new Label();
        txtAddress = new TextBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        btnCreate = new Button();
        btnCancel = new Button();
        
        SuspendLayout();

        lblName.AutoSize = true;
        lblName.Location = new Point(10, 10);
        lblName.ForeColor = Color.DarkBlue;
        lblName.Name = "lblName";
        lblName.Text = "Назва";
        
        txtName.Location = new Point(10, 50);
        txtName.Size = new Size(450, 30);
        txtName.TabIndex = 0;

        lblAddress.AutoSize = true;
        lblAddress.Location = new Point(10, 90);
        lblAddress.ForeColor = Color.DarkBlue;
        lblAddress.Name = "lblAddress";
        lblAddress.Text = "Адреса";
        
        txtAddress.Location = new Point(10, 130);
        txtAddress.Size = new Size(450, 30);
        txtAddress.TabIndex = 1;

        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 170);
        lblDescription.ForeColor = Color.DarkBlue;
        lblDescription.Name = "lblDescription";
        lblDescription.Text = "Опис";
        
        
        txtDescription.Location = new Point(10, 210);
        txtDescription.Size = new Size(450, 120);
        txtDescription.Multiline = true;
        txtDescription.TabIndex = 2;

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
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(lblAddress);
        Controls.Add(txtAddress);
        Controls.Add(lblDescription);
        Controls.Add(txtDescription);
        Controls.Add(btnCreate);
        Controls.Add(btnCancel);
        Font = new Font("Segoe UI", 12.0f, GraphicsUnit.Point);
        Text = "HotelCreateForm";
        StartPosition = FormStartPosition.CenterParent;
        ResumeLayout(true);
    }

    #endregion

    private Label lblName;
    private TextBox txtName;
    private Label lblAddress;
    private TextBox txtAddress;
    private Label lblDescription;
    private TextBox txtDescription;
    private Button btnCreate;
    private Button btnCancel;
}