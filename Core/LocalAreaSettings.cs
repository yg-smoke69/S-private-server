using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D14")]
public class LocalAreaSettings : ScriptableObject
{
	[Token(Token = "0x4019EA1")]
	[FieldOffset(Offset = "0xC")]
	public bool collectionsCollapsed;

	[Token(Token = "0x4019EA2")]
	[FieldOffset(Offset = "0x10")]
	public int listSizeCollections;

	[Token(Token = "0x4019EA3")]
	[FieldOffset(Offset = "0x14")]
	public List<SceneCollection> currentCollections;

	[Token(Token = "0x4019EA4")]
	[FieldOffset(Offset = "0x18")]
	public bool showLoadingPoint;

	[Token(Token = "0x4019EA5")]
	[FieldOffset(Offset = "0x1C")]
	public int distanceFromCenter;

	[Token(Token = "0x4019EA6")]
	[FieldOffset(Offset = "0x20")]
	public bool tiles;

	[Token(Token = "0x4019EA7")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 CenterPoint;

	[Token(Token = "0x6018753")]
	[Address(RVA = "0x1C63880", Offset = "0x1C63880", VA = "0x1C63880")]
	public LocalAreaSettings()
	{
	}
}
