using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    #region data
    [SerializeField]
    private GameObject prefabMob;

    private float timerSummoning= 1f;
    private float timerDelay = 3f;
    #endregion
    #region accessor
    public GameObject PrefabMob { get => prefabMob; set => prefabMob = value; }
    #endregion
    #region methods
    void Start()
    {

    }
    void Update()
    {
        if (Time.time > timerSummoning)
        {
            timerSummoning += timerDelay;
            int i = UIvalues.Score / 100;
            if(i<1)
            { i = 1; }
            for (int j = 0; j < i; j++)
            {
                SummonMob();
            }
        }
    }

    private void SummonMob()
    {
        GameObject spawn;

        float UpOrDown = UnityEngine.Random.Range(-1f,1f);
        float Yvalue = 1;
        if(UpOrDown<=0)
        {
            Yvalue = 0;
        }

        Vector2 position = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0f, 2f), Yvalue, 0));
        if(position.y>Camera.main.transform.position.y)
            spawn = Instantiate(prefabMob, position, new Quaternion(0, 0, 180f, 0));
        else
             spawn = Instantiate(prefabMob,position, Quaternion.identity);
       
    }
    #endregion
}
