using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002753")]
public class FourSymbolSlider
{
	[Token(Token = "0x400F2E3")]
	[FieldOffset(Offset = "0x8")]
	public byte Camp;

	[Token(Token = "0x400F2E4")]
	[FieldOffset(Offset = "0xC")]
	public UISprite SliderSpr;

	[Token(Token = "0x400F2E5")]
	[FieldOffset(Offset = "0x10")]
	public GameObject EffectGo;

	[Token(Token = "0x400F2E6")]
	[FieldOffset(Offset = "0x14")]
	public ParticleSystem ParticleSys;

	[Token(Token = "0x600F050")]
	[Address(RVA = "0xDEF798", Offset = "0xDEF798", VA = "0xDEF798")]
	public FourSymbolSlider(byte camp, UISprite sliderSpr)
	{
	}
}
