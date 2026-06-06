namespace Metodo_toString
{
    internal class Program
    {
        static void Main(string[] args) // Su funcion es convertir un objeto a una cadena de texto legible. Es un método que se encuentra en la clase base Object, y se puede sobrescribir en cualquier clase para proporcionar una representación personalizada del objeto.
        {
          Auto auto1 = new Auto("chevy","corvette",96,"Rojo");
            Console.WriteLine(auto1);
        }
    }
    class Auto
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }

        public Auto (string marca, string modelo, int año, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
        } 







    }
}
