using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public CinemachineVirtualCamera vcamObj;

    public float[] positionsToChangeText;

    public string[] textsOfNarration;

    private CinemachineTrackedDolly vcamComponent;
    private int currentIndexNarration;

    // Start is called before the first frame update
    void Start()
    {
        vcamComponent = vcamObj.GetCinemachineComponent<CinemachineTrackedDolly>();
        currentIndexNarration = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach (float pos in positionsToChangeText) {
            if (vcamComponent.m_PathPosition >= pos) {
                //talvez precise adicionar +1 abaixo
                currentIndexNarration = i;
            }
            i++;
        }

        if (currentIndexNarration == 0) {
            gameObject.GetComponent<TextMeshProUGUI>().text = textsOfNarration[0];
        }
        if (currentIndexNarration == 1) {
            gameObject.GetComponent<TextMeshProUGUI>().text = textsOfNarration[1];
        }
        if (currentIndexNarration == 2) {
            gameObject.GetComponent<TextMeshProUGUI>().text = textsOfNarration[2];
        }
    }
}
