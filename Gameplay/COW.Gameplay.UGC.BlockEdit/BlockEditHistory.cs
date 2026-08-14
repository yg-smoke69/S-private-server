using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA2")]
public class BlockEditHistory
{
	[Token(Token = "0x40061FD")]
	[FieldOffset(Offset = "0x0")]
	public static int MaxLength;

	[Token(Token = "0x40061FE")]
	[FieldOffset(Offset = "0x8")]
	private BlockEditContext _003CContext_003Ek__BackingField;

	[Token(Token = "0x40061FF")]
	[FieldOffset(Offset = "0xC")]
	public int CurrentOrder;

	[Token(Token = "0x4006200")]
	[FieldOffset(Offset = "0x10")]
	private List<string> GraphSnapshots;

	[Token(Token = "0x4006201")]
	[FieldOffset(Offset = "0x14")]
	private JsonWriter Writer;

	[Token(Token = "0x17000712")]
	public BlockEditContext Context
	{
		[Token(Token = "0x600582C")]
		[Address(RVA = "0x37B1DD0", Offset = "0x37B1DD0", VA = "0x37B1DD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600582D")]
		[Address(RVA = "0x37B1DC8", Offset = "0x37B1DC8", VA = "0x37B1DC8")]
		private set
		{
		}
	}

	[Token(Token = "0x600582B")]
	[Address(RVA = "0x37B1D10", Offset = "0x37B1D10", VA = "0x37B1D10")]
	public BlockEditHistory(BlockEditContext context)
	{
	}

	[Token(Token = "0x600582E")]
	[Address(RVA = "0x37B1DD8", Offset = "0x37B1DD8", VA = "0x37B1DD8")]
	public void AddSnapshot(GraphData graphData)
	{
	}

	[Token(Token = "0x600582F")]
	[Address(RVA = "0x37B20A0", Offset = "0x37B20A0", VA = "0x37B20A0")]
	public GraphData GetSnapShot(int order)
	{
		return null;
	}

	[Token(Token = "0x6005830")]
	[Address(RVA = "0x37B2298", Offset = "0x37B2298", VA = "0x37B2298")]
	public GraphData Undo()
	{
		return null;
	}

	[Token(Token = "0x6005831")]
	[Address(RVA = "0x37B2398", Offset = "0x37B2398", VA = "0x37B2398")]
	public GraphData Redo()
	{
		return null;
	}

	[Token(Token = "0x6005832")]
	[Address(RVA = "0x37B2414", Offset = "0x37B2414", VA = "0x37B2414")]
	public void Reset()
	{
	}
}
