using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200176E")]
public class VideoDetail
{
	[Token(Token = "0x4009A3D")]
	[FieldOffset(Offset = "0x8")]
	public uint video_id;

	[Token(Token = "0x4009A3E")]
	[FieldOffset(Offset = "0xC")]
	public string video_url;

	[Token(Token = "0x4009A3F")]
	[FieldOffset(Offset = "0x10")]
	public uint video_type;

	[Token(Token = "0x4009A40")]
	[FieldOffset(Offset = "0x14")]
	public string video_name;

	[Token(Token = "0x4009A41")]
	[FieldOffset(Offset = "0x18")]
	public uint video_sort_id;

	[Token(Token = "0x4009A42")]
	[FieldOffset(Offset = "0x1C")]
	public string thumbnail_url;

	[Token(Token = "0x4009A43")]
	[FieldOffset(Offset = "0x20")]
	public uint create_at;

	[Token(Token = "0x4009A44")]
	[FieldOffset(Offset = "0x28")]
	public ulong hit_count;

	[Token(Token = "0x4009A45")]
	[FieldOffset(Offset = "0x30")]
	public ulong streamer_account_id;

	[Token(Token = "0x4009A46")]
	[FieldOffset(Offset = "0x38")]
	public string streamer_nickname;

	[Token(Token = "0x4009A47")]
	[FieldOffset(Offset = "0x3C")]
	public EInventory.GenderType streamer_sex;

	[Token(Token = "0x4009A48")]
	[FieldOffset(Offset = "0x40")]
	public string create_date;

	[Token(Token = "0x6007DC8")]
	[Address(RVA = "0x33E496C", Offset = "0x33E496C", VA = "0x33E496C")]
	public VideoDetail()
	{
	}
}
