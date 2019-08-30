using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_MovingSky : MonoBehaviour
{

    public Material m_skyMaterial;
    public float m_offset;
    public float m_speed = 2f;
    bool stopDefault;

    void Update()
    {
        if (!stopDefault)
        {
            Vector2 offset = m_skyMaterial.GetTextureOffset("_MainTex");
            offset.x += Time.deltaTime * m_speed/100;
            if (offset.x < 0)
                offset.x = 1f;
            if (offset.x > 1)
                offset.x = 0f;

            m_skyMaterial.SetTextureOffset("_MainTex", offset);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            stopDefault = true;
            Vector2 offset = m_skyMaterial.GetTextureOffset("_MainTex");
            offset.y += Time.deltaTime * m_speed;
            if (offset.y < 0)
                offset.y = 1f;
            if (offset.y > 1)
                offset.y = 0f;

            m_skyMaterial.SetTextureOffset("_MainTex", offset);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            stopDefault = true;
            Vector2 offset = m_skyMaterial.GetTextureOffset("_MainTex");
            offset.y -= Time.deltaTime * m_speed;
            if (offset.y < 0)
                offset.y = 1f;
            if (offset.y > 1)
                offset.y = 0f;

            m_skyMaterial.SetTextureOffset("_MainTex", offset);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            stopDefault = true;
            Vector2 offset = m_skyMaterial.GetTextureOffset("_MainTex");
            offset.x += Time.deltaTime * m_speed;
            if (offset.x < 0)
                offset.x = 1f;
            if (offset.x > 1)
                offset.x = 0f;

            m_skyMaterial.SetTextureOffset("_MainTex", offset);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            stopDefault = true;
            Vector2 offset = m_skyMaterial.GetTextureOffset("_MainTex");
            offset.x -= Time.deltaTime * m_speed;
            if (offset.x < 0)
                offset.x = 1f;
            if (offset.x > 1)
                offset.x = 0f;

            m_skyMaterial.SetTextureOffset("_MainTex", offset);
        }
        if (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.S))
        { stopDefault = false; }

        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.D))
        { stopDefault=false; }
    }
}