namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		/*count++;
		CounterLabel.Text = $"Kamu sudah klik ini sebanyak {count}x";

		SemanticScreenReader.Announce(CounterLabel.Text);*/

		label.IsVisible = true;
	}

    private void BtnClicked(object sender, EventArgs e)
    {
		if (label.IsVisible == true)
		{
			btn.Text = "Munculkan tulisan";
			label.IsVisible = false;
		}
		else
		{
			btn.Text = "Hilangkan tulisan";
			label.IsVisible = true;
		}
	}

    private void Tambah(object sender, EventArgs e)
    {
		count++;
		hasil.Text = $"{count}";
		hasil.FontSize = 24;
	}

    private void Kurang(object sender, EventArgs e)
    {
		if(count <= 0)
        {
			hasil.Text = "Angka tidak boleh kurang dari 0!";
			hasil.FontSize = 10;
        }
        else
        {
			count--;
			hasil.Text = $"{count}";
			hasil.FontSize = 24;
		}
		
	}
}

