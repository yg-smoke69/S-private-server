using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FAC")]
internal class KMNMOEFHDLC : UDPClientMessageBase
{
	[Token(Token = "0x4007AED")]
	[FieldOffset(Offset = "0xC")]
	public uint LJEACPLBAGE;

	[Token(Token = "0x6006C94")]
	[Address(RVA = "0x342C198", Offset = "0x342C198", VA = "0x342C198")]
	public KMNMOEFHDLC()
	{
	}

	[Token(Token = "0x6006C95")]
	[Address(RVA = "0x342C21C", Offset = "0x342C21C", VA = "0x342C21C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006C96")]
	[Address(RVA = "0x342C278", Offset = "0x342C278", VA = "0x342C278", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006C97")]
	[Address(RVA = "0x342C294", Offset = "0x342C294", VA = "0x342C294", Slot = "9")]
	public override void Recycle()
	{
	}
}
