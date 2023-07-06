using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Artifact.ArtifactCore;

namespace Assets.Scripts.Artifact.Counter
{
    internal interface ICountArtifact
    {
        public void AddFoundArtifact(ElderArtifact elderArtifact);
    }
}
