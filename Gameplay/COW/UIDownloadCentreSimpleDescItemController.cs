using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020BF")]
public class UIDownloadCentreSimpleDescItemController : UIDownloadCentreBaseItemController
{
	[Token(Token = "0x400CD20")]
	[FieldOffset(Offset = "0x90")]
	private UIDownloadCentreSimpleDescItemView m_View;

	[Token(Token = "0x600A926")]
	[Address(RVA = "0x27654CC", Offset = "0x27654CC", VA = "0x27654CC")]
	public UIDownloadCentreSimpleDescItemController()
	{
	}

	[Token(Token = "0x600A927")]
	[Address(RVA = "0x27654DC", Offset = "0x27654DC", VA = "0x27654DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A928")]
	[Address(RVA = "0x2765584", Offset = "0x2765584", VA = "0x2765584", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A929")]
	[Address(RVA = "0x2765818", Offset = "0x2765818", VA = "0x2765818", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A92A")]
	[Address(RVA = "0x2765B54", Offset = "0x2765B54", VA = "0x2765B54")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A92B")]
	[Address(RVA = "0x2765B58", Offset = "0x2765B58", VA = "0x2765B58")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
