using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] private GameObject audioSorce;
    void Aweke()
    {
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag("Music");
        if (musicObjects.Length > 1)
        {
            Destroy(audioSorce);
        }
        else
        {
            DontDestroyOnLoad(audioSorce);
        }
    }

}
