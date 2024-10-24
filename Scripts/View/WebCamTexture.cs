using UnityEngine;
using UnityEngine.UI;

public class WebCamDisplay : MonoBehaviour
{
    private WebCamTexture _webCamTexture;
    public RawImage rawImage; // Drag your RawImage object here in the Inspector

    void Start()
    {
        _webCamTexture = new WebCamTexture();
        rawImage.texture = _webCamTexture; // Assign the webcam texture to the RawImage component
        _webCamTexture.Play();
    }

    void OnDestroy()
    {
        if (_webCamTexture != null)
        {
            _webCamTexture.Stop();
        }
    }

    // Method to get the current webcam texture
    public WebCamTexture GetWebCamTexture()
    {
        return _webCamTexture;
    }
}



