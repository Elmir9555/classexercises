using System;
namespace homeworkclassierarxiya
{
    public class animal
    {
        public string animalname;
        public string animalcolor;
        public int animalage;
        public string sex;

        public string AnimalFeatures()
        {
            return ($"animalname:{animalname} animalcolor:{animalcolor} animalage:{animalage} sex:{sex}");
        }
    }
}
