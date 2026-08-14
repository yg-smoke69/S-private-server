using System.Runtime.InteropServices;
using GCommon.CommandPattern;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B78")]
public abstract class BlockEditCommand : Command, _Attribute
{
	[Token(Token = "0x4006142")]
	[FieldOffset(Offset = "0x10")]
	private GraphData _003CGraph_003Ek__BackingField;

	[Token(Token = "0x170006F3")]
	public GraphData Graph
	{
		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x37AFA8C", Offset = "0x37AFA8C", VA = "0x37AFA8C", Slot = "17")]
		get
		{
			return null;
		}
		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x37AFA94", Offset = "0x37AFA94", VA = "0x37AFA94", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x60056FD")]
	[Address(RVA = "0x37AFA84", Offset = "0x37AFA84", VA = "0x37AFA84")]
	protected BlockEditCommand()
	{
	}
}
