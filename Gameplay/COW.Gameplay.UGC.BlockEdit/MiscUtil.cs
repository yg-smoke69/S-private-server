using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BAB")]
public static class MiscUtil
{
	[Token(Token = "0x400622A")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> BlockCountByTypeCache;

	[Token(Token = "0x600585D")]
	[Address(RVA = "0x2F48734", Offset = "0x2F48734", VA = "0x2F48734")]
	public static void AddCustomString(EditorMiscData miscData, GraphData graph, string content)
	{
	}

	[Token(Token = "0x600585E")]
	[Address(RVA = "0x2F4F1AC", Offset = "0x2F4F1AC", VA = "0x2F4F1AC")]
	public static void AddErrorEntry(EditorMiscData miscData, GraphData graph, OAMCFBDOEHM.NGPIPAPMNNF errorCode)
	{
	}

	[Token(Token = "0x600585F")]
	[Address(RVA = "0x2F4F4F8", Offset = "0x2F4F4F8", VA = "0x2F4F4F8")]
	public static void CollectLogRequestInfo(BlockEditContext context, EventLogger.EventTypeUGCCustomModeMapContent source, bool outDebugLog = false)
	{
	}
}
