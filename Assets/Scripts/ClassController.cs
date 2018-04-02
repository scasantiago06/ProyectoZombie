using System.Collections;
using UnityEngine;

public class ClassController : MonoBehaviour                                                                    //Esta clase se encarga de hacer las instancias.
{
    WaitForSeconds waitSeconds = new WaitForSeconds(0.3f);                                                      //Defino una variable "WaitForSeconds" para no tener que crear nuevas en cada repetición.
    int calls;                                                                                                  //Creo un "int" llamado "calls".
    int whichInstance;                                                                                          //Creo un "int" llamado "whichInstance".
    int j;                                                                                                      //Creo un "int" llamado "j".
    int ages;                                                                                                   //Creo un "int" llamado "ages".
    string[] names = new string[]                                                                               //Creo una matriz donde guardo en las próximas dos líneas 20 nombres para después acceder a ellos.
    {
        "Stubbs", "Rob", "Rodolfo", "Arnulfo", "Jesús", "Cristian", "Santiago", "Alonso", "Dios", "Samuel",
        "Ricardo", "José", "Armando", "Luna", "María", "Mónica", "Manuela", "Cristobal", "Furgo", "Andrés"
    };

    void Start ()                                       
    {
        new Hero();
        calls = Random.Range(4, 10);
        Debug.Log("Instancias Totales: " + calls);
        StartCoroutine("Instances");
    }

    IEnumerator Instances()
    {
        yield return waitSeconds;

        for (int i = 0; i < calls; i++)
        {
            whichInstance = Random.Range(1, 3);
            ages = Random.Range(15,101);
            j = Random.Range(0, names.Length);

            if (whichInstance == 1)
            {
                new Zombie();
            }
            else
            {
                new Citizen(names[j], ages);
            }
        }
    }
}
