using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CDA")]
public class AudioDebugInfo : MonoBehaviour
{
	[Token(Token = "0x4011194")]
	[FieldOffset(Offset = "0xC")]
	public UISprite SliderSprite;

	[Token(Token = "0x4011195")]
	[FieldOffset(Offset = "0x10")]
	public UILabel AudioName;

	[Token(Token = "0x4011196")]
	[FieldOffset(Offset = "0x14")]
	public UILabel VolumeRateLabel;

	[Token(Token = "0x6012C57")]
	[Address(RVA = "0x14D1D80", Offset = "0x14D1D80", VA = "0x14D1D80")]
	public AudioDebugInfo()
	{
	}

	[Token(Token = "0x6012C58")]
	[Address(RVA = "0x14D1D88", Offset = "0x14D1D88", VA = "0x14D1D88")]
	public void Init(AudioPlayInfo audio_info, bool have_removed = false)
	{
	}
}
