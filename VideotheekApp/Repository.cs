using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace VideotheekApp
{
    public class Repository
    {
        private static Repository DeRepository;
        public FilmLijst Films { get; set; }
        public LidLijst Leden { get; set; }

        LedenDataClassDataContext ledenContext = new LedenDataClassDataContext();



        private string connectionString;
        /* = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Matthias\\OneDrive - Erasmushogeschool Brussel\\Documenten\\EHB\\2021-2022\\.net advanced\\oefeningen" +
            "\\VideotheekApp\\VideotheekApp\\FilmDatabase.mdf\";Integrated Security = True";*/

        public Repository()
        {
            DeRepository = null;
            Films = new FilmLijst();
            Leden = new LidLijst();

            var appDataPath = (string)AppDomain.CurrentDomain.GetData("DataDirectory");
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + appDataPath +
                   "FilmDatabase.mdf;Integrated Security=True";
        }

        public static Repository GetInstance()
        {
            if(DeRepository == null)
            {
                DeRepository = new Repository();
            }

            return DeRepository;
        }

        public void InitialiseDataFromDB()
        {
            LeesFilms();
            LeesLeden();
        }

        public void LeesFilms()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand filmCommand = new SqlCommand("SELECT * FROM Films",connection);
            connection.Open();

            SqlDataReader reader = filmCommand.ExecuteReader();

            int idIndex = reader.GetOrdinal("Id");
            int titleIndex = reader.GetOrdinal("Title");
            int regiseurIndex = reader.GetOrdinal("Regiseur");
            int acteurIndex = reader.GetOrdinal("Acteurs");
            int genreIndex = reader.GetOrdinal("Genre");
            int prijsIndex = reader.GetOrdinal("Prijs");
            int reviewIndex = reader.GetOrdinal("Review");
            int ARIndex = reader.GetOrdinal("AdultRating");
            int posterIndex = reader.GetOrdinal("Poster");
            int ratedIndex = reader.GetOrdinal("Rated");
            int runtimeIndex = reader.GetOrdinal("Runtime");
            int plotIndex = reader.GetOrdinal("Plot");

            while (reader.Read())
            {
                Film f = new Film();
                f.Id = reader.GetInt32(idIndex);
                f.Title = reader.GetString(titleIndex);
                f.Regiseur = reader.GetString(regiseurIndex);
                f.Acteurs = reader.GetString(acteurIndex);
                f.Genre = reader.GetString(genreIndex);
                f.Prijs = (float)reader.GetDouble(prijsIndex);
                f.Review = reader.GetString(reviewIndex);
                f.AdultRating = reader.GetBoolean(ARIndex);
                if (!reader.IsDBNull(posterIndex))
                {
                    f.Poster = reader.GetString(posterIndex);
                }
                if (!reader.IsDBNull(ratedIndex))
                {
                    f.Rated = reader.GetString(ratedIndex);
                }
                if (!reader.IsDBNull(runtimeIndex))
                {
                    f.Runtime = reader.GetString(runtimeIndex);
                }
                if (!reader.IsDBNull(plotIndex))
                {
                    f.Plot = reader.GetString(plotIndex);
                }

                Films.Add(f);
            }

            reader.Close();

            connection.Close();
        }

        public String SlaFilmOpInDatabase(Film f)
        {
            String returnMessage = "";
            SqlConnection connection = new SqlConnection(connectionString);
            
            try
            {
                connection.Open();

                SqlTransaction updateTransactie = connection.BeginTransaction();

                SqlCommand filmCommand = new SqlCommand("UPDATE Films SET Title=@Title, Regiseur=@Reg,Acteurs=@Act,Genre=@Genre,Prijs=@Prijs,Review=@Review,AdultRating=@Ar,Poster=@Poster,Rated=@Rated,Runtime=@Runtime,Plot=@Plot WHERE Id=@FilmId", connection);
                filmCommand.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Title"].Value = f.Title;
                filmCommand.Parameters.Add("@Reg", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Reg"].Value = f.Regiseur;
                filmCommand.Parameters.Add("@Act", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Act"].Value = f.Acteurs;
                filmCommand.Parameters.Add("@Genre", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Genre"].Value = f.Genre;
                filmCommand.Parameters.Add("@Prijs", System.Data.SqlDbType.Float);
                filmCommand.Parameters["@Prijs"].Value = f.Prijs;
                filmCommand.Parameters.Add("@Review", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Review"].Value = f.Review;
                filmCommand.Parameters.Add("@Ar", System.Data.SqlDbType.Bit);
                filmCommand.Parameters["@Ar"].Value = f.AdultRating;
                filmCommand.Parameters.Add("@FilmId", System.Data.SqlDbType.Int);
                filmCommand.Parameters["@FilmId"].Value = f.Id;
                filmCommand.Parameters.Add("@Poster", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Poster"].Value = (f.Poster == null) ? "" : f.Poster;
                filmCommand.Parameters.Add("@Rated", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Rated"].Value = (f.Rated == null) ? "" : f.Rated;
                filmCommand.Parameters.Add("@Runtime", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Runtime"].Value = (f.Runtime == null) ? "" : f.Runtime;
                filmCommand.Parameters.Add("@Plot", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Plot"].Value = (f.Plot == null) ? "" : f.Plot;

                filmCommand.Transaction = updateTransactie;

                int affected = filmCommand.ExecuteNonQuery();

                updateTransactie.Commit();
            }
            catch(SqlException e)
            {
                returnMessage = e.Message;
            }

            connection.Close();

            return returnMessage;
        }

        public int GetNewFilmId()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand commando = new SqlCommand("SELECT NEXT VALUE FOR SequenceFilmId", connection);

            connection.Open();

            SqlDataReader reader = commando.ExecuteReader();
            reader.Read();

            long nieuweFilmId = reader.GetInt64(0);

            reader.Close();
            connection.Close();

            return (int)nieuweFilmId;
        }

        public String InsertNieuweFilmInDatabase(Film f)
        {
            String returnMessage = "";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlTransaction updateTransactie = connection.BeginTransaction();

                SqlCommand filmCommand = new SqlCommand("INSERT INTO Films(Id,Title,Regiseur,Acteurs,Genre,Prijs,Review,AdultRating,Poster,Rated,Runtime,Plot) VALUES(@Id,@Title,@Reg,@Act,@Genre,@Prijs,@Review,@Ar,@Poster,@Rated,@Runtime,@Plot)", connection);
                filmCommand.Parameters.Add("@Id", System.Data.SqlDbType.Int);
                filmCommand.Parameters["@Id"].Value = f.Id;
                filmCommand.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Title"].Value = f.Title;
                filmCommand.Parameters.Add("@Reg", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Reg"].Value = f.Regiseur;
                filmCommand.Parameters.Add("@Act", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Act"].Value = f.Acteurs;
                filmCommand.Parameters.Add("@Genre", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Genre"].Value = f.Genre;
                filmCommand.Parameters.Add("@Prijs", System.Data.SqlDbType.Float);
                filmCommand.Parameters["@Prijs"].Value = f.Prijs;
                filmCommand.Parameters.Add("@Review", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Review"].Value = f.Review;
                filmCommand.Parameters.Add("@Ar", System.Data.SqlDbType.Bit);
                filmCommand.Parameters["@Ar"].Value = f.AdultRating;
                filmCommand.Parameters.Add("@FilmId", System.Data.SqlDbType.Int);
                filmCommand.Parameters["@FilmId"].Value = f.Id;
                filmCommand.Parameters.Add("@Poster", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Poster"].Value = (f.Poster == null)? "" : f.Poster;
                filmCommand.Parameters.Add("@Rated", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Rated"].Value = (f.Rated == null) ? "" : f.Rated;
                filmCommand.Parameters.Add("@Runtime", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Runtime"].Value = (f.Runtime == null) ? "" : f.Runtime;
                filmCommand.Parameters.Add("@Plot", System.Data.SqlDbType.NVarChar);
                filmCommand.Parameters["@Plot"].Value = (f.Plot == null) ? "" : f.Plot;

                filmCommand.Transaction = updateTransactie;

                int affected = filmCommand.ExecuteNonQuery();

                updateTransactie.Commit();
            }
            catch (SqlException e)
            {
                returnMessage = e.Message;
            }

            connection.Close();

            return returnMessage;
        }

        public String DeleteFilmFromDatabase(Film f)
        {
            String returnMessage = "";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlTransaction updateTransactie = connection.BeginTransaction();

                SqlCommand filmCommand = new SqlCommand("DELETE FROM Films WHERE Id=@FilmId", connection);
                filmCommand.Parameters.Add("@FilmId", System.Data.SqlDbType.Int);
                filmCommand.Parameters["@FilmId"].Value = f.Id;

                filmCommand.Transaction = updateTransactie;

                int affected = filmCommand.ExecuteNonQuery();

                updateTransactie.Commit();

                Films.Remove(f);
            }
            catch (SqlException e)
            {
                returnMessage = e.Message;
            }

            connection.Close();

            return returnMessage;
        }

        public int GetNewLidId()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand commando = new SqlCommand("SELECT NEXT VALUE FOR SequenceFilmId", connection);

            connection.Open();

            SqlDataReader reader = commando.ExecuteReader();
            reader.Read();

            long nieuwLidId = reader.GetInt64(0);

            reader.Close();
            connection.Close();

            return (int)nieuwLidId;
        }

        public String LeesLeden()
        {
            string errorMessage = "";

            LedenDataClassDataContext context = new LedenDataClassDataContext();

            
            

            return errorMessage;
        }

    }
}
