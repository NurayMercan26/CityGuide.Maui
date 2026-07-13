using CityGuide.Maui.Services;

namespace CityGuide.Maui.Views;

public partial class CulturePage : ContentPage
{
    private readonly AppDatabase _db = new AppDatabase();
	public CulturePage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Servisi çaðýr -> InitAsync tetiklenir -> tablolar oluþur
        var categories = await _db.GetCategoriesAsync();
        var events = await _db.GetEventsAsync();

        StatusLabel.Text =
            $"{categories.Count} kategori, {events.Count} etkinlik bulundu.";
    }

}