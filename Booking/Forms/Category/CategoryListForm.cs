using Domain.Entities;
using Helpers;
using Infrastructure.Data;

namespace Booking.Forms.Category;

public partial class CategoryListForm : Form
{
    public CategoryListForm()
    {
        InitializeComponent();
        tvCategory.ImageList = new ImageList();
    }

    private void CategoryListForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        tvCategory.Nodes.Clear();

        tvCategory.ImageList = new ImageList();
        tvCategory.ImageList.ImageSize = new Size(tvCategory.ItemHeight, tvCategory.ItemHeight);
        using ApplicationDbContext context = new();

        var items = context.Categories.Where(cat => cat.ParentId == null).ToList();
        
        foreach (var item in items)
        {
            var id = item.Id.ToString();
            var imageName = item.Image ?? "default.webp";
            var folder = item.Image == null ? "default" : "categories";
            var dir = Path.Combine(Directory.GetCurrentDirectory(), "images", folder);
            var imagePath = Path.Combine(dir, "600_" + imageName);
            tvCategory.ImageList.Images.Add(id, Image.FromStream(ImageWorker.GetFileStream(imagePath)));

            TreeNode node = new(item.Name)
            {
                Tag = item,
                ImageKey = id,
                
                SelectedImageKey = id,
            };
            node.Nodes.Add("");
            tvCategory.Nodes.Add(node);

        }
    }

    private void tvCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        var hitTest = e.Node.TreeView.HitTest(e.Location);
        if (hitTest.Location != TreeViewHitTestLocations.PlusMinus)
            return;
        if (!e.Node.IsExpanded)
            return;
        var parent = e.Node.Tag as CategoryEntity;
        e.Node.Nodes.Clear();
        using ApplicationDbContext context = new();
        var list = context.Categories.Where(cat => cat.ParentId == parent.Id).ToList();
        if (list.Any())
        {
            foreach (var child in list)
            {
                var id = child.Id.ToString();
                var imageName = child.Image ?? "default.webp";
                var folder = child.Image == null ? "default" : "categories";
                var dir = Path.Combine(Directory.GetCurrentDirectory(), "images", folder);
                var imagePath = Path.Combine(dir, "600_" + imageName);
                tvCategory.ImageList.Images.Add(id, Image.FromStream(ImageWorker.GetFileStream(imagePath)));

                TreeNode node = new(child.Name)
                {
                    Tag = child,
                    ImageKey = id,
                
                    SelectedImageKey = id,
                };
                node.Nodes.Add("");
                e.Node.Nodes.Add(node);
            }
        }
    }
}