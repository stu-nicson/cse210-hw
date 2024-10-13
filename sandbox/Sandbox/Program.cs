using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the Following choices \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \n What would you like to do:");
        // Console.WriteLine("Hello Sandbox World!");
        Costume nurse = new Costume();
        nurse._headWear = "face mask";
        nurse._gloves = "nitrile"; 
        nurse._shoes = "orthopedic sneakers";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._accessory = "stethoscope";

        Costume detective = new Costume();
        detective._headWear = "fedora";
        detective._gloves = "leather"; 
        detective._shoes = "loafers";
        detective._upperGarment = "trench coat";
        detective._lowerGarment = "slacks";
        detective._accessory = "magnifier";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}
