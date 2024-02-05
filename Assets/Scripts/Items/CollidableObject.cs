using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    // Start is called before the first frame update
    private Collider2D z_collider;
    [SerializeField]
    private ContactFilter2D z_filter;
    private List<Collider2D> z_collidedObjects = new List<Collider2D>(1);

    protected virtual void Start()
    {
        z_collider = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        z_collider.OverlapCollider(z_filter, z_collidedObjects);
        foreach (var o in z_collidedObjects)
        {
            if (o is not null)
            {
                OnCollided(o.gameObject);
            }
        }
    }

    protected virtual void OnCollided(GameObject collidedObject)
    {

    }
}
