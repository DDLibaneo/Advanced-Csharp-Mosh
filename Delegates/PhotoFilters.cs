namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Resize photo");
        }
    }
}