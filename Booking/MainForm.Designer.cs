namespace Booking;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnCreate = new Button();
        mHead = new MenuStrip();
        mHead_File = new ToolStripMenuItem();
        mHead_File_Exit = new ToolStripMenuItem();
        mHead_Options = new ToolStripMenuItem();
        mHead_Options_FillDb = new ToolStripMenuItem();
        mHead_Operations = new ToolStripMenuItem();
        mHead_Operations_CategoryTree = new ToolStripMenuItem();
        
        mHead.SuspendLayout();
        SuspendLayout();

        btnCreate.Text = "Готелі...";
        btnCreate.Location = new Point(10, 53);
        btnCreate.Size = new Size(120, 38);
        btnCreate.Name = "btnCreate";
        btnCreate.Click += btnCreate_Click;


        mHead.Name = "mHead";
        mHead.Items.AddRange(new ToolStripItem[]
        {
            mHead_File, 
            mHead_Operations,
            mHead_Options, 
        });
        
        
        mHead_File.DropDownItems.AddRange(new[] {mHead_File_Exit});
        mHead_File.Name = "mHead_File";
        mHead_File.Text = "Файл";

        mHead_File_Exit.Name = "mHead_File_Exit";
        mHead_File_Exit.Text = "Вихід";
        mHead_File_Exit.ShortcutKeys = Keys.Control | Keys.Q;
        mHead_File_Exit.Click += (_, _) => Close();

        
        mHead_Options.DropDownItems.AddRange(new[] { mHead_Options_FillDb });
        mHead_Options.Name = "mHead_Options";
        mHead_Options.Text = "Налаштування";
        
        mHead_Options_FillDb.Name = "mHead_Options_FillDb";
        mHead_Options_FillDb.Text = "Заповнити БД";
        mHead_Options_FillDb.Click += mHead_Options_FillDb_Click;


        mHead_Operations.DropDownItems.AddRange(new[] { mHead_Operations_CategoryTree });
        mHead_Operations.Name = "mHead_Operations";
        mHead_Operations.Text = "Операції";

        mHead_Operations_CategoryTree.Name = "mHead_Operations_CategoryTree";
        mHead_Operations_CategoryTree.Text = "Категорії";
        mHead_Operations_CategoryTree.Click += mHead_Operations_CategoryTree_Click;
        
        
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnCreate);
        Controls.Add(mHead);
        MainMenuStrip = mHead;
        Margin = new Padding(4);
        Text = "MainForm";
        
        mHead.ResumeLayout(true);
        ResumeLayout(true);
    }

    #endregion

    private Button btnCreate;
    private MenuStrip mHead;
    private ToolStripMenuItem mHead_File;
    private ToolStripMenuItem mHead_File_Exit;
    private ToolStripMenuItem mHead_Options;
    private ToolStripMenuItem mHead_Options_FillDb;
    private ToolStripMenuItem mHead_Operations;
    private ToolStripMenuItem mHead_Operations_CategoryTree;
    
}