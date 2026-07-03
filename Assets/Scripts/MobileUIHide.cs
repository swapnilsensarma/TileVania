using UnityEngine;

public class MobileUIHide : MonoBehaviour
{
    void Awake()
    {
#if UNITY_STANDALONE
        gameObject.SetActive(false);
#endif
    }
}
