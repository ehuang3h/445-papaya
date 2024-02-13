using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class grabBerry : MonoBehaviour
{
    private XRDirectInteractor interactor = null;
    public bool grabbed;

    // Start is called before the first frame update
    void Start()
    {
        interactor = GetComponent<XRDirectInteractor>();
        grabbed = false;
    }

    private void onEnable()
    {
        interactor.onSelectEntered.AddListener(TakeInput);
        interactor.onSelectExited.AddListener(StopInput);
    }

    private void onDisable()
    {
        interactor.onSelectEntered.RemoveListener(TakeInput);
        interactor.onSelectExited.RemoveListener(StopInput);
    }

    private void TakeInput(XRBaseInteractable interactable)
    {
        grabbed = true;
        Debug.Log("grabbing object");
    }

    private void StopInput(XRBaseInteractable interactable)
    {
        grabbed = false;
        Debug.Log("is releasing");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
