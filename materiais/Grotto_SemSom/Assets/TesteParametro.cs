using UnityEngine;
using System.Collections;

public class TesteParametro : MonoBehaviour {

    FMODUnity.StudioEventEmitter emitter;

	void Start () {
        emitter = GetComponent<FMODUnity.StudioEventEmitter>();
	}
	
	void Update () {
        emitter.SetParameter("Filtro", Time.time * 0.05f);
	}
}
