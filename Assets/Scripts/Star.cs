using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private SpriteRenderer render;

    [Header("Rotation")]
    [SerializeField] private float minRotationSpeed = 0.1f;
    [SerializeField] private float maxRotationSpeed = 0.3f;

    [Header("Scale")]
    [SerializeField] private float minScale = 0.1f;
    [SerializeField] private float maxScale = 1.0f;
    
    [Header("Visibility")]
    [SerializeField] private float minVisibility = 0.1f;
    [SerializeField] private float maxVisibility = 0.3f;

    private float _rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        _rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);

        var scale = Random.Range(minScale, maxScale);
        transform.localScale = Vector3.one * scale;

        var color = render.color;
        color.a = Random.Range(minVisibility, maxVisibility);
        render.color = color;
        
        transform.Rotate(Vector3.forward * Random.Range(0, 365f));
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
    }
}
