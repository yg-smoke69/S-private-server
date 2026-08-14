using System.Runtime.InteropServices;
using GCommon.CommandPattern;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B79")]
public class BlockEditMarcoCommand : MacroCommand, _Attribute
{
	[Token(Token = "0x4006143")]
	[FieldOffset(Offset = "0x14")]
	private GraphData _003CGraph_003Ek__BackingField;

	[Token(Token = "0x170006F4")]
	public GraphData Graph
	{
		[Token(Token = "0x6005701")]
		[Address(RVA = "0x37B9838", Offset = "0x37B9838", VA = "0x37B9838", Slot = "17")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005702")]
		[Address(RVA = "0x37B9840", Offset = "0x37B9840", VA = "0x37B9840", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x6005700")]
	[Address(RVA = "0x37B9830", Offset = "0x37B9830", VA = "0x37B9830")]
	public BlockEditMarcoCommand()
	{
	}
}
