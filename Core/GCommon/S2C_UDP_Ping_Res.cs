using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200409F")]
internal class S2C_UDP_Ping_Res : UDPClientMessageBase
{
	[Token(Token = "0x401B24F")]
	[FieldOffset(Offset = "0xC")]
	public int SendTickCount;

	[Token(Token = "0x601A4BD")]
	[Address(RVA = "0x3230EE4", Offset = "0x3230EE4", VA = "0x3230EE4")]
	public S2C_UDP_Ping_Res()
	{
	}

	[Token(Token = "0x601A4BE")]
	[Address(RVA = "0x3230F70", Offset = "0x3230F70", VA = "0x3230F70", Slot = "7")]
	public override void UnSerialize(FastBinaryReader reader)
	{
	}

	[Token(Token = "0x601A4BF")]
	[Address(RVA = "0x3230FA4", Offset = "0x3230FA4", VA = "0x3230FA4", Slot = "6")]
	public override void Serialize(FastBinaryWriter writer)
	{
	}

	[Token(Token = "0x601A4C0")]
	[Address(RVA = "0x3231000", Offset = "0x3231000", VA = "0x3231000", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
