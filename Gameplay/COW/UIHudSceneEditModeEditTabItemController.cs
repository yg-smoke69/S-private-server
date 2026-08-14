using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002339")]
public class UIHudSceneEditModeEditTabItemController : UIEasyListItemController
{
	[Token(Token = "0x400DB70")]
	[FieldOffset(Offset = "0x38")]
	private UIHudSceneEditModeEditTabItemView m_View;

	[Token(Token = "0x400DB71")]
	[FieldOffset(Offset = "0x3C")]
	private ModeEditTabData m_Data;

	[Token(Token = "0x600C39B")]
	[Address(RVA = "0x24DF0A8", Offset = "0x24DF0A8", VA = "0x24DF0A8")]
	public UIHudSceneEditModeEditTabItemController()
	{
	}

	[Token(Token = "0x600C39C")]
	[Address(RVA = "0x24DF0B0", Offset = "0x24DF0B0", VA = "0x24DF0B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C39D")]
	[Address(RVA = "0x24DF158", Offset = "0x24DF158", VA = "0x24DF158", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C39E")]
	[Address(RVA = "0x24DF2B4", Offset = "0x24DF2B4", VA = "0x24DF2B4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C39F")]
	[Address(RVA = "0x24DF500", Offset = "0x24DF500", VA = "0x24DF500", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C3A0")]
	[Address(RVA = "0x24DF764", Offset = "0x24DF764", VA = "0x24DF764", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C3A1")]
	[Address(RVA = "0x24DF8B0", Offset = "0x24DF8B0", VA = "0x24DF8B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C3A2")]
	[Address(RVA = "0x24DF8B8", Offset = "0x24DF8B8", VA = "0x24DF8B8")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C3A3")]
	[Address(RVA = "0x24DF8C0", Offset = "0x24DF8C0", VA = "0x24DF8C0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
