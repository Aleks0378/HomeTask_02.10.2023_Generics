using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1
//Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму.
//Створіть клас для кожної істоти Океанаріуму.
//Вони мають містити інформацію про кожну морську істоту.
//Реалізуйте підтримку ітератора для класу «Океанаріум».
//Протестуйте можливість використання foreach для Океанаріуму.
namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish[] f = new Fish[6];
           f[0] = new Angelfish("Bellus angelfish", "Genicanthus bellus",true,
                "Light blue all over. Exhibits strong sexual dimorphism: females have wide black bands, males' bands are orange.", 18);
           f[1] = new Anthias("Bicolor anthias", "Pseudanthias bicolor", true,
                "Similarly shaped and coloured to Bartlett's Anthias, but with a slightly more rounded back.", 13);
           f[2] = new Bass_and_groupers("Blacktip grouper", "Epinephelus fasciatus", false,
               "The tips of the spines of the dorsal fin are black, and it may have a dark red cap above the eyes. There is a variant with a uniformly pale body except for the frontal part.", 40);
           f[3] = new Batfish("Teira batfish", "Platax teira", false,
                "Silver with black fins and a black stripe across the face.", 70);
           f[4] = new Butterflyfish("Longnose butterflyfish", "Forcipiger flavissimus", false,
                "From the pectoral fins forward, black above the eye and silver below, with an exceptionally mouth. Past the pectoral fins, bright yellow with an eyespot on the anal fin.", 22);
           f[5] = new Chromis("Black and gold chromis", "Neoglyphidodon nigroris", true,
                           "Mostly silver, but with a large patch of yellow around the caudal fin and a distinct black line on the operculum.", 13);
            Oceanarium oceanarium = new Oceanarium(f);
            foreach (Fish item in oceanarium) item.Show();
        }
    }
}
