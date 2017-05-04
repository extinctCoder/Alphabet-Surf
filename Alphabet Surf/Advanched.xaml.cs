using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Alphabet_Surf
{
	/// <summary>
	/// Interaction logic for Advanched.xaml
	/// </summary>
	public partial class Advanched : UserControl
	{
		OpenFileDialog choofdlog;
		public Advanched()
		{
			InitializeComponent();
			choofdlog = new OpenFileDialog();
			choofdlog.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
			choofdlog.FilterIndex = 1;
			choofdlog.Multiselect = false;
		}

		private void il_pic_1_path_btn_Click(object sender, RoutedEventArgs e)
		{
			choofdlog.ShowDialog();
			this.il_pic_1_path_txt.Text = choofdlog.FileName;
		}

		private void il_pic_2_path_btn_Click(object sender, RoutedEventArgs e)
		{
			choofdlog.ShowDialog();
			this.il_pic_2_path_txt.Text = choofdlog.FileName;
		}

		private void il_insert_btn_Click(object sender, RoutedEventArgs e)
		{
			if (this.il_latter_txt.Text != "" && this.il_pic_1_path_txt.Text != "" && il_pic_2_path_txt.Text != "" && il_description_txt.Text != "" && (this.il_case_combobox.SelectedIndex == 0 || this.il_case_combobox.SelectedIndex == 1))
			{
				try
				{
					if (this.il_case_combobox.SelectedIndex == 0)
					{
						DatabaseConnector.Alphabet_Surf_db_DataInserter_alphabet_picture(this.il_latter_txt.Text.ToUpper(), "upperCase", il_pic_1_path_txt.Text, il_pic_2_path_txt.Text, il_description_txt.Text);
					}
					else if (this.il_case_combobox.SelectedIndex == 1)
					{
						DatabaseConnector.Alphabet_Surf_db_DataInserter_alphabet_picture(this.il_latter_txt.Text.ToUpper(), "lowerCase", il_pic_1_path_txt.Text, il_pic_2_path_txt.Text, il_description_txt.Text);
					}
					this.advanched_console.Content = "Alphabet successfully inserted ... !!!";
				}
				catch (Exception ex)
				{
					this.advanched_console.Content = ex.ToString();
				}
			}
			else
			{
				this.advanched_console.Content = "please input correct details ... :(";
			}
		}

		private void iw_insert_btn_Click(object sender, RoutedEventArgs e)
		{
			if (iw_word_txt.Text != "" && iw_short_description_txt.Text != "" && iw_long_description_txt.Text != "")
			{
				try
				{
					DatabaseConnector.Alphabet_Surf_db_DataInserter_wordbook(iw_word_txt.Text.ToString(), iw_short_description_txt.Text.ToString(), iw_long_description_txt.Text.ToString());
					this.advanched_console.Content = "Word successfully inserted ... !!!";
				}
				catch (Exception ex)
				{
					this.advanched_console.Content = ex.ToString();
				}
			}
			else
			{
				this.advanched_console.Content = "please input correct details ... :(";
			}
		}

		private void rl_search_btn_Click(object sender, RoutedEventArgs e)
		{
			if (this.rl_search_latter_txt.Text != "" && (this.rl_search_case_combobox.SelectedIndex == 0 || this.rl_search_case_combobox.SelectedIndex == 1))
			{
				if (this.rl_search_case_combobox.SelectedIndex == 0)
				{
					if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture(rl_search_latter_txt.Text, "upperCase"))
					{
						this.rl_latter_txt.Text = DatabaseConnector.Alphabet;
						this.rl_case_txt.Text = "Upper Case";
						this.rl_pic_1_path_txt.Text = DatabaseConnector.Pic_path_1;
						this.rl_pic_2_path_txt.Text = DatabaseConnector.Pic_path_2;
						this.rl_description_txt.Text = DatabaseConnector.Description;
						this.rl_search_btn.IsEnabled = false;
						this.rl_remove_btn.IsEnabled = true;
						this.advanched_console.Content = "Content is available in Database";
					}
					else
					{
						this.rl_remove_btn.IsEnabled = false;
						this.rl_search_btn.IsEnabled = true;
						this.advanched_console.Content = "Content is not available in Database";
					}
				}
				else if (this.rl_search_case_combobox.SelectedIndex == 1)
				{
					if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture(rl_search_latter_txt.Text, "lowerCase"))
					{
						this.rl_latter_txt.Text = DatabaseConnector.Alphabet;
						this.rl_case_txt.Text = "Lower Case";
						this.rl_pic_1_path_txt.Text = DatabaseConnector.Pic_path_1;
						this.rl_pic_2_path_txt.Text = DatabaseConnector.Pic_path_2;
						this.rl_description_txt.Text = DatabaseConnector.Description;
						this.rl_search_btn.IsEnabled = false;
						this.rl_remove_btn.IsEnabled = true;
						this.advanched_console.Content = "Content is available in Database";
					}
					else
					{
						this.rl_remove_btn.IsEnabled = false;
						this.rl_search_btn.IsEnabled = true; ;
						this.advanched_console.Content = "Content is not available in Database";
					}
				}
				else
				{
					this.rl_remove_btn.IsEnabled = false;
					this.rl_search_btn.IsEnabled = true;
					this.advanched_console.Content = "Content is not available in Database";
				}
			}
			else
			{
				this.advanched_console.Content = "please fill the details.";
			}
		}
		private void rl_remove_btn_Click(object sender, RoutedEventArgs e)
		{
			if (this.rl_search_case_combobox.SelectedIndex == 0)
			{
				if (DatabaseConnector.Alphabet_Surf_db_DataRemover_alphabet_picture(rl_search_latter_txt.Text.ToUpper(), "upperCase"))
				{
					this.advanched_console.Content = "data deleted.";
				}
				else
				{
					this.advanched_console.Content = "data is not deleted.";
				}
			}
			else if (this.rl_search_case_combobox.SelectedIndex == 1)
			{
				if (DatabaseConnector.Alphabet_Surf_db_DataRemover_alphabet_picture(rl_search_latter_txt.Text.ToLower(), "lowerCase"))
				{
					this.advanched_console.Content = "data deleted.";
				}
				else
				{
					this.advanched_console.Content = "data is not deleted.";
				}
			}
			this.rl_remove_btn.IsEnabled = false;
			this.rl_search_btn.IsEnabled = true;
		}
		private void rw_search_btn_Click(object sender, RoutedEventArgs e)
		{
			if (this.rw_search_txt.Text != "")
			{
				if (DatabaseConnector.Alphabet_Surf_db_DataReader_wordbook_word(this.rw_search_txt.Text))
				{
					this.rw_word_txt.Text = DatabaseConnector.Word;
					this.rw_short_description_txt.Text = DatabaseConnector.ShortDescription;
					this.rw_long_description_txt.Text = DatabaseConnector.LongDescription;
					this.rw_search_btn.IsEnabled = false;
					this.rw_remove_btn.IsEnabled = true;
					this.advanched_console.Content = "data is available.";
				}
				else
				{
					this.advanched_console.Content = "data is not available.";
				}
			}
			else
			{
				this.advanched_console.Content = "please insert the correct data.";
			}
		}
		private void rw_remove_btn_Click(object sender, RoutedEventArgs e)
		{
			if (DatabaseConnector.Alphabet_Surf_db_DataRemover_wordbook(this.rw_search_txt.Text.ToString()))
			{
				this.advanched_console.Content = "data deleted.";
			}
			else
			{
				this.advanched_console.Content = "data is not deleted.";
			}

			this.rw_search_btn.IsEnabled = true;
			this.rw_remove_btn.IsEnabled = false;
		}
	}
}
