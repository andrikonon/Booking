using Booking.Forms.Category;
using Booking.Forms.Hotel;
using Domain.Entities;
using Helpers;
using Infrastructure.Data;

namespace Booking;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        HotelMainForm dlg = new();
        dlg.ShowDialog();
    }

    private void mHead_Options_FillDb_Click(object sender, EventArgs e)
    {
        using ApplicationDbContext applicationDbContext = new();
        if (applicationDbContext.Categories.Count() == 0)
        {
            CategoryEntity categoryTeplaPidloha = new()
            {
                Description = "Опис теплої підлоги",
                Name = "Тепла підлога",
                Image = ImageWorker.ImageSaveUrl("https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/products/slideshow_home/img_6521-375x375.jpg", "categories"),
                SiblingPriority = 1,
            };
            applicationDbContext.Categories.Add(categoryTeplaPidloha);
            applicationDbContext.SaveChanges();
            
            CategoryEntity categoryOpalennia = new()
            {
                Description = "Опис опалення",
                Name = "Опалення",
                SiblingPriority = 2,
            };
            applicationDbContext.Categories.Add(categoryOpalennia);
            applicationDbContext.SaveChanges();
            
            #region Дочірня категорія опалення
            CategoryEntity categoryConvectors = new()
            {
                Name = "Конвектори",
                Description = "Опис конвекторів",
                SiblingPriority = 1,
                Image = ImageWorker.ImageSaveUrl("https://comfortheat.kiev.ua/image/cache/catalog/airelec/airelec-375x375.jpg","categories"),
                ParentId = categoryOpalennia.Id,
            };
            applicationDbContext.Categories.Add(categoryConvectors);
            applicationDbContext.SaveChanges();
            #endregion
            
            #region Дочірня категорія опалення
            CategoryEntity categoryNerukhomist = new()
            {
                Name = "Нерухомість",
                Description = "Опис нерухомостей",
                SiblingPriority = 2,
                ParentId = categoryOpalennia.Id,
            };
            applicationDbContext.Categories.Add(categoryNerukhomist);
            applicationDbContext.SaveChanges();
            #endregion
            
            #region Дочірня категорія опалення
            CategoryEntity categoryPrymishchennia = new()
            {
                Name = "Опалення житлових приміщень",
                Description = "Опис опалення житлових приміщень",
                SiblingPriority = 3,
                Image = ImageWorker.ImageSaveUrl("https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/otoplenie_375_375-375x375.jpg", "categories"),
                ParentId = categoryOpalennia.Id,
            };
            applicationDbContext.Categories.Add(categoryPrymishchennia);
            applicationDbContext.SaveChanges();
            #endregion
        }
    }

    private void mHead_Operations_CategoryTree_Click(object sender, EventArgs e)
    {
        CategoryListForm dlg = new();
        dlg.ShowDialog();
    }
}