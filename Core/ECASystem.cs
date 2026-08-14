using ECAPackage;
using Il2CppDummyDll;

[Token(Token = "0x20002CC")]
public class ECASystem : ECASystem
{
	[Token(Token = "0x40032FF")]
	[FieldOffset(Offset = "0x14")]
	public ECAWorkflow Workflow;

	[Token(Token = "0x4003300")]
	[FieldOffset(Offset = "0x18")]
	public UGCModeParamAssets ModeParams;

	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x3204734", Offset = "0x3204734", VA = "0x3204734")]
	public ECASystem()
	{
	}

	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x320473C", Offset = "0x320473C", VA = "0x320473C", Slot = "4")]
	public override void Refresh()
	{
	}
}
