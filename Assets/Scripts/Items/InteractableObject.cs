using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : CollidableObject
{
    [SerializeField]
    private UnityEvent interact;

    private bool interacted;
    protected override void OnCollided(GameObject collidedObject)
    {
        if (Input.GetKey(KeyCode.E))
        {
            OnInteract();
        }
    }

    private void OnInteract()
    {
        if (!interacted)
        {
            interacted = true;
            interact?.Invoke();
        }
    }
}
