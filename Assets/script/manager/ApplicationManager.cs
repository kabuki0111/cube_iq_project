using UnityEngine;
using System.Collections;

public class ApplicationManager : SingletonMonoBehaviour<ApplicationManager> {
    //シーンが遷移してもオブジェクトが吐きされないように対応
    public void Awake(){
        if(this != Instance){
            Destroy(this);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
