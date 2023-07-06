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
            Debug.Log($"Ошибка! Имя объекта {objectMassage.name}, компонент {typesObject}, текст: {text}");
        }

        public static void ErrorNullGetComponent<typeNullObject>(GameObject objectMassage, Component component, Component nullObject)
        {
            if (nullObject != null)
                return;
            Debug.LogError($"Компонент <color=red>{typeof(typeNullObject)}</color> равен NULL! В компоненте <color=red>{component}</color> объекта <color=red>{objectMassage.name}</color>");
        }

        public static void NotFoundComponent<typeNullObject>(GameObject objectMassage, Component component, Component notFoundObject)
        {
            if (notFoundObject != null)
                return;
            Debug.LogError($"Компонент не был найдет <color=red>{typeof(typeNullObject)}</color> равен NULL! В компоненте <color=red>{component}</color> объекта <color=red>{objectMassage.name}</color>");
        }

        public static void NotFoundComponents<typeNullObject>(int count, GameObject objectMassage, Component component)
        {
            if (count != 0)
                return;
            Debug.LogError($"Найдено 0 элементов <color=red>{typeof(typeNullObject)}</color>! В компоненте <color=red>{component}</color> объекта <color=red>{objectMassage.name}</color>");
        }
    }
}
