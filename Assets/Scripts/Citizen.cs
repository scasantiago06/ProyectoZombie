using UnityEngine;

public class Citizen                                                                            //Esto es una clase que tiene algunas variables y un constructor.
{
    public Citizen(string n, int a)                                                             //Creo el constructor que recibe como argumentos "n" que se encargará del nombre y "a" de la edad.
    {
        GameObject ci = GameObject.CreatePrimitive(PrimitiveType.Sphere);                       //Creo el ciudadano y lo guardo en "ci".
        ci.transform.position = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));   //Ubico a "ci".
        Debug.Log(CitizenMessage(n,a));                                                         //Imprimo el retorno de la función.
        ci.name = "Hola, Soy " + n + " y tengo " + a + " de edad.";                             //Esto es un simple agregado para que el nombre en la jerarquia cambie por el que está despues del igual.
    }

    public string CitizenMessage(string n, int a)                                               //Creo el método que recibe "n" para poder imprimir el nombre y "a" para la edad.
    {
        return "Hola, Soy " + n + " y tengo " + a + " de edad.";                                //Este es el retorno, que se imprimirá en consola.
    }
}
