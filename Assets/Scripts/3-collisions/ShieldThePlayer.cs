using System.Collections;
using UnityEngine;


public class ShieldThePlayer : MonoBehaviour {
    [Tooltip("The number of seconds that the shield remains active")] [SerializeField] float duration;

    private string shieldTag = "shieldImage";




    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Shield triggered by player");
            // we wanna take control on the DestroyOnTrigger component which belongs to the player and disable it when haveing shield.
            var destroyComponent = other.GetComponent<DestroyOnTrigger2D>();
            // this one is for having defence while wearing shield from the boss laser.
            var destroyLaser = other.GetComponent<DestroyOnLaserBossTrigger>();



            // we wanna take control on the child of the space craft which is the picture of the shild and make it appers when havnig shield.
            //GameObject shieldComponent = other.transform.GetChild("shieldImage").gameObject; // by tag!
            var shieldComponent = GameObject.FindWithTag(shieldTag);
           
            var shield =  shieldComponent.GetComponent<SpriteRenderer>();
            if (destroyComponent) {
           
               // isShieldExists = false;
                shield.enabled = true;
                destroyComponent.StartCoroutine(ShieldTemporarily(destroyComponent,shield,destroyLaser, shieldComponent));
                // NOTE: If you just call "StartCoroutine", then it will not work, 
                //       since the present object is destroyed!
                // Destroy the shield itself - prevent double-use
                Debug.Log("About to destroy");
                Destroy(this.gameObject);

            }
        } else {
            Debug.Log("Shield triggered by "+other.name);
        }
    }
    private IEnumerator ShieldTemporarily(DestroyOnTrigger2D destroyComponent , SpriteRenderer shield , DestroyOnLaserBossTrigger laserDestroy, GameObject playerShiled) {
        destroyComponent.enabled = false;
        // this one is for having defence while wearing shield from the boss laser.
        laserDestroy.enabled = false;
        // var fade = shield.GetComponent<FadeOut>();
        //fade.enabled = true;
        var temp = playerShiled;


        //  LeanTween.alpha(temp,0.0f, 5f);
        LeanTween.alpha(temp, 0f, 5f).setEase(LeanTweenType.linear);
        for (float i = duration; i > 0; i--) {
            Debug.Log("Shield: " + i + " seconds remaining!");
         
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Shield gone!");

        LeanTween.alpha(temp, 1f, 0.5f).setEase(LeanTweenType.linear);

        shield.enabled = false;
        laserDestroy.enabled = true;
        destroyComponent.enabled = true;
      
    }
}
