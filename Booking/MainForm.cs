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
        this.Enabled = false;
        using ApplicationDbContext applicationDbContext = new();
        if (applicationDbContext.Categories.Count() == 0)
        {
            CategoryEntity categoryTeplaPidloha = new()
            {
                Name = "Тепла підлога",
                Description =
                    "Тепла підлога Comfort Heat - система електричного підігріву поверхні підлоги до комфортної температури.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/products/slideshow_home/img_6521-375x375.jpg",
                    "categories"),
                SiblingPriority = 1,
            };

            applicationDbContext.Categories.Add(categoryTeplaPidloha);
            applicationDbContext.SaveChanges();

            #region Дочірні категорії Теплої підлоги

            CategoryEntity categoryPidlohaPidPlytku = new()
            {
                Name = "Тепла підлога під плитку",
                Description =
                    "Тепла підлога під плитку - один з найпопулярніших видів комфортного підігріву поверхні підлоги.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/el_tepliy_pol_2_375_375-375x375.jpg",
                    "categories"),
                SiblingPriority = 1,
                ParentId = categoryTeplaPidloha.Id,
            };
            CategoryEntity categoryVStiazhku = new()
            {
                Name = "Тепла підлога в стяжку",
                Description =
                    " Тепла підлога в стяжку - один з видів комфортного підігріву поверхні підлоги, при якому нагрівальний елемент (кабель) встановлюється в шар цементно-піщаної стяжки.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/elektricheskij-teplyj-pol-nagrevatelnyj-kabel-nagrevatelnyj-mat-i_31768_1_375_375-375x375.jpg",
                    "categories"),
                SiblingPriority = 2,
                ParentId = categoryTeplaPidloha.Id,
            };
            CategoryEntity categoryPidLaminat = new()
            {
                Name = "Тепла підлога під ламінат",
                Description =
                    " Тепла підлога під ламінат - порівняно нова система підігріву поверхні підлоги з дерев'яними покриттями (ламінат, паркет, пробка і т.п.).",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/tepliy-pol-pod-laminat-375_375-375x375.jpg",
                    "categories"),
                SiblingPriority = 3,
                ParentId = categoryTeplaPidloha.Id,
            };
            applicationDbContext.Categories.AddRange(
                [categoryPidlohaPidPlytku, categoryVStiazhku, categoryPidLaminat]);

            #endregion

            CategoryEntity categoryOpalennia = new()
            {
                Name = "Опалення",
                Description =
                    "Повне електричне опалення через конструкцію підлоги - популярний вид обігріву будь-яких приміщень.",
                SiblingPriority = 2,
            };
            applicationDbContext.Categories.Add(categoryOpalennia);
            applicationDbContext.SaveChanges();

            #region Дочірні категорії опалення

            CategoryEntity categoryConvectors = new()
            {
                Name = "Конвектори Airelec",
                Description =
                    "Електричні конвектори компанії Airelec (Франція) - швидке і ефективне рішення для основного або допоміжного опалення приміщень будь-якого типу.",
                SiblingPriority = 1,
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/airelec/airelec-375x375.jpg", "categories"),
                ParentId = categoryOpalennia.Id,
            };

            CategoryEntity categoryNerukhomist = new()
            {
                Name = "Нерухомість",
                Description =
                    "а допомогою нагрівальних кабелів і матів Comfort Heat можна ефективно реалізувати систему повного опалення будь-якої комерційної нерухомості (магазинів, офісів, салонів, кафе, ресторанів, заправок та інше).",
                SiblingPriority = 2,
                ParentId = categoryOpalennia.Id,
            };

            CategoryEntity categoryPrymishchennia = new()
            {
                Name = "Опалення житлових приміщень",
                Description =
                    "Електричний кабельний обігрів приміщень - один з варіантів вирішення питання опалення Вашого будинку або квартири.",
                SiblingPriority = 3,
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/otoplenie_375_375-375x375.jpg",
                    "categories"),
                ParentId = categoryOpalennia.Id,
            };
            applicationDbContext.Categories.AddRange(
                [categoryConvectors, categoryNerukhomist, categoryPrymishchennia]);

            #endregion

            CategoryEntity categoryVulychniSystemy = new()
            {
                Name = "Вуличні системи захисту від снігу та льоду",
                Description =
                    "У зимовий період мороз, сніг і лід може наробити чимало неприємностей. Всі дорожні елементи стають слизькими і непристосованими для безпечного пересування пішоходів і транспорту.",
                SiblingPriority = 3,
            };
            applicationDbContext.Categories.Add(categoryVulychniSystemy);
            applicationDbContext.SaveChanges();

            #region Дочірні категорії вуличних систем

            CategoryEntity categorySnihotanennia = new()
            {
                Name = "Сніготанення вуличних майданчиків",
                Description =
                    "Система сніготанення призначена для захисту від намерзання снігу і льоду на зовнішніх майданчиках (сходах, тротуарах, доріжках, терасах, пандусах, рампах та інше) для забезпечення безпечного проходу людей і проїзду транспорту.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/snegotayka_375_375-375x375.jpg", "categories"),
                SiblingPriority = 1,
                ParentId = categoryVulychniSystemy.Id,
            };

            CategoryEntity categoryObihrivVodostoku = new()
            {
                Name = "Обігрів водостічної системи",
                Description =
                    "Обігрів водостічної системи - електрична кабельна система захисту від замерзання елементів покрівлі, жолобів і водостоків, основним завданням якої є забезпечення стоку талої води з даху на землю або в дренажний колодязь.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/antiled_375_375-375x375.jpg", "categories"),
                SiblingPriority = 2,
                ParentId = categoryVulychniSystemy.Id,
            };
            CategoryEntity categoryZakhystTrub = new()
            {
                Name = "Захист труб від замерзання",
                Description = "",
                SiblingPriority = 3,
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/truby_375_375-375x375.jpg", "categories"),
                ParentId = categoryVulychniSystemy.Id,
            };
            applicationDbContext.AddRange(
                [categorySnihotanennia, categoryObihrivVodostoku, categoryZakhystTrub]);

            #endregion

            CategoryEntity categoryTekhnolohichnyiObihriv = new()
            {
                Name = "Технологічний обігрів",
                Description =
                    "Електричний нагрівальний кабель Comfort Heat, окрім традиційних систем \"Тепла підлога\", використовується для реалізації спеціальних систем обігріву: захист від промерзання фундаментів морозильних камер, обігрів грунту в теплицях, вольєрів для тварин та спортивних газонів.",
                SiblingPriority = 4,
            };
            applicationDbContext.Categories.Add(categoryTekhnolohichnyiObihriv);
            applicationDbContext.SaveChanges();

            #region Дочірні категорії технологічного обігріву

            CategoryEntity categoryMorozylniKamery = new()
            {
                Name = "Захист від промерзання фундаментів морозильних камер",
                Description =
                    "Промислові морозильні камери, в яких температура повітря постійно знаходиться в діапазоні -20\u00b0C...- 30\u00b0C піддаються великому ризику промерзання грунту під їх фундаментами, що може призвести до значних збитків.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/obogrev_pola_moroz_kameri375_375-375x375.jpg", "categories"),
                SiblingPriority = 1,
                ParentId = categoryTekhnolohichnyiObihriv.Id,
            };
            CategoryEntity categoryObihrivGruntuVTeplytsiakh = new()
            {
                Name = "Обігрів грунту в теплицях",
                Description =
                    "Ні для кого не секрет, що практично все живе любить тепло, включаючи рослини. Найпоширеніший спосіб захисту флори від холоду - це облаштування класичних теплиць, які сприяють продовженню сезону для росту рослин і збору врожаю. Але так як кожен хоче поліпшити свої результати, досвідчені флористи не зупинилися на досягнутому і продовжили шукати технічні рішення для модернізації свого бізнесу чи улюбленної справи.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/teplica_375_375-375x375.jpg", "categories"),
                SiblingPriority = 2,
                ParentId = categoryTekhnolohichnyiObihriv.Id,
            };
            CategoryEntity categoryOpalenniaVolieriv = new()
            {
                Name = "Опалення вольєрів для тварин",
                Description =
                    "Сучасні ферми і вольєри для тварин це не тільки огорожа і годівниця, а повністю автоматизовані приміщення з комфортними умовами. Адже все просто - чим комфортніші умови у тварин, тим краще їх зростання і приріст.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/ferma_375_375-375x375.jpg", "categories"),
                SiblingPriority = 3,
                ParentId = categoryTekhnolohichnyiObihriv.Id,
            };
            CategoryEntity categoryObihrivSportyvnykhHazoniv = new()
            {
                Name = "Обігрів спортивних газонів",
                Description =
                    "Натуральні спортивні газони, на яких проводяться європейські та міжнародні заходи повинні дотримуватися ряду вимог відповідних федерацій, одним з яких може бути жорстко визначений період експлуатації.",
                Image = ImageWorker.ImageSaveUrl(
                    "https://comfortheat.kiev.ua/image/cache/catalog/comfortheat/categories/gazon_375_375-375x375.jpg", "categories"),
                SiblingPriority = 4,
                ParentId = categoryTekhnolohichnyiObihriv.Id,
            };


            applicationDbContext.Categories.AddRange([
                categoryMorozylniKamery, categoryObihrivGruntuVTeplytsiakh, categoryOpalenniaVolieriv,
                categoryObihrivSportyvnykhHazoniv
            ]);

            #endregion

            applicationDbContext.SaveChanges();

            MessageBox.Show("Успішно заповнено дані", "Інформація");
        }
        this.Enabled = true;
    }

    private void mHead_Operations_CategoryTree_Click(object sender, EventArgs e)
    {
        CategoryListForm dlg = new();
        dlg.ShowDialog();
    }
}