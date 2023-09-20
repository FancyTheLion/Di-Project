using DI_Car.Abstractions;

namespace DI_Car.Concrete
{
    /// <summary>
    /// Как машина, но не нуждается в двигателе вообще
    /// </summary>
    public class Scooter : ICar
    {
        public void DriveTo(string destination)
        {
            Console.WriteLine($"Едем в {destination} не используя мотор!");
        }
    }
}
