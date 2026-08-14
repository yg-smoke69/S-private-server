using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200409D")]
internal class UDP_Ack_Res
{
	[Token(Token = "0x401B24C")]
	[FieldOffset(Offset = "0x8")]
	public ushort Ack;

	[Token(Token = "0x401B24D")]
	[FieldOffset(Offset = "0xC")]
	public uint AckBits;

	[Token(Token = "0x601A4B7")]
	[Address(RVA = "0x324CFA0", Offset = "0x324CFA0", VA = "0x324CFA0")]
	public UDP_Ack_Res()
	{
	}

	[Token(Token = "0x601A4B8")]
	[Address(RVA = "0x324CFA8", Offset = "0x324CFA8", VA = "0x324CFA8")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Token(Token = "0x601A4B9")]
	[Address(RVA = "0x324D014", Offset = "0x324D014", VA = "0x324D014")]
	public void UnSerialize(BinaryReader reader)
	{
	}
}
