namespace CarRental
{
    class Car
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

        public string Model { get; }
        public string Color { get; }
        public int ID { get; } // уникальный идентификатор авто
        private CheckUpControl _checkUpControl;
    }
}
