
using UnityEngine;

public class Bomping : MonoBehaviour
{
    public Rigidbody rigid;

    public Vector3 force;

    private void OnCollisionEnter(Collision collision)
    {
        rigid.AddForce(force);
    }
}
