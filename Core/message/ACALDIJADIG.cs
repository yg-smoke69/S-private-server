using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010E7")]
internal class ACALDIJADIG : UDPClientMessageBase
{
	[Token(Token = "0x4007DAF")]
	[FieldOffset(Offset = "0x9")]
	public byte ODAJIKPMLIM;

	[Token(Token = "0x4007DB0")]
	[FieldOffset(Offset = "0xA")]
	public byte OLFDECMJCNC;

	[Token(Token = "0x6007181")]
	[Address(RVA = "0x3374C60", Offset = "0x3374C60", VA = "0x3374C60")]
	public ACALDIJADIG()
	{
	}

	[Token(Token = "0x6007182")]
	[Address(RVA = "0x3374CE4", Offset = "0x3374CE4", VA = "0x3374CE4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007183")]
	[Address(RVA = "0x3374D70", Offset = "0x3374D70", VA = "0x3374D70", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007184")]
	[Address(RVA = "0x3374DA4", Offset = "0x3374DA4", VA = "0x3374DA4", Slot = "9")]
	public override void Recycle()
	{
	}
}
