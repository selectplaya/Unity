using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex); 
    }
    public void LoadByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
