using System.IO;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000A5F")]
internal class ReplayData
{
	[Token(Token = "0x4005BF3")]
	[FieldOffset(Offset = "0x8")]
	public float Time;

	[Token(Token = "0x4005BF4")]
	[FieldOffset(Offset = "0xC")]
	public byte SendOption;

	[Token(Token = "0x4005BF5")]
	[FieldOffset(Offset = "0xE")]
	public ushort Cmd;

	[Token(Token = "0x4005BF6")]
	[FieldOffset(Offset = "0x10")]
	public ushort Length;

	[Token(Token = "0x4005BF7")]
	[FieldOffset(Offset = "0x14")]
	public byte[] Data;

	[Token(Token = "0x6005055")]
	[Address(RVA = "0x197C4F8", Offset = "0x197C4F8", VA = "0x197C4F8")]
	public ReplayData()
	{
	}

	[Token(Token = "0x6005056")]
	[Address(RVA = "0x197C500", Offset = "0x197C500", VA = "0x197C500")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Token(Token = "0x6005057")]
	[Address(RVA = "0x197C660", Offset = "0x197C660", VA = "0x197C660")]
	public void Deserialize(BinaryReader reader)
	{
	}

	[Token(Token = "0x6005058")]
	[Address(RVA = "0x197C7DC", Offset = "0x197C7DC", VA = "0x197C7DC")]
	public ReplayData Clone()
	{
		return null;
	}

	[Token(Token = "0x6005059")]
	[Address(RVA = "0x197C9C0", Offset = "0x197C9C0", VA = "0x197C9C0")]
	public static implicit operator ReplayData(UDPMsgPacket packet)
	{
		return null;
	}

	[Token(Token = "0x600505A")]
	[Address(RVA = "0x197CB98", Offset = "0x197CB98", VA = "0x197CB98")]
	public static implicit operator UDPMsgPacket(ReplayData replay)
	{
		return null;
	}
}
