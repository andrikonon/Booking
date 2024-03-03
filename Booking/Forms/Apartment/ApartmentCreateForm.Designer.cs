using System.ComponentModel;

namespace Booking.Forms.Apartment;

partial class ApartmentCreateForm
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
        lblRoomsNumber = new Label();
        txtRoomsNumber = new TextBox();
        lblBedsNumber = new Label();
        txtBedsNumber = new TextBox();
        lblPricePerNight = new Label();
        txtPricePerNight = new TextBox();
        btnCreate = new Button();
        btnAddImages = new Button();
        btnCancel = new Button();
        lvImages = new ListView();
        
        SuspendLayout();

        lblName.AutoSize = true;
        lblName.Location = new Point(10, 10);
        lblName.ForeColor = Color.DarkBlue;
        lblName.Name = "lblName";
        lblName.Text = "Номер кімнати";
        
        txtName.Location = new Point(10, 50);
        txtName.Size = new Size(180, 30);
        txtName.TabIndex = 0;

        lblRoomsNumber.AutoSize = true;
        lblRoomsNumber.Location = new Point(200, 10);
        lblRoomsNumber.ForeColor = Color.DarkBlue;
        lblRoomsNumber.Name = "lblRoomsNumber";
        lblRoomsNumber.Text = "Число кімнат";
        
        txtRoomsNumber.Location = new Point(200, 50);
        txtRoomsNumber.Size = new Size(180, 30);
        txtRoomsNumber.TabIndex = 1;

        lblBedsNumber.AutoSize = true;
        lblBedsNumber.Location = new Point(10, 100);
        lblBedsNumber.ForeColor = Color.DarkBlue;
        lblBedsNumber.Name = "lblBedsNumber";
        lblBedsNumber.Text = "Число спальних місць";
        
        txtBedsNumber.Location = new Point(10, 140);
        txtBedsNumber.Size = new Size(180, 30);
        txtBedsNumber.TabIndex = 2;

        lblPricePerNight.AutoSize = true;
        lblPricePerNight.Location = new Point(200, 100);
        lblPricePerNight.ForeColor = Color.DarkBlue;
        lblPricePerNight.Name = "lblPricePerNight";
        lblPricePerNight.Text = "Ціна за одну ніч";
        
        txtPricePerNight.Location = new Point(200, 140);
        txtPricePerNight.Size = new Size(180, 30);
        txtPricePerNight.TabIndex = 3;
        

        btnCreate.Location = new Point(470, 10);
        btnCreate.Size = new Size(120, 30);
        btnCreate.Name = "btnCreate";
        btnCreate.Text = "Створити";
        btnCreate.Click += btnCreate_Click;
        btnCreate.TabIndex = 5;

        btnAddImages.Location = new Point(470, 90);
        btnAddImages.Size = new Size(120, 30);
        btnAddImages.Name = "btnAddImages";
        btnAddImages.Text = "Додати фото";
        btnAddImages.Click += btnAddImages_Click;
        btnAddImages.TabIndex = 4;

        btnCancel.Location = new Point(470, 50);
        btnCancel.Size = new Size(120, 30);
        btnCancel.Name = "btnCancel";
        btnCancel.Text = "Скасувати";
        btnCancel.Click += btnCancel_Click;
        btnCancel.TabIndex = 6;


        lvImages.Location = new Point(10, 200);
        lvImages.Size = new Size(780, 240);
        lvImages.Name = "lvImages";
        lvImages.UseCompatibleStateImageBehavior = false;
        lvImages.ItemDrag += lvImages_ItemDrag;
        lvImages.DragDrop += lvImages_DragDrop;
        lvImages.DragEnter += lvImages_DragEnter;
        lvImages.DragOver += lvImages_DragOver;
        lvImages.DragLeave += lvImages_DragLeave;
        
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(lblRoomsNumber);
        Controls.Add(txtRoomsNumber);
        Controls.Add(lblBedsNumber);
        Controls.Add(txtBedsNumber);
        Controls.Add(lblPricePerNight);
        Controls.Add(txtPricePerNight);
        Controls.Add(btnCreate);
        Controls.Add(btnAddImages);
        Controls.Add(btnCancel);
        Controls.Add(lvImages);
        Text = "Додати номер до готелю";
        StartPosition = FormStartPosition.CenterParent;
        ResumeLayout(true);
    }

    #endregion
    
    private Label lblName;
    private TextBox txtName;
    private Label lblRoomsNumber;
    private TextBox txtRoomsNumber;
    private Label lblBedsNumber;
    private TextBox txtBedsNumber;
    private Label lblPricePerNight;
    private TextBox txtPricePerNight;
    private Button btnCreate;
    private Button btnAddImages;
    private Button btnCancel;
    private ListView lvImages;
}