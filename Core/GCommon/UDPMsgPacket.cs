using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A2")]
public class UDPMsgPacket : ObjectPoolCallbackBase
{
	[Token(Token = "0x401B266")]
	[FieldOffset(Offset = "0x0")]
	private static SyncedObjectPool<UDPMsgPacket> m_MsgPacketPool;

	[Token(Token = "0x401B267")]
	public const uint UDPMESSAGE_HEADER_MINI_SIZE = 5u;

	[Token(Token = "0x401B268")]
	public const uint UDPMESSAGE_HEADER_RELIABLE_SIZE = 12u;

	[Token(Token = "0x401B269")]
	public const uint UDPMESSAGE_HEADER_NONRELIABLE_SIZE = 8u;

	[Token(Token = "0x401B26A")]
	public const byte UDPMESSAGE_MSGKEY = 108;

	[Token(Token = "0x401B26B")]
	public const byte UDPMESSAGE_SENDOPTION_NONE = 0;

	[Token(Token = "0x401B26C")]
	public const byte UDPMESSAGE_SENDOPTION_HELLO = 1;

	[Token(Token = "0x401B26D")]
	public const byte UDPMESSAGE_SENDOPTION_RELIABLE = 2;

	[Token(Token = "0x401B26E")]
	public const byte UDPMESSAGE_SENDOPTION_BYEBYE = 3;

	[Token(Token = "0x401B26F")]
	public const byte UDPMESSAGE_SENDOPTION_VAR = 4;

	[Token(Token = "0x401B270")]
	public const byte UDPMESSAGE_SENDOPTION_VAR_RELIABLE = 5;

	[Token(Token = "0x401B271")]
	public const uint UDPMESSAGE_FLAG_ENCRYPTION = 1u;

	[Token(Token = "0x401B272")]
	public const uint UDPMESSAGE_FLAG_ZIP = 2u;

	[Token(Token = "0x401B273")]
	[FieldOffset(Offset = "0x9")]
	public byte MsgKey;

	[Token(Token = "0x401B274")]
	[FieldOffset(Offset = "0xA")]
	public byte CRC7;

	[Token(Token = "0x401B275")]
	[FieldOffset(Offset = "0xB")]
	public byte SendOption;

	[Token(Token = "0x401B276")]
	[FieldOffset(Offset = "0xC")]
	public ushort Cmd;

	[Token(Token = "0x401B277")]
	[FieldOffset(Offset = "0xE")]
	public ushort SequenceID;

	[Token(Token = "0x401B278")]
	[FieldOffset(Offset = "0x10")]
	public ushort OrderID;

	[Token(Token = "0x401B279")]
	[FieldOffset(Offset = "0x12")]
	public byte Flags;

	[Token(Token = "0x401B27A")]
	[FieldOffset(Offset = "0x14")]
	public ushort Length;

	[Token(Token = "0x401B27B")]
	[FieldOffset(Offset = "0x18")]
	public byte[] Data;

	[Token(Token = "0x401B27C")]
	[FieldOffset(Offset = "0x1C")]
	public uint TrackingID;

	[Token(Token = "0x601A4C4")]
	[Address(RVA = "0x324390C", Offset = "0x324390C", VA = "0x324390C")]
	public UDPMsgPacket()
	{
	}

	[Token(Token = "0x601A4C5")]
	[Address(RVA = "0x3243914", Offset = "0x3243914", VA = "0x3243914")]
	public static UDPMsgPacket Get()
	{
		return null;
	}

	[Token(Token = "0x601A4C6")]
	[Address(RVA = "0x32439C8", Offset = "0x32439C8", VA = "0x32439C8")]
	public static void Put(UDPMsgPacket p)
	{
	}

	[Token(Token = "0x601A4C7")]
	[Address(RVA = "0x3243AD0", Offset = "0x3243AD0", VA = "0x3243AD0")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x601A4C8")]
	[Address(RVA = "0x3243B80", Offset = "0x3243B80", VA = "0x3243B80", Slot = "7")]
	public override void OnAllocated()
	{
	}

	[Token(Token = "0x601A4C9")]
	[Address(RVA = "0x3243BB8", Offset = "0x3243BB8", VA = "0x3243BB8")]
	public uint Unserialize(UDPSession session, BinaryReader reader, int availableLength)
	{
		return default(uint);
	}

	[Token(Token = "0x601A4CA")]
	[Address(RVA = "0x3244360", Offset = "0x3244360", VA = "0x3244360")]
	public uint Serialize(UDPSession session, BinaryWriter writer)
	{
		return default(uint);
	}

	[Token(Token = "0x601A4CB")]
	[Address(RVA = "0x3244074", Offset = "0x3244074", VA = "0x3244074")]
	public static bool IsReliable(uint cmd, byte sendOption)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4CC")]
	[Address(RVA = "0x324489C", Offset = "0x324489C", VA = "0x324489C")]
	public bool IsReliable()
	{
		return default(bool);
	}

	[Token(Token = "0x601A4CD")]
	[Address(RVA = "0x3244928", Offset = "0x3244928", VA = "0x3244928")]
	public bool IsVarPacket()
	{
		return default(bool);
	}
}
