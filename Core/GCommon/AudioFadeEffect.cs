using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E51")]
internal class AudioFadeEffect
{
	[Token(Token = "0x401A5A0")]
	[FieldOffset(Offset = "0x8")]
	public AudioResource AudioRes;

	[Token(Token = "0x401A5A1")]
	[FieldOffset(Offset = "0xC")]
	public float TargetVolume;

	[Token(Token = "0x401A5A2")]
	[FieldOffset(Offset = "0x10")]
	public bool IsClosed;

	[Token(Token = "0x401A5A3")]
	[FieldOffset(Offset = "0x14")]
	public float volumeChangeSpeed;

	[Token(Token = "0x601951C")]
	[Address(RVA = "0x30709F8", Offset = "0x30709F8", VA = "0x30709F8")]
	public AudioFadeEffect()
	{
	}
}
