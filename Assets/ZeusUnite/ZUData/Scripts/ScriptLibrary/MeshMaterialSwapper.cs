using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UniteScripts
{
    public class MeshMaterialSwapper : MonoBehaviour
    {
        [SerializeField] Material m_DirtyMaterial;

        MeshRenderer[] m_MeshRenderer;
        List<List<Material>> m_OriginalMeshMaterials;

        [SerializeField] bool m_IsMeshDirty = false;

        private void OnValidate()
        {
            if (m_OriginalMeshMaterials == null)
            {
                m_MeshRenderer = GetComponentsInChildren<MeshRenderer>();

                m_OriginalMeshMaterials = new List<List<Material>>();

                for (int i = 0; i < m_MeshRenderer.Length; i++)
                {
                    m_OriginalMeshMaterials.Add(m_MeshRenderer[i].materials.ToList());
                }
            }

            if (m_IsMeshDirty)
            {
                SetSecondaryMaterials();
                return;
            }

            RecoverOriginalMaterials();
        }

        //void Start()
        //{
        //    m_MeshRenderer = GetComponentsInChildren<MeshRenderer>();

        //    m_OriginalMeshMaterials = new List<List<Material>>();

        //    for (int i = 0; i < m_MeshRenderer.Length; i++)
        //    {
        //        m_OriginalMeshMaterials.Add(m_MeshRenderer[i].materials.ToList());
        //    }
        //}

        void RecoverOriginalMaterials()
        {
            for (int i = 0; i < m_MeshRenderer.Length; i++)
            {
                m_MeshRenderer[i].materials = m_OriginalMeshMaterials[i].ToArray();
            }
        }


        void SetSecondaryMaterials()
        {
            if (m_DirtyMaterial == null)
                return;

            for (int i = 0; i < m_MeshRenderer.Length; i++)
            {
                m_MeshRenderer[i].material = m_DirtyMaterial;
            }
        }

    }
}