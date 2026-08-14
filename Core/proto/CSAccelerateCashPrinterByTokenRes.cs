using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017F5")]
public class CSAccelerateCashPrinterByTokenRes
{
	[Token(Token = "0x4009BC3")]
	[FieldOffset(Offset = "0x8")]
	public uint deposit;

	[Token(Token = "0x4009BC4")]
	[FieldOffset(Offset = "0xC")]
	public uint current_speed_from_tokens;

	[Token(Token = "0x4009BC5")]
	[FieldOffset(Offset = "0x10")]
	public uint speed_change_time;

	[Token(Token = "0x6007E4F")]
	[Address(RVA = "0x317D738", Offset = "0x317D738", VA = "0x317D738")]
	public CSAccelerateCashPrinterByTokenRes()
	{
	}
}
