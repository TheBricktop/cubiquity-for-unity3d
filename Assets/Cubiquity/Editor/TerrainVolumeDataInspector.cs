﻿using UnityEngine;
using UnityEditor;

using System.Collections;

namespace Cubiquity
{	
	[CustomEditor (typeof(TerrainVolumeData))]
	public class TerrainVolumeDataInspector : Editor
	{
		public override void OnInspectorGUI()
		{
			TerrainVolumeData data = target as TerrainVolumeData;
			
			EditorGUILayout.LabelField("Full path to voxel database:", EditorStyles.boldLabel);
			EditorGUILayout.HelpBox(data.fullPathToVoxelDatabase, MessageType.None);
		}
	}
}