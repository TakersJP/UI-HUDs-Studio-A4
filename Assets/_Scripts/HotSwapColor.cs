using UnityEngine;

public class HotSwapColor : MonoBehaviour
{
    public GameObject myPrefab;

    void Start()
    {
        // Loop through 10 GameObjects
        for (int i = 0; i < 10; i++)
        {
            // Instantiate a new GameObject at a unique position
            GameObject newObject = Instantiate(myPrefab, new Vector3(i * 2f, 0, 0), Quaternion.identity);

            // Create a new MaterialPropertyBlock
            MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();

            // Set a random color in the MaterialPropertyBlock
            propertyBlock.SetColor("_Color", Random.ColorHSV());

            // Apply the MaterialPropertyBlock to the GameObject
            newObject.GetComponent<MeshRenderer>().SetPropertyBlock(propertyBlock);
        }
    }
}