namespace Navigateur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabNavigateur = new System.Windows.Forms.TabControl();
            this.tabPerso = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.buttonShowGoogleMap = new System.Windows.Forms.Button();
            this.textBoxSearchAddress = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.tabTwitter = new System.Windows.Forms.TabPage();
            this.buttonTwitter = new System.Windows.Forms.Button();
            this.tabPagePerso = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxTwitterAccount = new System.Windows.Forms.TextBox();
            this.buttonVisualiserCompteTwitter = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.labelLocalisation = new System.Windows.Forms.Label();
            this.labelLocalisationValue = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelURLValue = new System.Windows.Forms.Label();
            this.labelNombreAbonne = new System.Windows.Forms.Label();
            this.labelNombreAbonneValue = new System.Windows.Forms.Label();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.labelTimeZoneValue = new System.Windows.Forms.Label();
            this.labellastTweet = new System.Windows.Forms.Label();
            this.labelLastTweetValue = new System.Windows.Forms.Label();
            this.panelImageTweeterAccount = new System.Windows.Forms.Panel();
            this.buttonPostToTweeterAccount = new System.Windows.Forms.Button();
            this.textBoxPostTweetMessage = new System.Windows.Forms.TextBox();
            this.tabNavigateur.SuspendLayout();
            this.tabPerso.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabTwitter.SuspendLayout();
            this.tabPagePerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNavigateur
            // 
            this.tabNavigateur.Controls.Add(this.tabPerso);
            this.tabNavigateur.Controls.Add(this.tabMap);
            this.tabNavigateur.Controls.Add(this.tabTwitter);
            this.tabNavigateur.Controls.Add(this.tabPagePerso);
            this.tabNavigateur.Location = new System.Drawing.Point(12, 12);
            this.tabNavigateur.Name = "tabNavigateur";
            this.tabNavigateur.SelectedIndex = 0;
            this.tabNavigateur.Size = new System.Drawing.Size(534, 74);
            this.tabNavigateur.TabIndex = 0;
            // 
            // tabPerso
            // 
            this.tabPerso.Controls.Add(this.buttonSearch);
            this.tabPerso.Controls.Add(this.textBoxSearch);
            this.tabPerso.Location = new System.Drawing.Point(4, 22);
            this.tabPerso.Name = "tabPerso";
            this.tabPerso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerso.Size = new System.Drawing.Size(526, 48);
            this.tabPerso.TabIndex = 0;
            this.tabPerso.Text = "Google Perso";
            this.tabPerso.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(433, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(409, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.textBoxCity);
            this.tabMap.Controls.Add(this.labelCity);
            this.tabMap.Controls.Add(this.textBoxPostalCode);
            this.tabMap.Controls.Add(this.labelCodePostal);
            this.tabMap.Controls.Add(this.buttonShowGoogleMap);
            this.tabMap.Controls.Add(this.textBoxSearchAddress);
            this.tabMap.Controls.Add(this.labelAdresse);
            this.tabMap.Location = new System.Drawing.Point(4, 22);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(526, 48);
            this.tabMap.TabIndex = 1;
            this.tabMap.Text = "Carte Google Map";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(262, 25);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(177, 20);
            this.textBoxCity.TabIndex = 6;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(217, 30);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(39, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Ville :";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(98, 25);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 4;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodePostal.Location = new System.Drawing.Point(9, 28);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(83, 13);
            this.labelCodePostal.TabIndex = 3;
            this.labelCodePostal.Text = "Code Postal :";
            // 
            // buttonShowGoogleMap
            // 
            this.buttonShowGoogleMap.Location = new System.Drawing.Point(446, 4);
            this.buttonShowGoogleMap.Name = "buttonShowGoogleMap";
            this.buttonShowGoogleMap.Size = new System.Drawing.Size(75, 38);
            this.buttonShowGoogleMap.TabIndex = 2;
            this.buttonShowGoogleMap.Text = "Voir la carte Google Map";
            this.buttonShowGoogleMap.UseVisualStyleBackColor = true;
            this.buttonShowGoogleMap.Click += new System.EventHandler(this.buttonShowGoogleMap_Click);
            // 
            // textBoxSearchAddress
            // 
            this.textBoxSearchAddress.Location = new System.Drawing.Point(73, 4);
            this.textBoxSearchAddress.Name = "textBoxSearchAddress";
            this.textBoxSearchAddress.Size = new System.Drawing.Size(366, 20);
            this.textBoxSearchAddress.TabIndex = 1;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(6, 3);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(60, 13);
            this.labelAdresse.TabIndex = 0;
            this.labelAdresse.Text = "Adresse :";
            // 
            // tabTwitter
            // 
            this.tabTwitter.Controls.Add(this.buttonTwitter);
            this.tabTwitter.Location = new System.Drawing.Point(4, 22);
            this.tabTwitter.Name = "tabTwitter";
            this.tabTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwitter.Size = new System.Drawing.Size(526, 48);
            this.tabTwitter.TabIndex = 2;
            this.tabTwitter.Text = "Miage Connection";
            this.tabTwitter.UseVisualStyleBackColor = true;
            // 
            // buttonTwitter
            // 
            this.buttonTwitter.Location = new System.Drawing.Point(153, 11);
            this.buttonTwitter.Name = "buttonTwitter";
            this.buttonTwitter.Size = new System.Drawing.Size(218, 23);
            this.buttonTwitter.TabIndex = 0;
            this.buttonTwitter.Text = "Voir le Twitter de MIAGE Connection";
            this.buttonTwitter.UseVisualStyleBackColor = true;
            this.buttonTwitter.Click += new System.EventHandler(this.buttonTwitter_Click);
            // 
            // tabPagePerso
            // 
            this.tabPagePerso.Controls.Add(this.label1);
            this.tabPagePerso.Location = new System.Drawing.Point(4, 22);
            this.tabPagePerso.Name = "tabPagePerso";
            this.tabPagePerso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerso.Size = new System.Drawing.Size(526, 48);
            this.tabPagePerso.TabIndex = 3;
            this.tabPagePerso.Text = "tabPagePerso";
            this.tabPagePerso.UseVisualStyleBackColor = true;
            this.tabPagePerso.Click += new System.EventHandler(this.tabPagePerso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliquer dans le cadre blanc pour voir la page web du concepteur";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrevious.BackgroundImage")));
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.Location = new System.Drawing.Point(572, 34);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(51, 44);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Location = new System.Drawing.Point(640, 34);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(51, 44);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Location = new System.Drawing.Point(707, 34);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(51, 44);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(780, 34);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(51, 44);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 92);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(534, 379);
            this.webBrowser.TabIndex = 5;
            // 
            // textBoxTwitterAccount
            // 
            this.textBoxTwitterAccount.Location = new System.Drawing.Point(563, 104);
            this.textBoxTwitterAccount.Name = "textBoxTwitterAccount";
            this.textBoxTwitterAccount.Size = new System.Drawing.Size(119, 20);
            this.textBoxTwitterAccount.TabIndex = 6;
            // 
            // buttonVisualiserCompteTwitter
            // 
            this.buttonVisualiserCompteTwitter.Location = new System.Drawing.Point(688, 104);
            this.buttonVisualiserCompteTwitter.Name = "buttonVisualiserCompteTwitter";
            this.buttonVisualiserCompteTwitter.Size = new System.Drawing.Size(159, 34);
            this.buttonVisualiserCompteTwitter.TabIndex = 7;
            this.buttonVisualiserCompteTwitter.Text = "Obtenir les infos de ce compte Twitter";
            this.buttonVisualiserCompteTwitter.UseVisualStyleBackColor = true;
            this.buttonVisualiserCompteTwitter.Click += new System.EventHandler(this.buttonVisualiserCompteTwitter_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(560, 152);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description :";
            // 
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.AutoSize = true;
            this.labelDescriptionValue.Location = new System.Drawing.Point(648, 152);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionValue.TabIndex = 9;
            // 
            // labelLocalisation
            // 
            this.labelLocalisation.AutoSize = true;
            this.labelLocalisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalisation.Location = new System.Drawing.Point(560, 185);
            this.labelLocalisation.Name = "labelLocalisation";
            this.labelLocalisation.Size = new System.Drawing.Size(83, 13);
            this.labelLocalisation.TabIndex = 10;
            this.labelLocalisation.Text = "Localisation :";
            // 
            // labelLocalisationValue
            // 
            this.labelLocalisationValue.AutoSize = true;
            this.labelLocalisationValue.Location = new System.Drawing.Point(651, 185);
            this.labelLocalisationValue.Name = "labelLocalisationValue";
            this.labelLocalisationValue.Size = new System.Drawing.Size(0, 13);
            this.labelLocalisationValue.TabIndex = 11;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(563, 221);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(40, 13);
            this.labelURL.TabIndex = 12;
            this.labelURL.Text = "URL :";
            // 
            // labelURLValue
            // 
            this.labelURLValue.AutoSize = true;
            this.labelURLValue.Location = new System.Drawing.Point(610, 220);
            this.labelURLValue.Name = "labelURLValue";
            this.labelURLValue.Size = new System.Drawing.Size(0, 13);
            this.labelURLValue.TabIndex = 13;
            // 
            // labelNombreAbonne
            // 
            this.labelNombreAbonne.AutoSize = true;
            this.labelNombreAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAbonne.Location = new System.Drawing.Point(563, 256);
            this.labelNombreAbonne.Name = "labelNombreAbonne";
            this.labelNombreAbonne.Size = new System.Drawing.Size(120, 13);
            this.labelNombreAbonne.TabIndex = 14;
            this.labelNombreAbonne.Text = "Nombre d\'abonnés :";
            // 
            // labelNombreAbonneValue
            // 
            this.labelNombreAbonneValue.AutoSize = true;
            this.labelNombreAbonneValue.Location = new System.Drawing.Point(688, 255);
            this.labelNombreAbonneValue.Name = "labelNombreAbonneValue";
            this.labelNombreAbonneValue.Size = new System.Drawing.Size(0, 13);
            this.labelNombreAbonneValue.TabIndex = 15;
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeZone.Location = new System.Drawing.Point(563, 283);
            this.labelTimeZone.Name = "labelTimeZone";
            this.labelTimeZone.Size = new System.Drawing.Size(75, 13);
            this.labelTimeZone.TabIndex = 16;
            this.labelTimeZone.Text = "Time Zone :";
            // 
            // labelTimeZoneValue
            // 
            this.labelTimeZoneValue.AutoSize = true;
            this.labelTimeZoneValue.Location = new System.Drawing.Point(645, 283);
            this.labelTimeZoneValue.Name = "labelTimeZoneValue";
            this.labelTimeZoneValue.Size = new System.Drawing.Size(0, 13);
            this.labelTimeZoneValue.TabIndex = 17;
            // 
            // labellastTweet
            // 
            this.labellastTweet.AutoSize = true;
            this.labellastTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastTweet.Location = new System.Drawing.Point(563, 319);
            this.labellastTweet.Name = "labellastTweet";
            this.labellastTweet.Size = new System.Drawing.Size(95, 13);
            this.labellastTweet.TabIndex = 18;
            this.labellastTweet.Text = "Dernier Tweet :";
            // 
            // labelLastTweetValue
            // 
            this.labelLastTweetValue.AutoSize = true;
            this.labelLastTweetValue.Location = new System.Drawing.Point(664, 319);
            this.labelLastTweetValue.Name = "labelLastTweetValue";
            this.labelLastTweetValue.Size = new System.Drawing.Size(0, 13);
            this.labelLastTweetValue.TabIndex = 19;
            // 
            // panelImageTweeterAccount
            // 
            this.panelImageTweeterAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImageTweeterAccount.Location = new System.Drawing.Point(566, 374);
            this.panelImageTweeterAccount.Name = "panelImageTweeterAccount";
            this.panelImageTweeterAccount.Size = new System.Drawing.Size(101, 109);
            this.panelImageTweeterAccount.TabIndex = 20;
            // 
            // buttonPostToTweeterAccount
            // 
            this.buttonPostToTweeterAccount.Location = new System.Drawing.Point(688, 408);
            this.buttonPostToTweeterAccount.Name = "buttonPostToTweeterAccount";
            this.buttonPostToTweeterAccount.Size = new System.Drawing.Size(219, 26);
            this.buttonPostToTweeterAccount.TabIndex = 21;
            this.buttonPostToTweeterAccount.Text = "Poster un message sur ce tweeter";
            this.buttonPostToTweeterAccount.UseVisualStyleBackColor = true;
            this.buttonPostToTweeterAccount.Click += new System.EventHandler(this.buttonPostToTweeterAccount_Click);
            // 
            // textBoxPostTweetMessage
            // 
            this.textBoxPostTweetMessage.Location = new System.Drawing.Point(688, 374);
            this.textBoxPostTweetMessage.Name = "textBoxPostTweetMessage";
            this.textBoxPostTweetMessage.Size = new System.Drawing.Size(219, 20);
            this.textBoxPostTweetMessage.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 506);
            this.Controls.Add(this.textBoxPostTweetMessage);
            this.Controls.Add(this.buttonPostToTweeterAccount);
            this.Controls.Add(this.panelImageTweeterAccount);
            this.Controls.Add(this.labelLastTweetValue);
            this.Controls.Add(this.labellastTweet);
            this.Controls.Add(this.labelTimeZoneValue);
            this.Controls.Add(this.labelTimeZone);
            this.Controls.Add(this.labelNombreAbonneValue);
            this.Controls.Add(this.labelNombreAbonne);
            this.Controls.Add(this.labelURLValue);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelLocalisationValue);
            this.Controls.Add(this.labelLocalisation);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonVisualiserCompteTwitter);
            this.Controls.Add(this.textBoxTwitterAccount);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.tabNavigateur);
            this.Name = "Form1";
            this.Text = "Mon navigateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabNavigateur.ResumeLayout(false);
            this.tabPerso.ResumeLayout(false);
            this.tabPerso.PerformLayout();
            this.tabMap.ResumeLayout(false);
            this.tabMap.PerformLayout();
            this.tabTwitter.ResumeLayout(false);
            this.tabPagePerso.ResumeLayout(false);
            this.tabPagePerso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabNavigateur;
        private System.Windows.Forms.TabPage tabPerso;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxSearchAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Button buttonShowGoogleMap;
        private System.Windows.Forms.TabPage tabTwitter;
        private System.Windows.Forms.Button buttonTwitter;
        private System.Windows.Forms.TabPage tabPagePerso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTwitterAccount;
        private System.Windows.Forms.Button buttonVisualiserCompteTwitter;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDescriptionValue;
        private System.Windows.Forms.Label labelLocalisation;
        private System.Windows.Forms.Label labelLocalisationValue;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelURLValue;
        private System.Windows.Forms.Label labelNombreAbonne;
        private System.Windows.Forms.Label labelNombreAbonneValue;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.Label labelTimeZoneValue;
        private System.Windows.Forms.Label labellastTweet;
        private System.Windows.Forms.Label labelLastTweetValue;
        private System.Windows.Forms.Panel panelImageTweeterAccount;
        private System.Windows.Forms.Button buttonPostToTweeterAccount;
        private System.Windows.Forms.TextBox textBoxPostTweetMessage;
    }
}

