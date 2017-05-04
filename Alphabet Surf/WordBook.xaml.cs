using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Alphabet_Surf
{
	/// <summary>
	/// Interaction logic for WordBook.xaml
	/// </summary>
	public partial class WordBook : UserControl
	{
		private ICollectionView SearchedDataGrid;

		private List<WordContainer> wordbook = new List<WordContainer>();
		public WordBook()
		{
			InitializeComponent();
			DatabaseConnector.wordbookWordAddEvent += new EventHandler(DatabaseConnector_wordbookWordAddEvent);
			this.WordBookLoader();
		}

		private void DatabaseConnector_wordbookWordAddEvent(object sender, EventArgs e)
		{
			this.WordBookLoader();
		}

		public void WordBookLoader()
		{
			DatabaseConnector.Alphabet_Surf_db_DataReader_wordbook();
			this.wordbook_grid.ItemsSource = DatabaseConnector.WordBook;
			this.SearchedDataGrid = CollectionViewSource.GetDefaultView(DatabaseConnector.WordBook);

		}
		private void UserControl_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			this.word_search_txt.Focusable = true;
		}
		private void word_search_txt_TextChanged(object sender, TextChangedEventArgs e)
		{
			SearchedDataGrid.Filter = FilterData;
			this.wordbook_grid.ItemsSource = SearchedDataGrid;
		}


		private bool FilterData(object item)
		{
			var searchValue = (WordContainer)item;
			if ((searchValue == null || searchValue.Word == null))
				return false;
			return searchValue.Word.ToLower().StartsWith(this.word_search_txt.Text.ToLower());
		}

		private void reload_db_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			WordBookLoader();
		}
	}
}
