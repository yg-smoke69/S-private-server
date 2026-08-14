using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000A38")]
public class PreviewPetManager
{
	[Token(Token = "0x4005B46")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsInSingleAssetBundle;

	[Token(Token = "0x6004F82")]
	[Address(RVA = "0x195C7B0", Offset = "0x195C7B0", VA = "0x195C7B0")]
	public PreviewPetManager()
	{
	}

	[Token(Token = "0x6004F83")]
	[Address(RVA = "0x195C7B8", Offset = "0x195C7B8", VA = "0x195C7B8")]
	public static bool CheckPetResABReady(CSSharedItemData itemData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F84")]
	[Address(RVA = "0x195CB7C", Offset = "0x195CB7C", VA = "0x195CB7C")]
	public static bool CheckPetActionResABReadyByPetID(uint petID)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F85")]
	[Address(RVA = "0x195C8D8", Offset = "0x195C8D8", VA = "0x195C8D8")]
	public static bool IsPetResABReady(uint itemID)
	{
		return default(bool);
	}
}
