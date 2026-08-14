using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001510")]
public class CSPlayerSettingsReq
{
	[Token(Token = "0x400909C")]
	[FieldOffset(Offset = "0x8")]
	public byte[] settings;

	[Token(Token = "0x400909D")]
	[FieldOffset(Offset = "0xC")]
	public string version;

	[Token(Token = "0x400909E")]
	[FieldOffset(Offset = "0x10")]
	public SettingsTransferStatus transfer_status;

	[Token(Token = "0x6007B59")]
	[Address(RVA = "0x30985C8", Offset = "0x30985C8", VA = "0x30985C8")]
	public CSPlayerSettingsReq()
	{
	}
}
