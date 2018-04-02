using UnityEngine;

public class Zombie                                                                                 //La clase "Zombie" que contiene unas variables y el constructor.
{
    int numColor;                                                                                   //Creo una variable de tipo "int" para controlar dependiendo del número el color del zombie.
    string zoColor;                                                                                 //"zoColor" es una variable de tipo "string" para guardar el caracteres el color.

    public Zombie()                                                                                 //Este es el constructor "Zombie".
    {
        numColor = Random.Range(0, 3);                                                              //En esta línea inicializamos "numColor" como un aleatorio con tres posibilidades, cero, uno o dos.
        GameObject zo = GameObject.CreatePrimitive(PrimitiveType.Capsule);                          //Creo el zombie y lo guardo en "zo".
        zo.transform.position = new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10));    //Ubico el "zo" en alguna posición.

        switch (numColor)                                                                           //Creo un "switch" con "numColor" como condición.
        {
            case 0:                                                                                 //En caso que el número sea cero, entra a lo siguiente.
                zo.GetComponent<Renderer>().material.color = Color.cyan;                            //El Zombie se pinta de color "Cyan".
                zoColor = "Cyan";                                                                   //En el "string" guardo la palabra "Cyan".
                break;                                                                              //Rompo el "switch".
            case 1:                                                                                 //En caso que el número sea uno, entra a lo siguiente.
                zo.GetComponent<Renderer>().material.color = Color.green;                           //El Zombie se pinta de color "Green".
                zoColor = "Green";                                                                  //En el "string" guardo la palabra "Green".
                break;                                                                              //Rompo el "switch".
            case 2:                                                                                 //En caso que el número sea dos, entra a lo siguiente.
                zo.GetComponent<Renderer>().material.color = Color.magenta;                         //El Zombie se pinta de color "Magenta".
                zoColor = "Magenta";                                                                //En el "string" guardo la palabra "Magenta".
                break;                                                                              //Rompo el "switch".
            default:                                                                                //Este es el caso "default" no se hace nada.
                break;                                                                              //Rompo el "switch".
        }
        Debug.Log(ZombieMessage(zoColor));                                                          //Imprimo en la consola el método "ZombieMessage" que retorna un "string".
        zo.name = "Soy un Zombie de color " + zoColor;                                              //Esto es un simple agregado para que el nombre en la jerarquia cambie por el que está despues del igual.
    }

    public string ZombieMessage(string zc)                                                          //Creo la función que retornará un "string", y recibe como argumento el color del zombie como "string".
    {
        return "Soy un Zombie de color " + zc;                                                      //Este es el retorno, que se imprimirá en consola.
    }
}
