using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A14")]
public class BatchShowContentDesc
{
	[Token(Token = "0x400A386")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A387")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x400A388")]
	[FieldOffset(Offset = "0x10")]
	public string content;

	[Token(Token = "0x400A389")]
	[FieldOffset(Offset = "0x14")]
	public string lang;

	[Token(Token = "0x400A38A")]
	[FieldOffset(Offset = "0x18")]
	public string pre_start_time;

	[Token(Token = "0x400A38B")]
	[FieldOffset(Offset = "0x1C")]
	public string start_time;

	[Token(Token = "0x400A38C")]
	[FieldOffset(Offset = "0x20")]
	public string end_time;

	[Token(Token = "0x400A38D")]
	[FieldOffset(Offset = "0x24")]
	public string gopos;

	[Token(Token = "0x400A38E")]
	[FieldOffset(Offset = "0x28")]
	public long pre_start_timestamp;

	[Token(Token = "0x400A38F")]
	[FieldOffset(Offset = "0x30")]
	public long start_timestamp;

	[Token(Token = "0x400A390")]
	[FieldOffset(Offset = "0x38")]
	public long end_timestamp;

	[Token(Token = "0x600806C")]
	[Address(RVA = "0x317B9A4", Offset = "0x317B9A4", VA = "0x317B9A4")]
	public BatchShowContentDesc()
	{
	}
}
