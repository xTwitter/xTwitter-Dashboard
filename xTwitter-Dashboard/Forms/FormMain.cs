using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using LinqToTwitter;
using xTwitter_Dashboard.Repositories;
using System.IO;

namespace xTwitter_Dashboard.Forms
{
    public partial class FormMain : Telerik.WinControls.UI.RadRibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

		private async void radButtonElement_Login_Click(object sender, EventArgs e)
		{
			login();
		}

		private async void login()
		{
			FormLogin loginForm = new FormLogin();
			DialogResult dialogResult = loginForm.ShowDialog();

			if (dialogResult == DialogResult.OK)
			{
				this.radButtonElement_Login.Image = new Bitmap(Properties.Resources.logout_96);
				this.radButtonElement_Login.Text = "로그아웃";
				this.radButtonElement_Login.Enabled = false;

				HttpResponseMessage response = await new HttpClient().GetAsync(Repository.accountRepository.user.ProfileImageUrl);
				Stream responseStream = await response.Content.ReadAsStreamAsync();

				this.radLabelElement_Profile.Image = new Bitmap(responseStream).GetThumbnailImage(64, 64, null, IntPtr.Zero);
				this.radLabelElement_Id.Text = String.Format("<html><strong>{0}</strong></html>", Repository.accountRepository.user.Name);
				this.radLabelElement_ScreenName.Text = String.Format("<html><span style=\"color: #8080ff\">@{0}</span></html>", Repository.accountRepository.user.ScreenName);
			}
		}
	}
}
