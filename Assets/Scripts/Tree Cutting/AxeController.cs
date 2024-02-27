using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : MonoBehaviour
{
    public Collider axeTipCollider;
    private Rigidbody axeRb;

    //strength needed to break tree 
    private float breakThreshold = 8f; 

    void Start()
    {
        axeRb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //check if collision is with axe tip's collider
        if (collision.contacts[0].thisCollider == axeTipCollider && collision.gameObject.CompareTag("Tree"))
        {
            //calculate angle of impact
            float impactAngleFactor = Vector3.Dot(-axeTipCollider.transform.right, collision.contacts[0].normal);
            impactAngleFactor = Mathf.Abs(impactAngleFactor);

            //calculate velocity of axe tip
            Vector3 tipVelocity = axeRb.GetPointVelocity(axeTipCollider.transform.position);

            //modify force based on impact angle
            float modifiedForce = tipVelocity.magnitude * impactAngleFactor;

            //check that impact is strong enough to break tree
            if (modifiedForce > breakThreshold)
            {
                collision.gameObject.transform.parent.GetComponent<TreeController>().BreakTree();
            }
        }
    }
}
