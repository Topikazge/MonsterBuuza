using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Level
{
    public abstract class LevelBase : MonoBehaviour, IRestart
    {
        public abstract void Restart();
    }
}