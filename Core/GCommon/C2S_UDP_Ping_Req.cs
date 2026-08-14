using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200409E")]
internal class C2S_UDP_Ping_Req : UDPClientMessageBase
{
	[Token(Token = "0x401B24E")]
	[FieldOffset(Offset = "0xC")]
	public int SendTickCount;

	[Token(Token = "0x601A4BA")]
	[Address(RVA = "0x307E000", Offset = "0x307E000", VA = "0x307E000")]
	public C2S_UDP_Ping_Req()
	{
	}

	[Token(Token = "0x601A4BB")]
	[Address(RVA = "0x307E084", Offset = "0x307E084", VA = "0x307E084", Slot = "6")]
	public override void Serialize(FastBinaryWriter writer)
	{
	}

	[Token(Token = "0x601A4BC")]
	[Address(RVA = "0x307E0E0", Offset = "0x307E0E0", VA = "0x307E0E0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader reader)
	{
	}
}
