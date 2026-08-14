using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200150F")]
public class CSSettingsTransferRes
{
	[Token(Token = "0x400909B")]
	[FieldOffset(Offset = "0x8")]
	public SettingsTransferStatus transfer_status;

	[Token(Token = "0x6007B58")]
	[Address(RVA = "0x3099B78", Offset = "0x3099B78", VA = "0x3099B78")]
	public CSSettingsTransferRes()
	{
	}
}
