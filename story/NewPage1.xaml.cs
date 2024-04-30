namespace story;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new choosecar());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        DisplayAlert("ALERT", "MADE BY JASXXN", "exit");
    }
}