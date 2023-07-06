using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Artifact.Counter
{
    internal class ArtifactStatus
    {
        public int Id;
        public bool IsFound;

        public ArtifactStatus(int id, bool isFound)
        {
            Id = id;
            IsFound = isFound;
        }
    }
}
