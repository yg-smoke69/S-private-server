using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CED")]
public static class UGCOldMapDataHelper
{
	[Token(Token = "0x6006205")]
	[Address(RVA = "0x258A5C0", Offset = "0x258A5C0", VA = "0x258A5C0")]
	public static bool LoadInfoAndBinFile(out OldMapData oldMapData)
	{
		return default(bool);
	}

	[Token(Token = "0x6006206")]
	[Address(RVA = "0x258B9D0", Offset = "0x258B9D0", VA = "0x258B9D0")]
	public static bool LoadJsonFile(out OldMapData oldMapData)
	{
		return default(bool);
	}

	[Token(Token = "0x6006207")]
	[Address(RVA = "0x258C2C0", Offset = "0x258C2C0", VA = "0x258C2C0")]
	public static bool ExtractUGCProjectDataBytes(OldMapData oldData, out PGBGOAOCGDC metaData, out byte[] projectDataBytes, out byte[] runtimeDataBytes)
	{
		return default(bool);
	}
}
