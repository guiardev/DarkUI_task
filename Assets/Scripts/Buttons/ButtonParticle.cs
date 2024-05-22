using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonParticle : MonoBehaviour{
    
    public ParticleSystem particleSystem;

    public void OnClick(){
        particleSystem.Play();
    }
}
