using System;
using System.Collections.Generic;
using GCommon.Trails;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Serializable]
[Token(Token = "0x2003EB7")]
public class TrailManager : MonoBehaviour
{
	[Token(Token = "0x401A7B1")]
	[FieldOffset(Offset = "0xC")]
	public TrailRenderer_Base[] Trails;

	[Token(Token = "0x401A7B2")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<Material, List<PCTrail>> m_MatToTrailList;

	[Token(Token = "0x401A7B3")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<Material, CombineInstance[]> m_CombineInstances;

	[Token(Token = "0x401A7B4")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Material, int> m_TrailCountDic;

	[Token(Token = "0x401A7B5")]
	[FieldOffset(Offset = "0x1C")]
	private Mesh[] combinedMesh;

	[Token(Token = "0x601981B")]
	[Address(RVA = "0x323D97C", Offset = "0x323D97C", VA = "0x323D97C")]
	public TrailManager()
	{
	}

	[Token(Token = "0x601981C")]
	[Address(RVA = "0x323DA3C", Offset = "0x323DA3C", VA = "0x323DA3C")]
	private void Start()
	{
	}

	[Token(Token = "0x601981D")]
	[Address(RVA = "0x323E138", Offset = "0x323E138", VA = "0x323E138")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601981E")]
	[Address(RVA = "0x323EC20", Offset = "0x323EC20", VA = "0x323EC20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601981F")]
	[Address(RVA = "0x323EDE0", Offset = "0x323EDE0", VA = "0x323EDE0")]
	public void AddTrail(Material mat, PCTrail trail)
	{
	}

	[Token(Token = "0x6019820")]
	[Address(RVA = "0x323ECA8", Offset = "0x323ECA8", VA = "0x323ECA8")]
	private void ClearMesh()
	{
	}

	[Token(Token = "0x6019821")]
	[Address(RVA = "0x323EAA8", Offset = "0x323EAA8", VA = "0x323EAA8")]
	private void DrawMesh(Mesh trailMesh, Material trailMaterial)
	{
	}
}
