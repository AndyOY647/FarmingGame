using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    //player wals into collectable
    //add collectable to player
    //delete collectable from the screen
    public CollectableType type;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player)
        {
            player.inventory.Add(type);
            Destroy(this.gameObject);
        }
    }
}

public enum CollectableType
{
    NONE, SEED
}