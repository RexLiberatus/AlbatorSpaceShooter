using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    #region data
    [SerializeField]
    private GameObject prefabAmmo;

    [SerializeField]
    private float speed;


    private List<GameObject> ammoReserve;
    [SerializeField]
    private int ammoNumber;

    public Transform mdirectionUp;
    public Transform mdirectionDown;

    #endregion
    #region accessors
    private bool trigger = false;
    public GameObject PrefabAmmo { get => prefabAmmo; set => prefabAmmo = value; }
    public float Speed { get => speed; set => speed = value; }
    public int AmmoNumber { get => ammoNumber; set => ammoNumber = value; }
    #endregion

    // Start is called before the first frame update
    void Awake()
    {

        ammoReserve = new List<GameObject>();
        for (int i = 0; i < ammoNumber; i++)
        {
            ammoReserve.Add(Instantiate(prefabAmmo, transform.position, Quaternion.identity));
        }
    }
    private void Start()
    {
        foreach (var item in ammoReserve)
        {
            item.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            trigger = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            trigger = true;
        }
    }
    public void Shoot()
    {
        Debug.Log("i shoot");
        GameObject ammo = GiveMeTheNextAvailableAmmo();
       ApplyDownOrUpForce(trigger, ammo);

    }
    private void ApplyDownOrUpForce(bool isDown, GameObject ammo)
    {
        if (ammo != null)
        {
            ammo.transform.position = gameObject.transform.position;
            ammo.SetActive(true);

            Debug.Log("Ammo => ", ammo);
            if (isDown)
                ammo.transform.rotation = mdirectionDown.rotation;
            else
                ammo.transform.rotation = mdirectionUp.rotation;
            ammo.GetComponent<Rigidbody2D>().AddForce(isDown ? Vector2.down * speed : Vector2.up * speed, ForceMode2D.Impulse);
            ammo.GetComponent<AmmoBehaviour>().Fired = true;
        }

      
    }

    private GameObject GiveMeTheNextAvailableAmmo()
    {
        
        for (int i = 0; i < ammoReserve.Count; i++)
        {
            if (ammoReserve[i].activeSelf == false)
              return    ammoReserve[i]; 


        }

        return null;
    }

    private bool checkICanFire(bool hasAlreadyShot, int i)
    {
        return ammoReserve[i].activeSelf == false && hasAlreadyShot == true;
    }
}
