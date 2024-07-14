using UnityEngine;

public class WatchManager : MonoBehaviour
{
    public GameObject obj1, obj2;
    void Start()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
    }
    public void btnNextClick()
    {
        obj1.SetActive(false);
        obj2.SetActive(true);
    }
    public void btnPrevClick()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
    }
}

// 1. import vuforia sdk, db, liscence
// 2. add AR cam, img target
// 3. add cubes
// 4. add button text mesh pro
// 5. add WatchManager GameObject
// 6. connect gameObject and cubes
// 7. connect buttons to gameObject functions (onClick)
// 8. build apk
