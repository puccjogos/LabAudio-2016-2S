using UnityEngine;
using System.Collections;

public class DispararSonsFMOD : MonoBehaviour {

    [FMODUnity.EventRef]
    public string eventoPulo;

    [FMODUnity.EventRef]
    public string eventoQueda;

    void ComecouPulo() {
        TocarSom(eventoPulo);
    }

    void Caiu() {
        TocarSom(eventoQueda);
    }

    void TocarSom (string nomeEvento) {
        FMOD.Studio.EventInstance evento;
        evento = FMODUnity.RuntimeManager.CreateInstance(nomeEvento);
        evento.start();
        evento.release();
    }
}
