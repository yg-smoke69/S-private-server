using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Serializable]
[Token(Token = "0x2003EBB")]
public class PCTrailRendererData
{
	[Token(Token = "0x401A7C9")]
	[FieldOffset(Offset = "0x8")]
	public Material TrailMaterial;

	[Token(Token = "0x401A7CA")]
	[FieldOffset(Offset = "0xC")]
	public float Lifetime;

	[Token(Token = "0x401A7CB")]
	[FieldOffset(Offset = "0x10")]
	public bool UsingSimpleSize;

	[Token(Token = "0x401A7CC")]
	[FieldOffset(Offset = "0x14")]
	public float SimpleSizeOverLifeStart;

	[Token(Token = "0x401A7CD")]
	[FieldOffset(Offset = "0x18")]
	public float SimpleSizeOverLifeEnd;

	[Token(Token = "0x401A7CE")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationCurve SizeOverLife;

	[Token(Token = "0x401A7CF")]
	[FieldOffset(Offset = "0x20")]
	public bool UsingSimpleColor;

	[Token(Token = "0x401A7D0")]
	[FieldOffset(Offset = "0x24")]
	public Color SimpleColorOverLifeStart;

	[Token(Token = "0x401A7D1")]
	[FieldOffset(Offset = "0x34")]
	public Color SimpleColorOverLifeEnd;

	[Token(Token = "0x401A7D2")]
	[FieldOffset(Offset = "0x44")]
	public Gradient ColorOverLife;

	[Token(Token = "0x401A7D3")]
	[FieldOffset(Offset = "0x48")]
	public bool StretchSizeToFit;

	[Token(Token = "0x401A7D4")]
	[FieldOffset(Offset = "0x49")]
	public bool StretchColorToFit;

	[Token(Token = "0x401A7D5")]
	[FieldOffset(Offset = "0x4C")]
	public float MaterialTileLength;

	[Token(Token = "0x401A7D6")]
	[FieldOffset(Offset = "0x50")]
	public bool UseForwardOverride;

	[Token(Token = "0x401A7D7")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 ForwardOverride;

	[Token(Token = "0x401A7D8")]
	[FieldOffset(Offset = "0x60")]
	public bool ForwardOverrideRelative;

	[Token(Token = "0x6019843")]
	[Address(RVA = "0x323F4E8", Offset = "0x323F4E8", VA = "0x323F4E8")]
	public PCTrailRendererData()
	{
	}
}
