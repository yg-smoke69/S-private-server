using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001512")]
public class CSDownloadPlayerSettingsReq
{
	[Token(Token = "0x40090A3")]
	[FieldOffset(Offset = "0x8")]
	public string version;

	[Token(Token = "0x40090A4")]
	[FieldOffset(Offset = "0xC")]
	public SettingsTransferStatus transfer_status;

	[Token(Token = "0x6007B5B")]
	[Address(RVA = "0x317FA14", Offset = "0x317FA14", VA = "0x317FA14")]
	public CSDownloadPlayerSettingsReq()
	{
	}
}
