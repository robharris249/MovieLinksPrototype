using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Submit : MonoBehaviour {

    public MovieLinks movieLinks;

    // Update is called once per frame
    void Update() {

        if(Input.GetKeyDown(KeyCode.Return)) {
            if (!string.IsNullOrEmpty(this.gameObject.GetComponent<TMP_InputField>().text)) {
                movieLinks.MakeGuess(this.gameObject.tag, this.gameObject.GetComponent<TMP_InputField>().text);
                this.gameObject.GetComponent<TMP_InputField>().text = "";
            }
        }
    }
}
