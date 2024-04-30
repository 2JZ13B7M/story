namespace story;

public partial class choosecar : ContentPage
{
	public choosecar()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new mercedes());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new BMW());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new audi());
       
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new NewPage1());
    }
}