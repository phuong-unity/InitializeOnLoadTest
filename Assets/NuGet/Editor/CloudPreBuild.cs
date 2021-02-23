//#if UNITY_CLOUD_BUILD

using NUnit.Framework;
using NugetForUnity;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CloudPreBuild : MonoBehaviour
{
    public static void NugetRestore()
    {
        Debug.Log("UnityCloudBuild - CloudPreBuild - NugetRestore started");
        NugetHelper.Restore();
    }    
}

[InitializeOnLoad]
public static class NugetCloudHelper
{
    static NugetCloudHelper()
    {
        Debug.Log("UnityCloudBuild - NugetCloudHelper - NugetRestore started");
        NugetHelper.Restore();
    }
}

//#endif
