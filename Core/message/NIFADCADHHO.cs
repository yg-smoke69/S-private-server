using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001252")]
internal class NIFADCADHHO : UDPClientMessageBase
{
	[Token(Token = "0x40080F5")]
	[FieldOffset(Offset = "0x9")]
	public byte HHKPOIACIGD;

	[Token(Token = "0x600772E")]
	[Address(RVA = "0x3647134", Offset = "0x3647134", VA = "0x3647134")]
	public NIFADCADHHO()
	{
	}

	[Token(Token = "0x600772F")]
	[Address(RVA = "0x36471B8", Offset = "0x36471B8", VA = "0x36471B8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007730")]
	[Address(RVA = "0x3647214", Offset = "0x3647214", VA = "0x3647214", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007731")]
	[Address(RVA = "0x3647230", Offset = "0x3647230", VA = "0x3647230", Slot = "9")]
	public override void Recycle()
	{
	}
}
