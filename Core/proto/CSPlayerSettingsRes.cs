using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001511")]
public class CSPlayerSettingsRes
{
	[Token(Token = "0x400909F")]
	[FieldOffset(Offset = "0x8")]
	public byte[] settings;

	[Token(Token = "0x40090A0")]
	[FieldOffset(Offset = "0xC")]
	public string version;

	[Token(Token = "0x40090A1")]
	[FieldOffset(Offset = "0x10")]
	public SettingsTransferStatus transfer_status;

	[Token(Token = "0x40090A2")]
	[FieldOffset(Offset = "0x14")]
	public bool is_compressed;

	[Token(Token = "0x6007B5A")]
	[Address(RVA = "0x3098668", Offset = "0x3098668", VA = "0x3098668")]
	public CSPlayerSettingsRes()
	{
	}
}
