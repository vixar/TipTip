namespace TipTip;

public partial class MainPage : ContentPage
{
	int count = 0;
    public string Count { get; set; }

	public MainPage()
	{
		InitializeComponent();


    }

    private void splitEntry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void minusButton_Clicked(object sender, EventArgs e)
    {
        count = count > 0 ? count-1 : 0;
        splitEntry.Text = count.ToString();
    }

    private void plusButton_Clicked(object sender, EventArgs e)
    {
        count++;
        splitEntry.Text = count.ToString();
    }
}

