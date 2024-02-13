using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{

    public Material blue;
    public Material red;
    public Material green;
    private Camera mainCamera;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, 1000))
        {
            if (hit.collider && hit.collider.gameObject == cube)
            {
                foreach (Renderer renderer in hit.collider.GetComponentsInChildren<Renderer>())
                {
                    renderer.material = red;
                }
            }
        }
    }
}
