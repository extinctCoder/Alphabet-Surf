using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Alphabet_Surf
{
	/// <summary>
	/// Interaction logic for Games.xaml
	/// </summary>
	public partial class Games : UserControl
	{
		int numberSequence = 0, placeSequence = 0, score = 0;
		String latterToFind;
		Random charSearcher = new Random();
		Random placeSearcher = new Random();
		char[] latters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
		public Games()
		{
			InitializeComponent();
			charSearcher = new Random();
			placeSearcher = new Random();
			randomSequenceGenerator();
			this.status_flag.Background = Brushes.LightGray;
		}
		private void randomSequenceGenerator()
		{
			this.numberSequence = this.charSearcher.Next(0, 23);
			this.placeSequence = this.placeSearcher.Next(0, 4);
			this.spaceFillerForRandomSequence();
		}
		private void spaceFillerForRandomSequence()
		{
			if (this.placeSequence == 0)
			{
				this.random_latter_1.Text = "-";
				this.latterToFind = latters[numberSequence + 0].ToString();
			}
			else
			{
				this.random_latter_1.Text = latters[numberSequence + 0].ToString();
			}
			if (this.placeSequence == 1)
			{
				this.random_latter_2.Text = "-";
				this.latterToFind = latters[numberSequence + 1].ToString();
			}
			else
			{
				this.random_latter_2.Text = latters[numberSequence + 1].ToString();
			}
			if (this.placeSequence == 2)
			{
				this.random_latter_3.Text = "-";
				this.latterToFind = latters[numberSequence + 2].ToString();
			}
			else
			{
				this.random_latter_3.Text = latters[numberSequence + 2].ToString();
			}
			if (this.placeSequence == 3)
			{
				this.random_latter_4.Text = "-";
				this.latterToFind = latters[numberSequence + 3].ToString();
			}
			else
			{
				this.random_latter_4.Text = latters[numberSequence + 3].ToString();
			}
		}

		private void play_again_btn_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			score = 0;
			randomSequenceGenerator();
			this.status_flag.Background = Brushes.LightGray;
			this.score_board_txt.Text = score.ToString();
		}

		private void next_buzzle_btn_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			score--;
			randomSequenceGenerator();
			this.status_flag.Background = Brushes.LightGray;
			this.score_board_txt.Text = score.ToString();
		}

		private void submit_answer_btn_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			try
			{
				if (this.latterToFind.Equals(this.submited_answer_txt.Text.ToUpper()))
				{
					score++;
					this.score_board_txt.Text = score.ToString();
					this.status_flag.Background = Brushes.Green;
					randomSequenceGenerator();
				}
				else
				{
					score--;
					this.score_board_txt.Text = score.ToString();
					this.status_flag.Background = Brushes.Red;
					randomSequenceGenerator();
				}
				this.submited_answer_txt.Text = String.Empty;
			}
			catch
			{
			}
		}
	}
}
