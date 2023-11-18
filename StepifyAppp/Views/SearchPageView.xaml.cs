using Newtonsoft.Json.Linq;
using StepifyAppp.Api;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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

namespace StepifyAppp.Views
{
    /// <summary>
    /// Interaction logic for SearchPageView.xaml
    /// </summary>
    public partial class SearchPageView : Page
    {
        public SearchPageView()
        {
            InitializeComponent();
            
        }
        private const string SpotifyApiBaseUrl = "https://api.spotify.com/v1/search";
        private const string ClientId = "bcb74730584f4e51b4081d1eb26caf94"; 
        private const string ClientSecret = "0ad43ada4f3a4047bb45ca463487723b"; 


 


        private async Task<string> GetAccessToken()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}"))}");

                var content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");
                var response = await client.PostAsync("https://accounts.spotify.com/api/token", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(responseContent);
                    return json["access_token"].ToString();
                }
                else
                {
                    MessageBox.Show($"Access token retrieval failed. Response: {await response.Content.ReadAsStringAsync()}");
                    return null;
                }
            }
        }

        private async Task<string> MakeRequest(string apiUrl, string accessToken)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show("API request failed.");
                    return null;
                }
            }
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = searchTextBox.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string accessToken = await GetAccessToken();

                if (!string.IsNullOrEmpty(accessToken))
                {
                    string apiUrl = $"{SpotifyApiBaseUrl}?q={searchTerm}&type=track";
                    string result = await MakeRequest(apiUrl, accessToken);

                    if (!string.IsNullOrEmpty(result))
                    {
                        var tracks = ParseTracks(result);

                        resultListBox.ItemsSource = tracks;
                    }
                }
            }
        }
        public List<Track> tr = new List<Track>();
        private List<Track> ParseTracks(string result)

        {
            var tracks = new List<Track>();

            var json = JObject.Parse(result);

            foreach (var item in json["tracks"]["items"])
            {
                string name = item["name"].ToString();
                string artist = item["artists"][0]["name"].ToString();
                string album = item["album"]["name"].ToString();
                string imageUrl = item["album"]["images"][0]["url"].ToString();
                string previewUrl = item["preview_url"]?.ToString();

               
                long milliseconds = Convert.ToInt64(item["duration_ms"]);
                TimeSpan durationTimeSpan = TimeSpan.FromMilliseconds(milliseconds);
                string duration = $"{(int)durationTimeSpan.TotalMinutes}:{durationTimeSpan.Seconds:D2}";

              
                
                    tracks.Add(new Track( name, artist, album, imageUrl,  previewUrl, duration));
                
            }

            tr = tracks;
            return tracks;
        }

  




        private async void changed(object sender, TextChangedEventArgs e)
        {
            string searchTerm = searchTextBox.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string accessToken = await GetAccessToken();

                if (!string.IsNullOrEmpty(accessToken))
                {
                    string apiUrl = $"{SpotifyApiBaseUrl}?q={searchTerm}&type=track";
                    string result = await MakeRequest(apiUrl, accessToken);

                    if (!string.IsNullOrEmpty(result))
                    {
                        var tracks = ParseTracks(result);

                        resultListBox.ItemsSource = tracks;
                    }
                }
            }
        }

        private void savePlaylist(object sender, RoutedEventArgs e)
        {

        }
    }
}
