using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;
using xTwitter_Dashboard.Repositories;

namespace xTwitter_Dashboard.Forms
{
	public partial class FormLogin : Telerik.WinControls.UI.RadForm
    {
		private PinAuthorizer pinAuthorizer = new PinAuthorizer();

		public FormLogin()
        {
            InitializeComponent();

			this.navigate();
        }

		private async void webBrowser_DocumentCompletedAsync(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			this.parsePin();
		}

		private async void navigate()
		{
			this.pinAuthorizer = new PinAuthorizer
			{
				CredentialStore = new InMemoryCredentialStore
				{
					ConsumerKey = ConfigurationManager.AppSettings["consumerKey"],
					ConsumerSecret = ConfigurationManager.AppSettings["consumerSecret"]
				},

				GoToTwitterAuthorization = pageLink => this.webBrowser.Navigate(new Uri(pageLink, UriKind.Absolute))
			};

			await this.pinAuthorizer.BeginAuthorizeAsync();
		}

		private async void parsePin()
		{
			String document = this.webBrowser.DocumentText;

			if (document.Contains("aria-labelledby"))
			{
				String pin = document.Substring(document.IndexOf("aria-labelledby") + 34, 7);

				await this.pinAuthorizer.CompleteAuthorizeAsync(pin);
				Repository.accountRepository.pinAuthorizer = pinAuthorizer;
				Repository.accountRepository.twitterContext = new TwitterContext(pinAuthorizer);

				await verifyCredentialsAsync(Repository.accountRepository.twitterContext);

				this.DialogResult = DialogResult.OK;
			}
		}

		private static async Task verifyCredentialsAsync(TwitterContext twitterContext)
		{
			try
			{
				var verifyResponse =
					await
						(from account in twitterContext.Account
						 where account.Type == AccountType.VerifyCredentials
						 select account)
						.SingleOrDefaultAsync();

				if (verifyResponse != null && verifyResponse.User != null)
				{
					Repository.accountRepository.user = verifyResponse.User;
				}
			}
			catch (TwitterQueryException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
