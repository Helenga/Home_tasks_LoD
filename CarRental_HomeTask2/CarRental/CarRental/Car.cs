using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CarRental
{
    public class Car
    {
        public Car(int id, string model, string color)
        {
            ID = id;
            Model = model;
            Color = color;
            _checkUpControl = new CheckUpControl(id);
        }

        public void CheckStatus()
        {
            _checkUpControl.SendToCheckUpOnTime();
        }

        [JsonProperty]
        [Required]
        public string Model { get; }
        [JsonProperty]
        [Required]
        public string Color { get; }
        [JsonProperty]
        [Required]
        public int ID { get; } // уникальный идентификатор авто
        [JsonProperty]
        private CheckUpControl _checkUpControl;
    }
}
