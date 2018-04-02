using UnityEngine;

public class Hero                                                           //La clase "Hero", que contiene el constructor.
{
    public Hero()                                                           //Este es el contructor de "Hero" en donde se ponen los atributos.
    {
        GameObject he = GameObject.CreatePrimitive(PrimitiveType.Cube);     //Esta línea se encarga de generar un cubo y guardarlo en la variable "he".
        GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");    //Aquí vamos a encontrar un objeto que tenga el tag de "MainCamera", en ese momento se guarda ese objeto encontrado en "cam".

        he.AddComponent<FPSMove>();                                         //Al "he" le añadimos el script "FPSMove" para poder mover al cubo almacenado en "he".
        cam.AddComponent<FPSAim>();                                         //A la cámara guardada en "cam" le agregamos el componente "FPSAim" para mover la cámara.

        cam.transform.position = new Vector3(0,1,0);                        //Le damos ubicación a "cam" con el "Vector3".
        cam.transform.SetParent(he.transform);                              //Y por último la cámara la hacemos hija del cubo en "he" para que se mueva junto con el este.
    }
}
