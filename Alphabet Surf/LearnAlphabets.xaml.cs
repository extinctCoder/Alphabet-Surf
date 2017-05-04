using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alphabet_Surf
{
	/// <summary>
	/// Interaction logic for LearnAlphabets.xaml
	/// </summary>
	public partial class LearnAlphabets : UserControl
	{
		public LearnAlphabets()
		{
			InitializeComponent();
		}

		private void filedDataRemover()
		{
			this.cl_alphabet_txt.Text = null;
			this.cl_pic_1.Source = null;
			this.cl_pic_2.Source = null;
			this.cl_alphabet_description.Text = null;
			this.sl_alphabet_txt.Text = null;
			this.sl_pic_1.Source = null;
			this.sl_pic_2.Source = null;
			this.sl_alphabet_description.Text = null;
		} 

		
	}
	public partial class LearnAlphabets
	{
		private void sl_z_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("z", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_y_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("y", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_x_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("x", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_w_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("w", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_v_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("v", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_u_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("u", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_t_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("t", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_s_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("s", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_r_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("r", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_q_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("q", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_p_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("p", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_o_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("o", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_n_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("n", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_m_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("m", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_l_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("l", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_k_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("k", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_j_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("j", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_i_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("i", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_h_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("h", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_g_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("g", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_f_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("f", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_e_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("e", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_d_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("d", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_c_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("c", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_b_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("b", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void sl_a_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("a", "lowerCase"))
			{
				this.sl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.sl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.sl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.sl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.sl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_z_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("Z", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_y_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("Y", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_x_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("X", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_w_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("W", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_v_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("V", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_u_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("U", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_t_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("T", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_s_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("S", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_r_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("R", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_q_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("Q", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_p_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("P", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_o_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("O", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_n_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("N", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_m_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("M", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_l_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("L", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_k_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("K", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_j_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("J", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_i_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("I", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_h_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("H", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_g_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("G", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_f_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("F", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_e_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("E", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_d_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("D", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_c_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("C", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_b_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("B", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}

		private void cl_a_Click(object sender, RoutedEventArgs e)
		{
			this.filedDataRemover();
			if (DatabaseConnector.Alphabet_Surf_db_DataReader_alphabet_picture("A", "upperCase"))
			{
				this.cl_alphabet_txt.Text = DatabaseConnector.Alphabet;
				this.cl_pic_1.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_1));
				this.cl_pic_2.Source = new BitmapImage(new Uri(DatabaseConnector.Pic_path_2));
				this.cl_alphabet_description.Text = DatabaseConnector.Description;
			}
			else
			{
				this.cl_alphabet_txt.Text = null;
				this.cl_alphabet_description.Text = "Content is not available in Database";
			}
		}
	}
}
