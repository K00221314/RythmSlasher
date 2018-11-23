using UnityEngine;
using System.Collections;

public class swordcutter : MonoBehaviour
{

    public Material capMaterial;



    void OnCollisionEnter(Collision collision)
    {


        GameObject victim = collision.collider.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<MeshCollider>();
        //temp.convex = true;


        Destroy(pieces[1], 1);
    }

}




