using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup_Control : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    float input;
    void Update()
    {
        input = SimpleInput.GetAxis("Horizontal");
        if (input < 0&&transform.position.x>-4)
        {
            transform.position=Vector3.Lerp(transform.position, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), 1f * Time.deltaTime);
        }
        else if (input > 0&&transform.position.x<4)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 3f, transform.position.y, transform.position.z), 1f * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * .8f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            _gameManager.Collectables();
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            other.gameObject.SetActive(false);
            _gameManager.Obstacles();
        }
    }
}
