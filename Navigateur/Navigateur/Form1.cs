using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace Navigateur
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// URL du moteur de recherche
        /// </summary>
        public static String url = "http://www.google.fr/search?q=";
        
        /// <summary>
        /// URL de l'API de google MAP
        /// </summary>
        public static String urlGoogleMap = "http://maps.google.com/?q=";
        
        /// <summary>
        /// URL du tweeter de MIAGE connection
        /// </summary>
        public static String urlTwitter = "https://fr.twitter.com/MIAGEConnection";
        
        /// <summary>
        /// URL de ma page perso VIADEO
        /// </summary>
        public static String urlTarik = "http://fr.viadeo.com/fr/profile/djebien.tarik";
        
        /// <summary>
        /// Compte de test associe au tweeter du laboratoire de recherche en informatique.
        /// </summary>
        public static String accountTest = "Inria";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTwitterAccount.Text = accountTest;
        }

        /// <summary>
        /// Action pour le moteur de recherche du navigateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            webBrowser.Navigate(url+textBoxSearch.Text);
        }

        /// <summary>
        /// Action pour quitter le navigateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Action pour retourner sur la page d'acceuil du navigateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }
        
        /// <summary>
        /// Action pour aller vers la page web précédente du navigateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        /// <summary>
        /// Action pour aller sur la page web suivante du navigateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        /// <summary>
        /// L'action associe au click du bouton pour la cartographie dynamique via google MAP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowGoogleMap_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlGoogleMap + textBoxSearchAddress.Text +" "+ textBoxPostalCode.Text +" "+ textBoxCity.Text);

        }

        /// <summary>
        /// L'action associe au click du boutton pour le tweeter de MIAGE connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTwitter_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlTwitter);
        }

        /// <summary>
        /// L'action associe au click sur l'onglet page perso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPagePerso_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlTarik);
        }

        /// <summary>
        /// Boutton pour visualiser le compte tweeter
        /// </summary>
        /// <param name="sender">le bouton</param>
        /// <param name="e">l'event associe au click du bouton</param>
        private void buttonVisualiserCompteTwitter_Click(object sender, EventArgs e)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = "960698270-kjL0TpQtI4bqKWUu0ULapwYPjgk1wABTqD73ju7m";
            tokens.AccessTokenSecret = "rwLN5IG8ncNIdPGytci6ZHEV6crpcfeq8Uk830BE";
            tokens.ConsumerKey = "gEe9gXqHDK4rJzCQwLz46A";
            tokens.ConsumerSecret = "L8PER9UDaLoyshje2nm6COnMjutmX30OLjjqF4znc";

            TwitterResponse<TwitterUser> showUserResponse = TwitterUser.Show(tokens, textBoxTwitterAccount.Text);
            if (showUserResponse.Result == RequestResult.Success)
            {
                DisplayUserDetails(showUserResponse.ResponseObject);
            }
            else
            {
                MessageBox.Show("Ce compte tweeter n'existe pas.");
            }
        }

        /// <summary>
        /// Function to post a message on tweeter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPostToTweeterAccount_Click(object sender, EventArgs e)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = "960698270-kjL0TpQtI4bqKWUu0ULapwYPjgk1wABTqD73ju7m";
            tokens.AccessTokenSecret = "rwLN5IG8ncNIdPGytci6ZHEV6crpcfeq8Uk830BE";
            tokens.ConsumerKey = "gEe9gXqHDK4rJzCQwLz46A";
            tokens.ConsumerSecret = "L8PER9UDaLoyshje2nm6COnMjutmX30OLjjqF4znc";

            TwitterResponse<TwitterStatus> tweetResponse = TwitterStatus.Update(tokens, textBoxPostTweetMessage.Text);
            
            if (tweetResponse.Result == RequestResult.Success)
            {
                MessageBox.Show("Tweet posted successfully!");
            }
            else
            {
                MessageBox.Show("Something bad happened");
            }
        }

        /// <summary>
        /// Function to display User information for tweeter account
        /// </summary>
        /// <param name="twitterUser">l'identifiant du compte tweeter</param>
        private void DisplayUserDetails(TwitterUser twitterUser) {

            if (twitterUser.Description != null)
            {
                labelDescriptionValue.Text = twitterUser.Description;
            }
            else {
                labelDescriptionValue.Text = "";
            }

            if (twitterUser.Location != null)
            {
                labelLocalisationValue.Text = twitterUser.Location;
            }
            else {
                labelLocalisationValue.Text = "";
            }

            if (twitterUser.NumberOfFollowers != null)
            {
                labelNombreAbonneValue.Text = twitterUser.NumberOfFollowers.ToString();
            }
            else {
                labelNombreAbonneValue.Text = "";
            }

            if (twitterUser.TimeZone != null)
            {
                labelTimeZoneValue.Text = twitterUser.TimeZone;
            }
            else {
                labelTimeZoneValue.Text = "";
            }

            if (twitterUser.Website != null)
            {
                labelURLValue.Text = twitterUser.Website;
            }
            else {
                labelURLValue.Text = "";
            }

            if (twitterUser.Status != null && twitterUser.Status.Text != null)
            {
                labelLastTweetValue.Text = twitterUser.Status.Text;
            }
            else {
                labelLastTweetValue.Text = "";
            }

            if (twitterUser.ProfileImageLocation != null)
            {
                panelImageTweeterAccount.BackgroundImage = DownloadImage(twitterUser.ProfileImageLocation);
            }
            else {
                panelImageTweeterAccount.BackgroundImage = null;
            }

        }

        /// <summary>
	    /// Function pour télécharger une Image via une URL.
	    /// </summary>
	    /// <param name="_URL">URL address to download image</param>
	    /// <returns>Image</returns>
	    public Image DownloadImage(string _URL)
	    {
	        Image _tmpImage = null;
	 
	        try
	        {
	            // Open a connection
	            System.Net.HttpWebRequest _HttpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_URL);
    	 
	            _HttpWebRequest.AllowWriteStreamBuffering = true;

	            // set timeout for 20 seconds (Optional)
	            _HttpWebRequest.Timeout = 20000;
    	 
	            // Request response:
	            System.Net.WebResponse _WebResponse = _HttpWebRequest.GetResponse();
    	 
	            // Open data stream:
	            System.IO.Stream _WebStream = _WebResponse.GetResponseStream();
    	 
	            // convert webstream to image	        
                _tmpImage = Image.FromStream(_WebStream);
     
                // Cleanup
	            _WebResponse.Close();
	        }
	        catch (Exception _Exception)
	        {
	            // Error
	            Console.WriteLine("Exception caught in process download image from url:", _Exception.ToString());
	            return null;
	        }
    	 
	        return _tmpImage;
	    }
 
    }
}
