using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utilites.UserDebug
{
    public static class DebugMessage
    {
        public static void Massage(GameObject objectMassage, Component typesObject, string text)
        {
            Debug.Log($"������! ��� ������� {objectMassage.name}, ��������� {typesObject}, �����: {text}");
        }

        public static void ErrorNullGetComponent<typeNullObject>(GameObject objectMassage, Component component, Component nullObject)
        {
            if (nullObject != null)
                return;
            Debug.LogError($"��������� <color=red>{typeof(typeNullObject)}</color> ����� NULL! � ���������� <color=red>{component}</color> ������� <color=red>{objectMassage.name}</color>");
        }

        public static void NotFoundComponent<typeNullObject>(GameObject objectMassage, Component component, Component notFoundObject)
        {
            if (notFoundObject != null)
                return;
            Debug.LogError($"��������� �� ��� ������ <color=red>{typeof(typeNullObject)}</color> ����� NULL! � ���������� <color=red>{component}</color> ������� <color=red>{objectMassage.name}</color>");
        }

        public static void NotFoundComponents<typeNullObject>(int count, GameObject objectMassage, Component component)
        {
            if (count != 0)
                return;
            Debug.LogError($"������� 0 ��������� <color=red>{typeof(typeNullObject)}</color>! � ���������� <color=red>{component}</color> ������� <color=red>{objectMassage.name}</color>");
        }
    }
}
