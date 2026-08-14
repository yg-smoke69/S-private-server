using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B07")]
internal class UISceneEditRecommendMapItemController : UIBaseController
{
	[Token(Token = "0x401080D")]
	[FieldOffset(Offset = "0x28")]
	private SceneEditSlotInfo m_SlotInfo;

	[Token(Token = "0x401080E")]
	[FieldOffset(Offset = "0x2C")]
	private UISceneEditRecommendMapItemView m_View;

	[Token(Token = "0x6011ABA")]
	[Address(RVA = "0x2DA5714", Offset = "0x2DA5714", VA = "0x2DA5714")]
	public UISceneEditRecommendMapItemController()
	{
	}

	[Token(Token = "0x6011ABB")]
	[Address(RVA = "0x2DA5798", Offset = "0x2DA5798", VA = "0x2DA5798")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011ABC")]
	[Address(RVA = "0x2DA583C", Offset = "0x2DA583C", VA = "0x2DA583C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011ABD")]
	[Address(RVA = "0x2DA5998", Offset = "0x2DA5998", VA = "0x2DA5998", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011ABE")]
	[Address(RVA = "0x2DA5A40", Offset = "0x2DA5A40", VA = "0x2DA5A40")]
	public void SetViewData(SceneEditSlotInfo data)
	{
	}

	[Token(Token = "0x6011ABF")]
	[Address(RVA = "0x2DA5D50", Offset = "0x2DA5D50", VA = "0x2DA5D50", Slot = "31")]
	protected virtual void ShowMapIcon()
	{
	}

	[Token(Token = "0x6011AC0")]
	[Address(RVA = "0x2DA63F8", Offset = "0x2DA63F8", VA = "0x2DA63F8")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x6011AC1")]
	[Address(RVA = "0x2DA66A0", Offset = "0x2DA66A0", VA = "0x2DA66A0")]
	private void _003CShowMapIcon_003Em__0()
	{
	}

	[Token(Token = "0x6011AC2")]
	[Address(RVA = "0x2DA6780", Offset = "0x2DA6780", VA = "0x2DA6780")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011AC3")]
	[Address(RVA = "0x2DA6788", Offset = "0x2DA6788", VA = "0x2DA6788")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
