using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BB0")]
public static class IdUtil
{
	[Token(Token = "0x4006233")]
	private const string UndefinedPrefix = "UD";

	[Token(Token = "0x4006234")]
	public const string GraphPrefix = "GR";

	[Token(Token = "0x4006235")]
	public const string FuncCallPrefix = "FC";

	[Token(Token = "0x4006236")]
	public const string GraphVarPrefix = "GV";

	[Token(Token = "0x4006237")]
	public const string HudEventPrefix = "HE";

	[Token(Token = "0x6005876")]
	[Address(RVA = "0x2F44704", Offset = "0x2F44704", VA = "0x2F44704")]
	public static string NewGUID(string prefix)
	{
		return null;
	}

	[Token(Token = "0x6005877")]
	[Address(RVA = "0x2F4B0AC", Offset = "0x2F4B0AC", VA = "0x2F4B0AC")]
	public static string ExportBlockId(string graphId, string blockId)
	{
		return null;
	}
}
