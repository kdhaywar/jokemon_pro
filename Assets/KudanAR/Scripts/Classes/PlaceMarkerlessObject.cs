using UnityEngine;
using System.Collections;

namespace Kudan.AR
{
    public class PlaceMarkerlessObject : MonoBehaviour
    {
        public KudanTracker _kudanTracker;

        public void PlaceClick()
        {
            Vector3 position;
            Quaternion orientation;

            _kudanTracker.FloorPlaceGetPose(out position, out orientation);
            _kudanTracker.ArbiTrackStart(position, orientation);
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


