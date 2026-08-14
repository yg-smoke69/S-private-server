using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED8")]
internal class BCAMGGOOLBC : UDPClientMessageBase
{
	[Token(Token = "0x4007886")]
	[FieldOffset(Offset = "0xC")]
	public uint KEMHGFBCPKF;

	[Token(Token = "0x6006942")]
	[Address(RVA = "0x3383A40", Offset = "0x3383A40", VA = "0x3383A40")]
	public BCAMGGOOLBC()
	{
	}

	[Token(Token = "0x6006943")]
	[Address(RVA = "0x3383AC4", Offset = "0x3383AC4", VA = "0x3383AC4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006944")]
	[Address(RVA = "0x3383B20", Offset = "0x3383B20", VA = "0x3383B20", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006945")]
	[Address(RVA = "0x3383B3C", Offset = "0x3383B3C", VA = "0x3383B3C", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006946")]
	[Address(RVA = "0x3383B40", Offset = "0x3383B40", VA = "0x3383B40", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
