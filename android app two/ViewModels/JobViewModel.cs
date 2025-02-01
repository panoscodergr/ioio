using JobApp.Models;
using System.Collections.ObjectModel;

namespace JobApp.ViewModels
{
    public class JobViewModel
    {
        public ObservableCollection<Job> Jobs { get; set; }

        public JobViewModel()
        {
            Jobs = new ObservableCollection<Job>
            {
                new Job { Title = "test", Description = "test", Phone = "test", Email = "test", Price = 1, ImageUrl = "https://example.com/image.jpg" }
                // Προσθέστε περισσότερες αγγελίες
            };
        }
    }
}
