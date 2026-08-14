using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003368")]
internal class UISoundEffectComponent : MonoBehaviour
{
	[Token(Token = "0x401393A")]
	[FieldOffset(Offset = "0xC")]
	public string AnimationSound;

	[Token(Token = "0x401393B")]
	[FieldOffset(Offset = "0x10")]
	public string SoundOnStart;

	[Token(Token = "0x401393C")]
	[FieldOffset(Offset = "0x14")]
	public string SoundOnEnable;

	[Token(Token = "0x401393D")]
	[FieldOffset(Offset = "0x18")]
	public string SoundOnClose;

	[Token(Token = "0x6015DD1")]
	[Address(RVA = "0x2059DA8", Offset = "0x2059DA8", VA = "0x2059DA8")]
	public UISoundEffectComponent()
	{
	}

	[Token(Token = "0x6015DD2")]
	[Address(RVA = "0x2059E6C", Offset = "0x2059E6C", VA = "0x2059E6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6015DD3")]
	[Address(RVA = "0x205A080", Offset = "0x205A080", VA = "0x205A080")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6015DD4")]
	[Address(RVA = "0x205A380", Offset = "0x205A380", VA = "0x205A380")]
	public void PlayAnimationSound()
	{
	}

	[Token(Token = "0x6015DD5")]
	[Address(RVA = "0x205A594", Offset = "0x205A594", VA = "0x205A594")]
	private void OnDestroy()
	{
	}
}
