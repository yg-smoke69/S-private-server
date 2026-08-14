using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD2")]
public class MessageQueueConfigDesc
{
	[Token(Token = "0x400A8CF")]
	[FieldOffset(Offset = "0x8")]
	public bool is_open;

	[Token(Token = "0x400A8D0")]
	[FieldOffset(Offset = "0xC")]
	public uint consumer_num_per_channel;

	[Token(Token = "0x400A8D1")]
	[FieldOffset(Offset = "0x10")]
	public uint handler_num_per_consumer;

	[Token(Token = "0x400A8D2")]
	[FieldOffset(Offset = "0x14")]
	public uint max_in_fight_per_consumer;

	[Token(Token = "0x600812F")]
	[Address(RVA = "0x30A8964", Offset = "0x30A8964", VA = "0x30A8964")]
	public MessageQueueConfigDesc()
	{
	}
}
