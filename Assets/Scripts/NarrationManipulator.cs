using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrationManipulator : MonoBehaviour
{
    public AudioClip[] narracoes;
    private AudioSource audioSource;
    private int currentNarracao;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentNarracao = 0;
        audioSource.clip = narracoes[currentNarracao];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying) {

            if (currentNarracao < narracoes.Length - 1) {
                currentNarracao++;
                audioSource.clip = narracoes[currentNarracao];
                audioSource.Play();
            }
        }
    }
}
