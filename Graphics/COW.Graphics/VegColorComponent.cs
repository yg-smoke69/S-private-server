using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x200403B")]
public class VegColorComponent : MonoBehaviour
{
	[Token(Token = "0x401B039")]
	[FieldOffset(Offset = "0xC")]
	public List<VegColorRatio> m_vegColorRatioList;

	[Token(Token = "0x401B03A")]
	[FieldOffset(Offset = "0x10")]
	public bool m_randomScaleSize;

	[Token(Token = "0x601A276")]
	[Address(RVA = "0x1D51F3C", Offset = "0x1D51F3C", VA = "0x1D51F3C")]
	public VegColorComponent()
	{
	}
}
