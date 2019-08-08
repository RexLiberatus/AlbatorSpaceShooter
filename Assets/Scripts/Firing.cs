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

    [SerializeField]
    private List<GameObject> ammoReserve;

    public Transform mdirectionUp;
    public Transform mdirectionDown;

    #endregion
    #region accessors
    private bool trigger = false;
    public GameObject PrefabAmmo { get => prefabAmmo; set => prefabAmmo = value; }
    public float Speed { get => speed; set => speed = value; }
    #endregion

    // Start is called before the first frame update
    void Awake()
    {

        ammoReserve = new List<GameObject>();
        for (int i = 0; i < 6; i++)
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
        ammo.transform.position = gameObject.transform.position;
        ammo.SetActive(true);
        Debug.Log("Ammo => ", ammo);

        if (isDown)
            ammo.transform.rotation = mdirectionDown.rotation;
        else
            ammo.transform.rotation = mdirectionUp.rotation;

        ammo.GetComponent<Rigidbody2D>().AddForce( isDown ? Vector2.down*speed : Vector2.up * speed, ForceMode2D.Impulse);
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
