using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014F0")]
public class ECloudStorage
{
	[Token(Token = "0x20014F1")]
	public enum ObjectType
	{
		[Token(Token = "0x4009053")]
		ObjectType_WORKSHOP_EXPORT_SETTINGS,
		[Token(Token = "0x4009054")]
		ObjectType_WORKSHOP_PROJECT_SETTINGS,
		[Token(Token = "0x4009055")]
		ObjectType_MATCH_REPLAY
	}

	[Token(Token = "0x6007B40")]
	[Address(RVA = "0x309F298", Offset = "0x309F298", VA = "0x309F298")]
	public ECloudStorage()
	{
	}
}
