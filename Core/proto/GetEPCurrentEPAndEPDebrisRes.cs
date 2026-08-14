using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A94")]
public class GetEPCurrentEPAndEPDebrisRes
{
	[Token(Token = "0x400A66C")]
	[FieldOffset(Offset = "0x8")]
	public EventSettingDesc ep_setting;

	[Token(Token = "0x400A66D")]
	[FieldOffset(Offset = "0xC")]
	public EPDebrisDropDesc ep_debris;

	[Token(Token = "0x60080F1")]
	[Address(RVA = "0x30A1FD8", Offset = "0x30A1FD8", VA = "0x30A1FD8")]
	public GetEPCurrentEPAndEPDebrisRes()
	{
	}
}
