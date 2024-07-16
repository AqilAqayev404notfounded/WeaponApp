using System;
using WeaponApp;
using WeaponApp.Enums;



Weapon myWeapon = new Weapon(BulletType.mm5_56, 30);
Weapon myWeapon1 = new Weapon(BulletType.mm9, 25);
Weapon myWeapon2 = new Weapon(BulletType.mm0_45, 25);
Weapon myWeapon3 = new Weapon(BulletType.mm7_62, 40);

while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Fill weapon");
    Console.WriteLine("2. Fire weapon");
   
    Console.WriteLine("3. Exit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Hansini doldurum");
            Console.WriteLine("7.62mm");
            Console.WriteLine("5.56mm");
            Console.WriteLine("9mm");
            Console.WriteLine("0.45mm");
            string output = Console.ReadLine();
            switch (output)
            {
                case "1":
                    myWeapon3.Fill();
                    Console.WriteLine("7.62 full");
                    break;
                case "2":
                    myWeapon.Fill();
                    Console.WriteLine("5.56 full");
                    break;
                case "3":
                    myWeapon1.Fill();
                    Console.WriteLine("9mm full");
                    break;
                case "4":
                    myWeapon2.Fill();
                    Console.WriteLine("0.45mm full");

                    break;
                default:
                    {
                        Console.WriteLine("please correct variant");
                        continue;

                    }
            }
            break;

        case "2":
            Console.WriteLine("select weapon");
            Console.WriteLine("7.62mm");
            Console.WriteLine("5.56mm");
            Console.WriteLine("9mm");
            Console.WriteLine("0.45mm");
            string output2 = Console.ReadLine();
            switch (output2)
            {
                case "1":


                restart2:
                    string b = Console.ReadLine();
                    switch (b)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon3.Fire();
                            goto restart2;


                    }

                    break;
                case "2":
                restart:
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon.Fire();
                            goto restart;


                    }

                    break;
                case "3":
                restart3:
                    string c = Console.ReadLine();
                    switch (c)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon1.Fire();
                            goto restart3;


                    }
                    break;
                case "4":
                    restart4:
                    string d = Console.ReadLine();
                    switch (d)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon2.Fire();
                            goto restart4;


                    }
                    break;
                default:
                    {
                        Console.WriteLine("please correct variant");
                        continue;

                    }
            }
            break;

        
        case "3":
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}



