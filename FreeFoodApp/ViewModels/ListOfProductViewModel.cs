using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Models;
using FreeFoodApp.Views;
using System.Collections.ObjectModel;

namespace FreeFoodApp.ViewModels
{
    public partial class ListOfProductViewModel : BaseViewModel
    {
        #region Properites
        public ObservableCollection<Iteminfo> ItemList { get; set; } = new ObservableCollection<Iteminfo>();
        #endregion

        [RelayCommand]
        Task GoBackBtn() => Shell.Current.GoToAsync("/MainMenuPage");
        public ListOfProductViewModel()
        {

            AddItemList();
        }

        private void AddItemList()
        {
            IsBusy = true;
            Task.Run(async () =>
            {
                // await api call;
                await Task.Delay(1000);

                Application.Current.Dispatcher.Dispatch(() =>
                {
                    // adding data in Item List object
                    ItemList.Clear();
                    ItemList.Add(new Iteminfo { ItemName = "Plate", Details = "Introducing our elegant and versatile porcelain dinner plates, " +
                        "perfect for any occasion. Made from high-quality porcelain, these plates are durable and designed to " +
                        "withstand the rigors of daily use. The classic white finish of these plates will add a touch of sophistication to your dinner table, and the 10.5 inch diameter is perfect for any meal.",
                        Image = "https://img.freepik.com/free-psd/close-up-ceramic-plate-mockup_53876-98747.jpg?w=2000" });

                    ItemList.Add(new Iteminfo { 
                        ItemName = "Chucky Doll", 
                        Details = "\"Bring home the terror with our official Chucky doll from the Child's Play series. " +
                        "Standing at a menacing 18 inches tall, this fully articulated doll features realistic and accurate details from the movie, " +
                        "including his signature red overalls and striped shirt. With 11 points of articulation, " +
                        "you can pose him in a variety of terrifying positions. The Good Guys doll also includes his trademark knife and an interchangeable hand. " +
                        "Made of high-quality materials, this is the perfect addition for any horror fan or collector. Order yours today and let the killing spree begin!\"", 
                        Image = "https://images.halloweencostumes.com/products/51533/1-1/childs-play-2-good-guys-chucky-doll-udpate.jpg" });

                    ItemList.Add(new Iteminfo { 
                        ItemName = "Cup", 
                        Details = "\"Sip in style with our beautifully crafted ceramic coffee cups. These cups are made of high-quality ceramic material, " +
                        "which is known for its excellent heat retention properties, keeping your coffee hot for longer. The classic design of these cups features a smooth, glossy finish and a comfortable handle that makes them easy to hold and drink from. " +
                        "Its 12 oz. capacity is perfect for your morning coffee or afternoon tea. These cups are dishwasher and microwave safe, easy to clean and maintain.", 
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Cup_and_Saucer_LACMA_47.35.6a-b_%281_of_3%29.jpg/1200px-Cup_and_Saucer_LACMA_47.35.6a-b_%281_of_3%29.jpg"
                    });
                    ItemList.Add(new Iteminfo { 
                        ItemName = "Screws", 
                        Details = "This screw is a durable and reliable fastener for all of your construction needs. Made from high-quality steel, " +
                        "it is designed to withstand heavy use and resist rust and corrosion. The pointed tip allows for easy installation and the smooth threading ensures a secure hold. " +
                        "This screw is perfect for wood and drywall applications.", 
                        Image = "https://contents.mediadecathlon.com/p116192/k$45fc542a3e8a0a52b4d0bcf598eec1be/bike-bottle-cage-screws-16mm-x2.jpg?format=auto&quality=40&f=800x800"
                    });
                    ItemList.Add(new Iteminfo { 
                        ItemName = "Chair", 
                        Details = "This chair is the perfect blend of style and comfort. The sleek design features a durable, sturdy metal frame and a soft, padded seat and backrest, upholstered in a high-quality fabric. " +
                        "The chair's armrests provide extra support and comfort, while the chair's height can be adjusted to suit your needs. The chair's sleek design makes it an ideal addition to any office, living room, or bedroom. " +
                        "The chair is easy to assemble, and comes with all the hardware and tools you need.", 
                        Image = "https://dynamic.zacdn.com/3SDxZ2piJh7WxYpONMOCphd-__M=/fit-in/346x500/filters:quality(95):fill(ffffff)/https://static-my.zacdn.com/p/joy-design-studio-8324-1087672-1.jpg"
                    });
                   
                    IsBusy = false;
                });
            });
        }

        #region Commands
        [RelayCommand]
        async Task GoToDetails(Iteminfo Iteminfo)
        {
            if (Iteminfo == null)
                return;

            await Shell.Current.GoToAsync(nameof(ProductDetailPage), true, new Dictionary<string, object>
    {
        {"Iteminfo", Iteminfo }
    });
        }
        #endregion
    }
}
