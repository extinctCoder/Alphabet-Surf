using System;
using System.Windows;
using System.Windows.Data;

namespace Alphabet_Surf
{
	public class TextInputToVisibilityConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			// Always test MultiValueConverter inputs for non-null 
			// (to avoid crash bugs for views in the designer) 
			if (values[0] is bool && values[1] is bool)
			{
				bool hasText = !(bool)values[0];
				bool hasFocus = (bool)values[1];
				if (hasFocus || hasText)
					return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	public class WordContainer
	{
		private string word;
		private string short_description;
		private string long_description;

		public string Word
		{
			set
			{
				this.word = value;
			}
			get
			{
				return this.word;
			}
		}

		public string Short_Description
		{
			set
			{
				this.short_description = value;
			}
			get
			{
				return this.short_description;
			}
		}

		public string Long_Description
		{
			set
			{
				this.long_description = value;
			}
			get
			{
				return this.long_description;
			}
		}

		public WordContainer()
		{
			this.word = "no data";
			this.short_description = "no data";
			this.long_description = "no data";
		}

		public WordContainer(string word, string short_description)
		{
			this.word = word;
			this.short_description = short_description;
			this.long_description = "no data";
		}

		public WordContainer(string word, string short_description, string long_description)
		{
			this.word = word;
			this.short_description = short_description;
			this.long_description = long_description;
		}
	}
	class ExtraClasses
	{

	}
}
