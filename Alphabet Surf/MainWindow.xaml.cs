using System.Windows;
using System.Windows.Controls;

namespace Alphabet_Surf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		LearnAlphabets learnAlphabets = new LearnAlphabets();
		WordBook wordBook = new WordBook();
		Games games = new Games();
		Advanched advanched = new Advanched();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void learn_alphabets_btn_Click(object sender, RoutedEventArgs e)
		{
			this.primary_btn_set.Visibility = Visibility.Hidden;
			this.browser_container.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Visible;
			this.public_container.Children.Clear();
			this.public_container.Children.Add(learnAlphabets);
		}

		private void word_book_btn_Click(object sender, RoutedEventArgs e)
		{
			this.primary_btn_set.Visibility = Visibility.Hidden;
			this.browser_container.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Visible;
			this.public_container.Children.Clear();
			this.public_container.Children.Add(wordBook);
		}

		private void play_games_btn_Click(object sender, RoutedEventArgs e)
		{
			this.primary_btn_set.Visibility = Visibility.Hidden;
			this.browser_container.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Visible;
			this.public_container.Children.Clear();
			this.public_container.Children.Add(games);
		}

		private void advanched_btn_Click(object sender, RoutedEventArgs e)
		{
			this.primary_btn_set.Visibility = Visibility.Hidden;
			this.browser_container.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Visible;
			this.public_container.Children.Clear();
			this.public_container.Children.Add(advanched);
		}

		private void search_btn_Click(object sender, RoutedEventArgs e)
		{
			this.primary_btn_set.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Hidden;
			this.browser_container.Visibility = Visibility.Visible;
			this.web_browser.Address = address_bar.Text;
		}

		private void home_btn_Click(object sender, RoutedEventArgs e)
		{
			this.public_container.Children.Clear();
			this.primary_btn_set.Visibility = Visibility.Visible;
			this.browser_container.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Hidden;
		}

		private void address_bar_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.primary_btn_set.Visibility = Visibility.Hidden;
			this.public_container.Visibility = Visibility.Hidden;
			this.browser_container.Visibility = Visibility.Visible;
			this.web_browser.Address = address_bar.Text;
		}

	}
}
