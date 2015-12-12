using UnityEngine;
using System.Collections;

public class ApplicationManager : SingletonMonoBehaviour<ApplicationManager> {
    private BgmSeController bsController;    //BGM & SE
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

        InitController();   //コントローラークラスの初期化
    }


    /*
     * Application Managerの初期設定
     */
    private void InitController(){
        this.bsController = new BgmSeController();   //BGM & SEをコントロールを生成
        this.sceController = new SceneController(); //シーン遷移をコントロールを生成
    }

    /*
     * シーンに遷移する時に使用
     */
    public void Load(string trgScene, bool isSE){
        
    }
}
