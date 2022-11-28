using Project.Core.Models;

namespace Project.WebUI.ViewModel
{
	public class CustomerWithImage_VM
	{
		public	Customer Customer { get; set; }
		public IList<CustomerImageFile> CustomerImageFile { get; set; }

    }
}
