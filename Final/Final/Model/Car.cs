using System;
using Final.infrasructure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Model
{
    [Serializable]
    public class Car:Notifyer
    {
        private string _imageUrl;
        private string _title;
        private string _model;
        private int _year;
        private string _color;
        public int Id { get; set; }
        public string Title { get => _title; set { _title = value; Notify(); } }
        public string Model { get => _model; set { _model = value; Notify(); } }
        public int Year { get => _year; set { _year = value; Notify(); } }
        public string Color { get => _color; set { _color = value; Notify(); } }
        public string ImageUrl { get => _imageUrl; set { _imageUrl = value; Notify(); } }
        public static IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Id = 1343,
                    Title = "Mitsubishi",
                    Model = "Lancer EVO IX",
                    Color = "Yellow",
                    Year = 2008,
                    ImageUrl = "https://a.d-cd.net/4bb19f9s-960.jpg"
                },
                new Car
                {
                    Id = 2323,
                    Title = "Honda",
                    Model = "Accord",
                    Color = "Black",
                    Year = 2011,
                    ImageUrl = "https://a.d-cd.net/2QAAAgI_5-A-960.jpg"
                },
                new Car
                {
                    Id = 54554,
                    Title = "Lexus",
                    Model = "IS 250",
                    Color = "Gray",
                    Year = 2013,
                    ImageUrl = "https://s.auto.drom.ru/i24207/c/photos/fullsize/lexus/is250/lexus_is250_692060.jpg"
                },
                new Car
                {
                    Id = 76677,
                    Title = "Nissan",
                    Model = "R34",
                    Color = "Blue",
                    Year = 2003,
                    ImageUrl = "https://s.auto.drom.ru/i24248/pubs/4483/79955/3563764.jpg"
                },
                new Car
                {
                    Id = 234234,
                    Title = "Toyota",
                    Model = "GT86",
                    Color = "Blue",
                    Year = 2014,
                    ImageUrl = "https://www.ft86club.com/forums/attachment.php?attachmentid=2871&d=1322426350"

                },
                new Car
                {
                    Id = 56534,
                    Title = "Lexus",
                    Model = "NX 200t",
                    Color = "White",
                    Year = 2017,
                    ImageUrl = "https://s.auto.drom.ru/img5/catalog/photos/fullsize/lexus/nx200t/lexus_nx200t_207073.jpg"

                },
                new Car
                {
                    Id = 12233,
                    Title = "Honda",
                    Model = "CR-V",
                    Color = "Black",
                    Year = 2018,
                    ImageUrl = "https://cdn.riastatic.com/photosnew/auto/photo/Honda_CR-V__342844623f.jpg"
                },
                new Car
                {
                    Id = 665534,
                    Title = "Volkswagen",
                    Model = "Golf GTI",
                    Color = "White",
                    Year = 2018,
                    ImageUrl = "https://besthqwallpapers.com/Uploads/26-5-2018/53894/thumb2-volkswagen-golf-gti-2018-tcr-white-hatchback-white-wheels.jpg"
                },

            };
        }
    }
}
