using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003D1A")]
public class SceneCollection : MonoBehaviour
{
	[Token(Token = "0x4019EC1")]
	[FieldOffset(Offset = "0xC")]
	public string prefixName;

	[Token(Token = "0x4019EC2")]
	[FieldOffset(Offset = "0x10")]
	public string prefixScene;

	[Token(Token = "0x4019EC3")]
	[FieldOffset(Offset = "0x14")]
	public string path;

	[Token(Token = "0x4019EC4")]
	[FieldOffset(Offset = "0x18")]
	public string[] names;

	[Token(Token = "0x4019EC5")]
	[FieldOffset(Offset = "0x1C")]
	public bool xSplitIs;

	[Token(Token = "0x4019EC6")]
	[FieldOffset(Offset = "0x1D")]
	public bool ySplitIs;

	[Token(Token = "0x4019EC7")]
	[FieldOffset(Offset = "0x1E")]
	public bool zSplitIs;

	[Token(Token = "0x4019EC8")]
	[FieldOffset(Offset = "0x20")]
	public int xSize;

	[Token(Token = "0x4019EC9")]
	[FieldOffset(Offset = "0x24")]
	public int ySize;

	[Token(Token = "0x4019ECA")]
	[FieldOffset(Offset = "0x28")]
	public int zSize;

	[Token(Token = "0x4019ECB")]
	[FieldOffset(Offset = "0x2C")]
	public int xLimitsx;

	[Token(Token = "0x4019ECC")]
	[FieldOffset(Offset = "0x30")]
	public int xLimitsy;

	[Token(Token = "0x4019ECD")]
	[FieldOffset(Offset = "0x34")]
	public int yLimitsx;

	[Token(Token = "0x4019ECE")]
	[FieldOffset(Offset = "0x38")]
	public int yLimitsy;

	[Token(Token = "0x4019ECF")]
	[FieldOffset(Offset = "0x3C")]
	public int zLimitsx;

	[Token(Token = "0x4019ED0")]
	[FieldOffset(Offset = "0x40")]
	public int zLimitsy;

	[Token(Token = "0x4019ED1")]
	[FieldOffset(Offset = "0x44")]
	public bool collapsed;

	[Token(Token = "0x4019ED2")]
	[FieldOffset(Offset = "0x48")]
	public int layerNumber;

	[Token(Token = "0x4019ED3")]
	[FieldOffset(Offset = "0x4C")]
	public Color color;

	[Token(Token = "0x601876B")]
	[Address(RVA = "0x21C0F50", Offset = "0x21C0F50", VA = "0x21C0F50")]
	public SceneCollection()
	{
	}
}
