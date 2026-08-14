using Il2CppDummyDll;
using XNode;

[Token(Token = "0x20002C8")]
public abstract class ECAPhaseBaseNode : Node
{
	[Token(Token = "0x40032F6")]
	[FieldOffset(Offset = "0x1C")]
	public uint LastIndex;

	[Token(Token = "0x40032F7")]
	[FieldOffset(Offset = "0x20")]
	public uint NextIndex;

	[Token(Token = "0x40032F8")]
	[FieldOffset(Offset = "0x24")]
	public uint PhaseIndex;

	[Token(Token = "0x40032F9")]
	[FieldOffset(Offset = "0x28")]
	public string PhaseName;

	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x3203AD4", Offset = "0x3203AD4", VA = "0x3203AD4")]
	protected ECAPhaseBaseNode()
	{
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x3203ADC", Offset = "0x3203ADC", VA = "0x3203ADC", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x3203CAC", Offset = "0x3203CAC", VA = "0x3203CAC", Slot = "5")]
	public override object GetValue(NodePort port)
	{
		return null;
	}

	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x3203DA0", Offset = "0x3203DA0", VA = "0x3203DA0", Slot = "6")]
	public override void OnCreateConnection(NodePort from, NodePort to)
	{
	}

	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x32041A8", Offset = "0x32041A8", VA = "0x32041A8", Slot = "8")]
	public virtual void OnDestroy()
	{
	}
}
