using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ArtBillBoarding
{
    internal class SpriteBillBoarding : MonoBehaviour
    {
        private void Update()
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y,0f);
        }
    }
}
