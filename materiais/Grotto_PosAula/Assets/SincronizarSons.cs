using UnityEngine;
using System.Collections;

public class SincronizarSons : MonoBehaviour {

	public void AtivarPegada () {
		//print ("pegada");
		transform.parent.SendMessage("TocarPegada");
	}

	public void AtivarChamado () {
		transform.parent.SendMessage("TocarChamado");
	}
}
