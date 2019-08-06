using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabAmmo;

    public GameObject PrefabAmmo { get => prefabAmmo; set => prefabAmmo = value; }

    private List<GameObject> ammoReserve;

    // Start is called before the first frame update
    void Awaket()
    {
        for (int i = 0; i < 6; i++)
        {
            if (prefabAmmo !=null)
            {

            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
