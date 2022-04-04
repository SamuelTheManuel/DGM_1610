using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum Colors {red, yellow, blue, green, purple, orange};
public class Enums : MonoBehaviour
{
    
    enum Colors {red, yellow, blue, green, purple, orange};
    enum CarMake {Oldsmobile, Chevy, Ford, Mazda, Toyota, Dodge};
    enum CarModel{Alero, Cruze, Tacoma, Mustang, Miata, Viper};
    enum FirstNames {Bill, Sam, Nate, George, Roger};
    enum LastNames {Smith, Jones, Buxton, Williams, Johnson};
    enum Classes {Knight, Rogue, Mage, Necromancer, Bard};
    enum Factions{Horde, Alliance, Outsiders, Pirates, Merchants};
    enum Countries {England, France, Germany, Spain, Romania};
    enum Church {Catholic, Protestant, Buddhist, Roman, England};
    enum Language {English, Spanish, German, French, Mandarin};

    
    // Start is called before the first frame update
    void Start()
    {
        CarMake make;

        CarModel model;
        make = CarMake.Dodge;
        model = CarModel.Viper;
        print("Car Manufacturer: " + make + " Model: " + model);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Recall(CarMake make, CarModel model) {
        if (make == CarMake.Oldsmobile && model == CarModel.Alero) {
            print("There is a recall of your vehicle due to a faulty ignition, please take your car to the nearest dealer for repair");
        }
        else if (make == CarMake.Ford && model == CarModel.Mustang) {
            print("Why did you buy a mustang?");

        }
        else {
            print("There is no recall notice for your make and model of vehicle");
        }
    }
}
