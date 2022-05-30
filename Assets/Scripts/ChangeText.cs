using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeText : MonoBehaviour
{
    public CinemachineVirtualCamera vcamObj;
    private CinemachineTrackedDolly vcamComponent;

    // Start is called before the first frame update
    void Start()
    {
        vcamComponent = vcamObj.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vcamComponent.m_PathPosition >= 1) {
            Debug.Log("maior que 1 porraaaa");
        }
    }
}
