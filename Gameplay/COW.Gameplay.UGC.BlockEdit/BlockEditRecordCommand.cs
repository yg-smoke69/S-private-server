using System.Runtime.InteropServices;
using GCommon.CommandPattern;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B7A")]
public abstract class BlockEditRecordCommand : RecordCommand, _Attribute
{
	[Token(Token = "0x4006144")]
	[FieldOffset(Offset = "0x10")]
	private GraphData _003CGraph_003Ek__BackingField;

	[Token(Token = "0x170006F5")]
	public GraphData Graph
	{
		[Token(Token = "0x6005704")]
		[Address(RVA = "0x37B9850", Offset = "0x37B9850", VA = "0x37B9850", Slot = "18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005705")]
		[Address(RVA = "0x37B9858", Offset = "0x37B9858", VA = "0x37B9858", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x6005703")]
	[Address(RVA = "0x37B9848", Offset = "0x37B9848", VA = "0x37B9848")]
	protected BlockEditRecordCommand()
	{
	}
}
