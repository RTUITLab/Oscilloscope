using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTry : MonoBehaviour
{
    public GameObject Particle;
    public float A;
    public float V;
    public float F;
    public float Speed;
    public float Delay;
    private float TempParam;
    private Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = Particle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position += new Vector3(Time.deltaTime*Speed, 0);
    // Main.position += new Vector3(Time.deltaTime * Speed, 0);
        //Special.transform.position = new Vector3(Special.transform.position.x + Time.deltaTime * Speed, A * (float)System.Math.Sin(2 * System.Math.PI * V * Time.time * Speed + F));
        // Special.transform.position += new Vector3(-Time.deltaTime* Speed, 0);

        Particle.transform.position = new Vector3(Particle.transform.position.x + Time.deltaTime * Speed, A * (float)System.Math.Sin(2 * System.Math.PI * V * TempParam * Speed + F));
        TempParam+=Time.deltaTime;
        Particle.transform.GetComponent<ParticleSystem>().startLifetime = Delay;
        if (TempParam > Delay)
        {
            Particle.transform.GetComponent<ParticleSystem>().Stop();
            Particle.transform.position = StartPos;
            TempParam = 0;
            Particle.transform.GetComponent<ParticleSystem>().Play();
        }
    }
}
