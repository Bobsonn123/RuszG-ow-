namespace pierwszyInterfejs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());


            IClown fingersTheClown = new ScaryScary(14, "wielkie czerwone oczy");
            fingersTheClown.Honk();
            if (fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareLittleChildren();
            }
        }
    }
}
