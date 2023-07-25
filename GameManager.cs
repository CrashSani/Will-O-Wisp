using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //prefabs

    public GameObject prefabFire;
    public GameObject prefabWater;
    public GameObject prefabGrass;

    Fire Firetype;
    Watertype Water;
    GrassType grass;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

     void SummonPokemon()
    {
        GameObject obj = Instantiate(prefabFire);
        firetype = obj.GetComponent<Fire>();



        obj = Instantiate(prefabGrass);


        GameObject obj = Instantiate(prefabGrass);




    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
