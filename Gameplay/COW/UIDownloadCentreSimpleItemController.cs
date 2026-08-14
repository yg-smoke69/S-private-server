using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020C0")]
public class UIDownloadCentreSimpleItemController : UIDownloadCentreBaseItemController
{
	[Token(Token = "0x400CD21")]
	[FieldOffset(Offset = "0x90")]
	private UIDownloadCentreSimpleItemView m_View;

	[Token(Token = "0x600A92C")]
	[Address(RVA = "0x27662F0", Offset = "0x27662F0", VA = "0x27662F0")]
	public UIDownloadCentreSimpleItemController()
	{
	}

	[Token(Token = "0x600A92D")]
	[Address(RVA = "0x2766300", Offset = "0x2766300", VA = "0x2766300")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A92E")]
	[Address(RVA = "0x27663A8", Offset = "0x27663A8", VA = "0x27663A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A92F")]
	[Address(RVA = "0x276663C", Offset = "0x276663C", VA = "0x276663C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A930")]
	[Address(RVA = "0x276682C", Offset = "0x276682C", VA = "0x276682C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A931")]
	[Address(RVA = "0x2766830", Offset = "0x2766830", VA = "0x2766830")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
