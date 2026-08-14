using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B9B")]
internal class UIUGCConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x4010AD5")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCConfirmWndView m_View;

	[Token(Token = "0x4010AD6")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x4010AD7")]
	[FieldOffset(Offset = "0x50")]
	private SceneEditSlotInfo m_CurSlotInfo;

	[Token(Token = "0x4010AD8")]
	[FieldOffset(Offset = "0x54")]
	private EWorkshop.UnlockSlotCostType m_CostType;

	[Token(Token = "0x4010AD9")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CostCnt;

	[Token(Token = "0x4010ADA")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_CostItem;

	[Token(Token = "0x6012047")]
	[Address(RVA = "0x2B89460", Offset = "0x2B89460", VA = "0x2B89460")]
	public UIUGCConfirmWndController()
	{
	}

	[Token(Token = "0x6012048")]
	[Address(RVA = "0x2B89468", Offset = "0x2B89468", VA = "0x2B89468")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012049")]
	[Address(RVA = "0x2B89510", Offset = "0x2B89510", VA = "0x2B89510", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601204A")]
	[Address(RVA = "0x2B89750", Offset = "0x2B89750", VA = "0x2B89750")]
	public void SetViewData(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x601204B")]
	[Address(RVA = "0x2B89A2C", Offset = "0x2B89A2C", VA = "0x2B89A2C")]
	private void UpdateLocText(string titleKey, string mainKey, string warnKey, string btnConfirmKey, string btnCancelKey)
	{
	}

	[Token(Token = "0x601204C")]
	[Address(RVA = "0x2B89EAC", Offset = "0x2B89EAC", VA = "0x2B89EAC")]
	private void ProcessOnUnlockSlot()
	{
	}

	[Token(Token = "0x601204D")]
	[Address(RVA = "0x2B8A580", Offset = "0x2B8A580", VA = "0x2B8A580")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x601204E")]
	[Address(RVA = "0x2B8A5E4", Offset = "0x2B8A5E4", VA = "0x2B8A5E4")]
	private void OnBtnApplyClick()
	{
	}

	[Token(Token = "0x601204F")]
	[Address(RVA = "0x2B8AB30", Offset = "0x2B8AB30", VA = "0x2B8AB30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
