using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018DD")]
public class CSUploadWorkshopRes
{
	[Token(Token = "0x4009E07")]
	[FieldOffset(Offset = "0x8")]
	public long update_time;

	[Token(Token = "0x4009E08")]
	[FieldOffset(Offset = "0x10")]
	public string workshop_code;

	[Token(Token = "0x4009E09")]
	[FieldOffset(Offset = "0x14")]
	public uint reward_general_times;

	[Token(Token = "0x4009E0A")]
	[FieldOffset(Offset = "0x18")]
	public uint remain_reward_count;

	[Token(Token = "0x6007F36")]
	[Address(RVA = "0x309A8AC", Offset = "0x309A8AC", VA = "0x309A8AC")]
	public CSUploadWorkshopRes()
	{
	}
}
