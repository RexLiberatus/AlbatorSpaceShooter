using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    #region Data
    bool GodMode=false;
    #endregion
    #region  Accessors
    #endregion
    #region Methods
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Mob")
        {
            Destroy(collision.gameObject);
            if (!GodMode)
            {
                UIvalues.Lives -= 1;
                GodMode = true;
                if (UIvalues.Lives <= 0)
                {
                    //game over screen call here
                }
                else
                {
                    StartCoroutine(DisableDamageFor4sec());
                }
            }
        }
        IEnumerator DisableDamageFor4sec()
        {
            yield return new WaitForSeconds(4f);
            GodMode = false;
        }
    }
    #endregion
}
