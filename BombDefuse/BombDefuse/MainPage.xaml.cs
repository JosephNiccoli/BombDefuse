using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BombDefuse
{
	public partial class MainPage : ContentPage
	{

		static string bomb = new Random().Next(1, 4).ToString();
		static int score = 0;

		public MainPage()
		{
			InitializeComponent();
		}
		// when the user clicks the button // buttonClicked is a method more specifically an event method
		async void ButtonClicked(object sender, EventArgs e) // event handler object sender contains the refrence to the button that was clicked and eventArgs contains the data asociated with the object
		{
			Button button = sender as Button; // cast as a button type

			// Game Over

			if (button.Text == bomb)
			{
				await DisplayAlert("Bomb Exploded", "GAME OVER!!!!!", "RETRY");
				bomb = new Random().Next(1, 4).ToString();
				score = 0;
			}
			else
			{
				score += 1;
				await DisplayAlert("Defused Bomb!!!", "Scores: " + score, "Continue");
				bomb = new Random().Next(1, 4).ToString();

			}
		}
	}
}
