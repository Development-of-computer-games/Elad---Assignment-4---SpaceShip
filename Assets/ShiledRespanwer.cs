using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiledRespanwer : MonoBehaviour
{

    private GameObject currentShield = null;
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] int shieldApperance = 5;
    // [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxXDistance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());

    }


        
    
private IEnumerator SpawnRoutine()
{

  // var shield = this.GetComponent<ShieldThePlayer>();

    while (true)
    {
            // Debug.Log("HEREEEEEEEE " + shield.isShieldExists + " " + shield.shieldTaken);

            yield return new WaitForSeconds(shieldApperance);



            if (currentShield == null)
            {

                yield return new WaitForSeconds(shieldApperance);
                Vector3 positionOfSpawnedObject = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0f);
                    GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
                currentShield = newObject;
                    
                
                
            



            }

          


        }
}
}
