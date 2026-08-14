using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000AE3")]
public class SceneEditObjectTrigger : SceneEditObjectScalableItem
{
	[Token(Token = "0x4005EA6")]
	[FieldOffset(Offset = "0x34")]
	public OMDNLEEOJBD TriggerType;

	[Token(Token = "0x4005EA7")]
	[FieldOffset(Offset = "0x38")]
	public bool IsShowTrigger;

	[Token(Token = "0x4005EA8")]
	[FieldOffset(Offset = "0x3C")]
	private UGCLevelTrigger NAPCLCCOKJI;

	[Token(Token = "0x170006AC")]
	private UGCLevelTrigger FOFJNGAPLIJ
	{
		[Token(Token = "0x60053B4")]
		[Address(RVA = "0x1D6E134", Offset = "0x1D6E134", VA = "0x1D6E134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60053B3")]
	[Address(RVA = "0x1D6E130", Offset = "0x1D6E130", VA = "0x1D6E130")]
	public SceneEditObjectTrigger()
	{
	}

	[Token(Token = "0x60053B5")]
	[Address(RVA = "0x1D6E230", Offset = "0x1D6E230", VA = "0x1D6E230", Slot = "6")]
	public override void AfterAttributeApplyToSceneEditObject()
	{
	}

	[Token(Token = "0x60053B6")]
	[Address(RVA = "0x1D6E378", Offset = "0x1D6E378", VA = "0x1D6E378", Slot = "5")]
	public override void AfterAttributeChangeInCrosshairState()
	{
	}

	[Token(Token = "0x60053B7")]
	[Address(RVA = "0x1D6E4C4", Offset = "0x1D6E4C4", VA = "0x1D6E4C4")]
	public void _003C_003EiFixBaseProxy_AfterAttributeApplyToSceneEditObject()
	{
	}

	[Token(Token = "0x60053B8")]
	[Address(RVA = "0x1D6E4CC", Offset = "0x1D6E4CC", VA = "0x1D6E4CC")]
	public void _003C_003EiFixBaseProxy_AfterAttributeChangeInCrosshairState()
	{
	}
}
