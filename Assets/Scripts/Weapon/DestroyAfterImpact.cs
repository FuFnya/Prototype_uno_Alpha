using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterImpact : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject);
    }

    /*public void DestroyAfterAnimation()
    {
        Destroy(gameObject);
    }*/
}
