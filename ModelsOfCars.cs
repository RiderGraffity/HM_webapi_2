namespace HM_webapi_2
{
    public class ModelsOfCars
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public ModelsOfCars(string Mark, string Model, double Price)
        {
            this.Mark = Mark;
            this.Model = Model;
            this.Price = Price;
        }
    }
}
