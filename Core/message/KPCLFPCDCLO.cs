using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010D9")]
internal class KPCLFPCDCLO : UDPClientMessageBase
{
	[Token(Token = "0x4007D9A")]
	[FieldOffset(Offset = "0x9")]
	public byte ENDKPAMOCPM;

	[Token(Token = "0x4007D9B")]
	[FieldOffset(Offset = "0xA")]
	public bool PONMIPOAFFI;

	[Token(Token = "0x6007149")]
	[Address(RVA = "0x342CB38", Offset = "0x342CB38", VA = "0x342CB38")]
	public KPCLFPCDCLO()
	{
	}

	[Token(Token = "0x600714A")]
	[Address(RVA = "0x342CBBC", Offset = "0x342CBBC", VA = "0x342CBBC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600714B")]
	[Address(RVA = "0x342CC50", Offset = "0x342CC50", VA = "0x342CC50", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600714C")]
	[Address(RVA = "0x342CC84", Offset = "0x342CC84", VA = "0x342CC84", Slot = "9")]
	public override void Recycle()
	{
	}
}
