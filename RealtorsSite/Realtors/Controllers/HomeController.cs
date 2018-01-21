using System.Collections.Generic;
using Realtors.Infrastructure;
using System.Web.Mvc;
using Realtors.Models;

namespace Realtors.Controllers
{
    [ExceptionLogger(View = "Error")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new GeneralPageModel
            {
                RoomsPage = new RoomPageModel()
                {
                    Rooms = new List<RoomModel>
                    {
                        new RoomModel() {Id = 1, Name = "Квартира 1", Image =  new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}, FooterMeters = 40, FooterNumber = 10,CountRooms = 2, Price = 1200000, Address = "Холодильная 51",AddressArea = "Тюменский"},
                        new RoomModel() {Id = 2, Name = "Квартира 2" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 3, Name = "Квартира 3" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 4, Name = "Квартира 4" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 5" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 6" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 7" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 8" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 9" , Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 10", Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 11", Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 12", Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg"}},
                        new RoomModel() {Id = 5, Name = "Квартира 13", Image = new string[]{"https://st.kp.yandex.net/im/wallpaper/1/5/6/kinopoisk.ru-Kung-Fu-Panda-2-1561242--w--800.jpg" } }
                    }
                }
            };
            return View(model);
        }
        public ActionResult RoomsPageView()
        {
            
            return View();
        }
        public ActionResult RoomView()
        {
            return View();
        }
    }
}