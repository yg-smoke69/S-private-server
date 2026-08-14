using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FDC")]
public class SceneLightmapFile : ScriptableObject
{
	[Token(Token = "0x401AE74")]
	[FieldOffset(Offset = "0xC")]
	public int versionID;

	[Token(Token = "0x401AE75")]
	[FieldOffset(Offset = "0x10")]
	public bool version2018;

	[Token(Token = "0x401AE76")]
	[FieldOffset(Offset = "0x14")]
	public List<LightmapAreaInfoNoRef> areaLightmaps;

	[Token(Token = "0x601A016")]
	[Address(RVA = "0x21C389C", Offset = "0x21C389C", VA = "0x21C389C")]
	public SceneLightmapFile()
	{
	}

	[Token(Token = "0x601A017")]
	[Address(RVA = "0x21C3928", Offset = "0x21C3928", VA = "0x21C3928")]
	public static bool SameID(int[] lhs, int[] rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x601A018")]
	[Address(RVA = "0x21C3A40", Offset = "0x21C3A40", VA = "0x21C3A40")]
	public LightmapAreaInfoNoRef GetAreaLightmap(int[] areaID, bool createIfNotExists = true)
	{
		return null;
	}
}
