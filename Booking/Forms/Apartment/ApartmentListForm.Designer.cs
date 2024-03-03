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
        
        SuspendLayout();
        

        btnApartmentCreate.Location = new Point(470, 10);
        btnApartmentCreate.Size = new Size(120, 30);
        btnApartmentCreate.Name = "btnApartmentCreate";
        btnApartmentCreate.Text = "Додати номер";
        btnApartmentCreate.Click += btnApartmentCreate_Click;
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnApartmentCreate);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Margin = new Padding(4, 4, 4, 4);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Номери на поверсі";
        
        ResumeLayout(true);
    }

    #endregion

    private Button btnApartmentCreate;
}