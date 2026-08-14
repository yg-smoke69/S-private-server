using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001693")]
public class LinkedProfileInfo
{
	[Token(Token = "0x4009678")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x4009679")]
	[FieldOffset(Offset = "0xC")]
	public uint daily_game_link;

	[Token(Token = "0x400967A")]
	[FieldOffset(Offset = "0x10")]
	public uint daily_exchange_frequency;

	[Token(Token = "0x400967B")]
	[FieldOffset(Offset = "0x14")]
	public uint game_link;

	[Token(Token = "0x400967C")]
	[FieldOffset(Offset = "0x18")]
	public uint exchange_link;

	[Token(Token = "0x400967D")]
	[FieldOffset(Offset = "0x1C")]
	public uint cd_end_time;

	[Token(Token = "0x170009E4")]
	public uint Progress
	{
		[Token(Token = "0x6007CEE")]
		[Address(RVA = "0x30A64C0", Offset = "0x30A64C0", VA = "0x30A64C0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6007CED")]
	[Address(RVA = "0x30A64B8", Offset = "0x30A64B8", VA = "0x30A64B8")]
	public LinkedProfileInfo()
	{
	}
}
