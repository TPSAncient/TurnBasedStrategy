using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.System
{
    public abstract class UnityMonoBehaviour
    {
        public virtual void Awake() { }
        public virtual void Start() { }
        public virtual void Update() { }
    }
}
