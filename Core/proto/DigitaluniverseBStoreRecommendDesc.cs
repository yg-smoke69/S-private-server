using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B66")]
public class DigitaluniverseBStoreRecommendDesc
{
	[Token(Token = "0x400AC65")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC66")]
	[FieldOffset(Offset = "0xC")]
	public uint reward_id;

	[Token(Token = "0x400AC67")]
	[FieldOffset(Offset = "0x10")]
	public string gopos_key;

	[Token(Token = "0x400AC68")]
	[FieldOffset(Offset = "0x14")]
	public uint gopos;

	[Token(Token = "0x400AC69")]
	[FieldOffset(Offset = "0x18")]
	public string sub_gopos;

	[Token(Token = "0x400AC6A")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x400AC6B")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x400AC6C")]
	[FieldOffset(Offset = "0x30")]
	public uint default_options;

	[Token(Token = "0x400AC6D")]
	[FieldOffset(Offset = "0x34")]
	public string des_key;

	[Token(Token = "0x60081C1")]
	[Address(RVA = "0x309EDB0", Offset = "0x309EDB0", VA = "0x309EDB0")]
	public DigitaluniverseBStoreRecommendDesc()
	{
	}
}
