using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001234")]
internal class ICOGPDCNJEE : UDPClientMessageBase
{
	[Token(Token = "0x40080B7")]
	[FieldOffset(Offset = "0xC")]
	public int AOBJNHBLIFD;

	[Token(Token = "0x60076B6")]
	[Address(RVA = "0x3617DBC", Offset = "0x3617DBC", VA = "0x3617DBC")]
	public ICOGPDCNJEE()
	{
	}

	[Token(Token = "0x60076B7")]
	[Address(RVA = "0x3617E40", Offset = "0x3617E40", VA = "0x3617E40", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60076B8")]
	[Address(RVA = "0x3617E9C", Offset = "0x3617E9C", VA = "0x3617E9C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60076B9")]
	[Address(RVA = "0x3617EB8", Offset = "0x3617EB8", VA = "0x3617EB8", Slot = "9")]
	public override void Recycle()
	{
	}
}
