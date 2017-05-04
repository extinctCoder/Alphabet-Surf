using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Alphabet_Surf
{
	public partial class DatabaseConnector
	{
		private SQLiteConnection alphabet_Surf_db_connector;
		public static DatabaseConnector dbConnector;
		private string alphabet, upperOrLower, pic_path_1, pic_path_2, description, word, shortDescription, longDescription;
		private List<WordContainer> wordbook;

		public static event EventHandler wordbookWordAddEvent;

		public static DatabaseConnector DatabaseConnectorHandler()
		{
			if (dbConnector == null)
			{
				dbConnector = new DatabaseConnector();
			}
			return dbConnector;
		}
		public DatabaseConnector()
		{
			this.alphabet_Surf_db_connector = new SQLiteConnection("Data Source=Alphabet_Surf_DB.sqlite;Version=3;");
		}

		public static string Alphabet
		{
			get
			{
				return dbConnector.alphabet;
			}
		}
		public static string UpperOrLower
		{
			get
			{
				return dbConnector.upperOrLower;
			}
		}
		public static string Pic_path_1
		{
			get
			{
				return dbConnector.pic_path_1;
			}
		}
		public static string Pic_path_2
		{
			get
			{
				return dbConnector.pic_path_2;
			}
		}
		public static string Description
		{
			get
			{
				return dbConnector.description;
			}
		}
		public static string Word
		{
			get
			{
				return dbConnector.word;
			}
		}
		public static string ShortDescription
		{
			get
			{
				return dbConnector.shortDescription;
			}
		}
		public static string LongDescription
		{
			get
			{
				return dbConnector.longDescription;
			}
		}
		public static List<WordContainer> WordBook
		{
			get
			{
				return dbConnector.wordbook;
			}
		}
		public static void Alphabet_Surf_db_Initializar()
		{
			SQLiteConnection.CreateFile("Alphabet_Surf_DB.sqlite");
			DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
			SQLiteCommand command_alphabet_picture = new SQLiteCommand("create table alphabet_picture (alphabet varchar(5), upperOrLower varchar(10), pic_path_1 varchar(100), pic_path_2 varchar(1000), description varchar(2000))", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
			command_alphabet_picture.ExecuteNonQuery();
			SQLiteCommand command_wordbook = new SQLiteCommand("create table wordbook (word varchar(5), short_description varchar(2000), long_description varchar(4000))", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
			command_wordbook.ExecuteNonQuery();
			DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
		}
	}
	public partial class DatabaseConnector
	{
		public static void Alphabet_Surf_db_DataInserter_alphabet_picture(string alphabet, string upperOrLower, String pic_path_1, String pic_path_2, String description)
		{
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("insert into alphabet_picture (alphabet, upperOrLower, pic_path_1, pic_path_2, description) values ('" + alphabet.ToString() + "', '" + upperOrLower.ToString() + "', '" + pic_path_1.ToString() + "', '" + pic_path_2.ToString() + "', '" + description.ToString() + "')", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				command.ExecuteNonQuery();
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}

		}
		public static bool Alphabet_Surf_db_DataReader_alphabet_picture(String alphabet, String upperOrLower)
		{
			bool readerFlag = false;
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'alphabet_picture' WHERE alphabet LIKE '" + alphabet.ToString() + "' AND upperOrLower LIKE '" + upperOrLower.ToString() + "'", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				SQLiteDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
					dbConnector.alphabet = dataReader["alphabet"].ToString();
					dbConnector.upperOrLower = dataReader["upperOrLower"].ToString();
					dbConnector.pic_path_1 = dataReader["pic_path_1"].ToString();
					dbConnector.pic_path_2 = dataReader["pic_path_2"].ToString();
					dbConnector.description = dataReader["description"].ToString();
					readerFlag = true;
				}
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				return readerFlag;
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}
		}
		public static bool Alphabet_Surf_db_DataRemover_alphabet_picture(String alphabet, String upperOrLower)
		{
			bool readerFlag = false;
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("DELETE FROM 'alphabet_picture' WHERE alphabet LIKE '" + alphabet.ToString() + "' AND upperOrLower LIKE '" + upperOrLower.ToString() + "'", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				command.ExecuteNonQuery();
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				readerFlag = true;
				return readerFlag;
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}
		}
	}
	public partial class DatabaseConnector
	{
		public static void Alphabet_Surf_db_DataReader_wordbook()
		{
			DatabaseConnector.DatabaseConnectorHandler().wordbook = null;
			if (DatabaseConnector.DatabaseConnectorHandler().wordbook == null)
			{
				DatabaseConnector.DatabaseConnectorHandler().wordbook = new List<WordContainer>();
			}
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'wordbook'", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				SQLiteDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
					DatabaseConnector.DatabaseConnectorHandler().wordbook.Add(new WordContainer(dataReader["word"].ToString(), dataReader["short_description"].ToString(), dataReader["long_description"].ToString()));
				}
				//if (readerFlag == false)
				//{
				//	DatabaseConnector.DatabaseConnectorHandler().wordbook.RemoveAt(DatabaseConnector.DatabaseConnectorHandler().wordbook.Count - 1);
				//}
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}
		}
		public static bool Alphabet_Surf_db_DataReader_wordbook_word(string word)
		{
			bool readerFlag = false;
			DatabaseConnector.DatabaseConnectorHandler().wordbook = null;
			if (DatabaseConnector.DatabaseConnectorHandler().wordbook == null)
			{
				DatabaseConnector.DatabaseConnectorHandler().wordbook = new List<WordContainer>();
			}
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'wordbook' WHERE word LIKE '" + word.ToString() + "'", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				SQLiteDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
					dbConnector.word = dataReader["word"].ToString();
					dbConnector.shortDescription = dataReader["short_description"].ToString();
					dbConnector.longDescription = dataReader["long_description"].ToString();
					readerFlag = true;
				}
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				return readerFlag;
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}
		}
		public static void Alphabet_Surf_db_DataInserter_wordbook(string word, string shortDescription, string longDescription)
		{
			if (DatabaseConnector.DatabaseConnectorHandler().wordbook == null)
			{
				DatabaseConnector.DatabaseConnectorHandler().wordbook = new List<WordContainer>();
			}
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("insert into wordbook (word, short_description, long_description) values ('" + word.ToString() + "', '" + shortDescription.ToString() + "', '" + longDescription.ToString() + "')", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				command.ExecuteNonQuery();
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				if (DatabaseConnector.wordbookWordAddEvent != null)
				{
					DatabaseConnector.wordbookWordAddEvent(new object(), new EventArgs());
				}
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}
		}
		public static bool Alphabet_Surf_db_DataRemover_wordbook(string word)
		{
			bool readerFlag = false;
			looper:
			try
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Open();
				SQLiteCommand command = new SQLiteCommand("DELETE FROM 'wordbook' WHERE word LIKE '" + word.ToString() + "'", DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector);
				command.ExecuteNonQuery();
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				readerFlag = true;
				return readerFlag;
			}
			catch
			{
				DatabaseConnector.DatabaseConnectorHandler().alphabet_Surf_db_connector.Close();
				DatabaseConnector.Alphabet_Surf_db_Initializar();
				goto looper;
			}
		}
	}
}
