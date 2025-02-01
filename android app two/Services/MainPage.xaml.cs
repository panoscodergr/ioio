using JobApp.Models;
using JobApp.Services;
using Xamarin.Forms;

namespace JobApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddJobClicked(object sender, EventArgs e)
        {
            // Κώδικας για την προσθήκη αγγελίας
        }

        private async void OnSearchJobClicked(object sender, EventArgs e)
        {
            // Κώδικας για την αναζήτηση αγγελιών
        }

        private async void OnShowJobsClicked(object sender, EventArgs e)
        {
            // Εμφανίζει τη σελίδα με όλες τις αγγελίες
            await Navigation.PushAsync(new JobDetailsPage());
        }

        private async void OnAccountClicked(object sender, EventArgs e)
        {
            // Κώδικας για τη διαχείριση του λογαριασμού
        }
    }
}
