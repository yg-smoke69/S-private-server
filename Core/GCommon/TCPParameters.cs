using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004092")]
public static class TCPParameters
{
	[Token(Token = "0x2004093")]
	public delegate DisconnectedReason KickByServerMsgDeserializer(TCPMsgPacket packet);

	[Token(Token = "0x401B216")]
	[FieldOffset(Offset = "0x0")]
	public static double DEFAULT_DEACTIVE_TIME;

	[Token(Token = "0x401B217")]
	[FieldOffset(Offset = "0x8")]
	public static double BACKGROUND_DEACTIVE_TIME;

	[Token(Token = "0x401B218")]
	[FieldOffset(Offset = "0x10")]
	public static double KEEP_ALIVE_INTERVAL_TIME;

	[Token(Token = "0x401B219")]
	[FieldOffset(Offset = "0x18")]
	public static byte DEFAULT_REGION;

	[Token(Token = "0x401B21A")]
	[FieldOffset(Offset = "0x1C")]
	public static int JOIN_TIMEOUT;

	[Token(Token = "0x401B21B")]
	[FieldOffset(Offset = "0x20")]
	public static byte KICK_BY_SERVER_MSG_CMD;

	[Token(Token = "0x401B21C")]
	[FieldOffset(Offset = "0x24")]
	public static KickByServerMsgDeserializer KICK_BY_SERVER_MSG_DESERIALIZER;

	[Token(Token = "0x401B21D")]
	[FieldOffset(Offset = "0x28")]
	public static EProtoDataType PROTO_DATA_TYPE;

	[Token(Token = "0x401B21E")]
	[FieldOffset(Offset = "0x2C")]
	public static int TCP_MTU;
}
