using Il2CppDummyDll;
using XNode;

[Token(Token = "0x20002C4")]
public class ECAEndPhaseNode : Node
{
	[Token(Token = "0x40032F2")]
	[FieldOffset(Offset = "0x1C")]
	public uint EndIndex;

	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x3203A60", Offset = "0x3203A60", VA = "0x3203A60")]
	public ECAEndPhaseNode()
	{
	}

	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x3203A68", Offset = "0x3203A68", VA = "0x3203A68", Slot = "5")]
	public override object GetValue(NodePort port)
	{
		return null;
	}
}
