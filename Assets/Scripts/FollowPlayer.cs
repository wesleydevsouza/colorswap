using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    void Update() {
        if (player.position.y > transform.position.y) {
            transform.position = new Vector3 ( 0f, player.position.y, -10f);

        }

        //For Debug 
        //if (player.position.y <  transform.position.y) {
        //    transform.position = new Vector3(0f, player.position.y, -10f);
        //}
    }
}
