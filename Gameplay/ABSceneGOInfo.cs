using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D29")]
public class ABSceneGOInfo
{
	[Token(Token = "0x4019F08")]
	[FieldOffset(Offset = "0x8")]
	public int m_id;

	[Token(Token = "0x4019F09")]
	[FieldOffset(Offset = "0xC")]
	public int m_prefabID;

	[Token(Token = "0x4019F0A")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_pos;

	[Token(Token = "0x4019F0B")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_rotation;

	[Token(Token = "0x4019F0C")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 m_scale;

	[Token(Token = "0x4019F0D")]
	[FieldOffset(Offset = "0x38")]
	public string m_previewName;

	[Token(Token = "0x4019F0E")]
	[FieldOffset(Offset = "0x3C")]
	public List<ABSceneLightMapInfo> m_lightmapInfoList;

	[Token(Token = "0x4019F0F")]
	[FieldOffset(Offset = "0x40")]
	public ABLevelObjectInfo LevelObjectInfo;

	[Token(Token = "0x601878F")]
	[Address(RVA = "0x35BBB00", Offset = "0x35BBB00", VA = "0x35BBB00")]
	public ABSceneGOInfo(int id, int prefabid, Vector3 pos, Quaternion rotation, Vector3 scale, string previewname, List<ABSceneLightMapInfo> lightmapInfoList)
	{
	}

	[Token(Token = "0x6018790")]
	[Address(RVA = "0x35BBB78", Offset = "0x35BBB78", VA = "0x35BBB78")]
	public ABSceneGOInfo(int prefabid, Vector3 pos, Quaternion rotation, Vector3 scale, string previewname, List<ABSceneLightMapInfo> lightmapInfoList)
	{
	}
}
