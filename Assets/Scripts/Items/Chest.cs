using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField]
    private Sprite openChest;

    public void Open()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
    }
}
