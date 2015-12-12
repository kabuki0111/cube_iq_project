using UnityEngine;
using System.Collections;

public class ApplicationManager : SingletonMonoBehaviour<ApplicationManager> {
    [SerializeField]
    private BgmSeController bsController;    //BGM & SE
    [SerializeField]
    private SceneController sceController;  //シーン


    /*
     * BGM SEコントローラーのプロパティ
     */
    public BgmSeController BsController{
        get{return this.bsController;}
    }

    /*
     * シーン遷移コントローラのプロパティ
     */
    public SceneController SceController{
        get{return this.sceController;}
    }

    public void Awake(){
        if(this != Instance){
            Destroy(this);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
        

    /*
     * シーンに遷移する時に使用
     */
    public void Load(string trgScene, bool isSE){
        
    }
}
