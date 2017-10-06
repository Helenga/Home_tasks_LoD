using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Model { get; }
        [Required]
        public string Color { get; }
        [Required]
        public int ID { get; } // уникальный идентификатор авто
        private CheckUpControl _checkUpControl;
    }
}
