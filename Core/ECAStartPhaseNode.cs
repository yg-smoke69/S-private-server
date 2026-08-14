using Il2CppDummyDll;
using XNode;

[Token(Token = "0x20002CB")]
public class ECAStartPhaseNode : Node
{
	[Token(Token = "0x40032FE")]
	[FieldOffset(Offset = "0x1C")]
	public uint StartIndex;

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x3204724", Offset = "0x3204724", VA = "0x3204724")]
	public ECAStartPhaseNode()
	{
	}

	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x320472C", Offset = "0x320472C", VA = "0x320472C", Slot = "5")]
	public override object GetValue(NodePort port)
	{
		return null;
	}
}
