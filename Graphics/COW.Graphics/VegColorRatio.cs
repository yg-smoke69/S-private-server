using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
[Token(Token = "0x200403A")]
public class VegColorRatio
{
	[Token(Token = "0x401B036")]
	[FieldOffset(Offset = "0x8")]
	public Color m_color;

	[Token(Token = "0x401B037")]
	[FieldOffset(Offset = "0x18")]
	public float m_ratio;

	[Token(Token = "0x401B038")]
	[FieldOffset(Offset = "0x1C")]
	public float m_scale;

	[Token(Token = "0x601A275")]
	[Address(RVA = "0x1D51F4C", Offset = "0x1D51F4C", VA = "0x1D51F4C")]
	public VegColorRatio()
	{
	}
}
