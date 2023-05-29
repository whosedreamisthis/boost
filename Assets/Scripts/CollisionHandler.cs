using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Finish":
                Debug.Log("finished game");
                break;
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Untagged":
                SceneManager.LoadScene(0);
                break;
            default:
                Debug.Log("youve bumped into something else");
                break;
        }
    }
}
