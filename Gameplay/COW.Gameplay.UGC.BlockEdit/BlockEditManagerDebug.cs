using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B76")]
public static class BlockEditManagerDebug
{
	[Token(Token = "0x400613D")]
	[FieldOffset(Offset = "0x0")]
	public static BlockEditContext Context;

	[Token(Token = "0x400613E")]
	[FieldOffset(Offset = "0x4")]
	public static string DEBUG_GRAPH_ID;

	[Token(Token = "0x400613F")]
	[FieldOffset(Offset = "0x8")]
	public static string DEBUG_GLOBAL_GRAPH_ID;

	[Token(Token = "0x4006140")]
	[FieldOffset(Offset = "0xC")]
	public static string GRAPH_LOCALSAVENAME;

	[Token(Token = "0x4006141")]
	[FieldOffset(Offset = "0x10")]
	public static string DEBUG_GRAPH_LOCALSAVENAME;
}
