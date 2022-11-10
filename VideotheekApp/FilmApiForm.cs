using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotheekApp
{
    public partial class FilmApiForm : Form
    {
        FilmApiSearchResultList resultFilSet = new FilmApiSearchResultList();
        public FilmApiSearchResult selectedFilm = null;

        public FilmApiForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbZoekWaarde.Text == "")
            {
                MessageBox.Show("Je moet iets ingeven als zoekwaarde", "Error");
                return;
            }

            // Roep api aan om zoeklijst te krijgen van films

            string URL = "http://www.omdbapi.com/";
            string urlParameters = "?s=" + tbZoekWaarde.Text + "&apikey=28deb1f4";
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                /*var dataObjects = response.Content.ReadAsAsync<IEnumerable<FilmApiSearchResult>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}", d.Name);
                }*/
                String jsonString = response.Content.ReadAsStringAsync().Result;
                resultFilSet = JsonSerializer.Deserialize<FilmApiSearchResultList>(jsonString);
                //textBox1.Text = resultFilSet.; //Make sure to add a reference to System.Net.Http.Formatting.dll
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();


            lbMovies.Items.Clear();

            for(int i = 0; i < resultFilSet.Search.Count; i++)
            {
                lbMovies.Items.Add(resultFilSet.Search[i].Title + "    (" + resultFilSet.Search[i].Year + ")");
            }
            
        }

        private void lbMovies_DoubleClick(object sender, EventArgs e)
        {
            int selectedMovieIndex = lbMovies.SelectedIndex;
            FilmApiSearchResult film = resultFilSet.Search[selectedMovieIndex];


            // Ophalen van film detail via imdbID
            string URL = "http://www.omdbapi.com/";
            string urlParameters = "?i=" + film.imdbID + "&apikey=28deb1f4";
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                /*var dataObjects = response.Content.ReadAsAsync<IEnumerable<FilmApiSearchResult>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}", d.Name);
                }*/
                String jsonString = response.Content.ReadAsStringAsync().Result;
                selectedFilm = JsonSerializer.Deserialize<FilmApiSearchResult>(jsonString);
                //textBox1.Text = resultFilSet.; //Make sure to add a reference to System.Net.Http.Formatting.dll
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
