namespace Ascend;

public partial class CharacterPage : ContentPage
{
	public CharacterPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        StrengthLabel.Text = Manager.Strength.ToString();
        AgilityLabel.Text = Manager.Agility.ToString();
        DexterityLabel.Text = Manager.Dexterity.ToString();
        EnduranceLabel.Text = Manager.Endurance.ToString();
    }
}