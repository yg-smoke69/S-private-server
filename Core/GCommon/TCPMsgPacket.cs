using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004094")]
public class TCPMsgPacket
{
	[Token(Token = "0x401B21F")]
	public const uint TCPMESSAGE_CMD_HEADER_SIZE = 1u;

	[Token(Token = "0x401B220")]
	public const uint TCPMESSAGE_LENGTH_HEADER_SIZE = 4u;

	[Token(Token = "0x401B221")]
	public const uint TCPMESSAGE_HEADER_SIZE = 5u;

	[Token(Token = "0x401B222")]
	[FieldOffset(Offset = "0x8")]
	public byte Cmd;

	[Token(Token = "0x401B223")]
	[FieldOffset(Offset = "0x9")]
	public byte Region;

	[Token(Token = "0x401B224")]
	[FieldOffset(Offset = "0xC")]
	public int Length;

	[Token(Token = "0x401B225")]
	[FieldOffset(Offset = "0x10")]
	public byte[] Data;

	[Token(Token = "0x601A480")]
	[Address(RVA = "0x32391B0", Offset = "0x32391B0", VA = "0x32391B0")]
	public TCPMsgPacket()
	{
	}

	[Token(Token = "0x601A481")]
	[Address(RVA = "0x32391B8", Offset = "0x32391B8", VA = "0x32391B8")]
	public uint Unserialize(BinaryReader reader)
	{
		return default(uint);
	}

	[Token(Token = "0x601A482")]
	[Address(RVA = "0x32392B8", Offset = "0x32392B8", VA = "0x32392B8")]
	public void Serialize(BinaryWriter writer)
	{
	}
}
