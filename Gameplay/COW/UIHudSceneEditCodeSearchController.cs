using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002327")]
public class UIHudSceneEditCodeSearchController : UIPopupWindowController
{
	[Token(Token = "0x400DB0F")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditCodeSearchView m_View;

	[Token(Token = "0x400DB10")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x400DB11")]
	[FieldOffset(Offset = "0x50")]
	private SceneEditSlotInfo m_SlotInfo;

	[Token(Token = "0x400DB12")]
	[FieldOffset(Offset = "0x54")]
	private uint m_SlotID;

	[Token(Token = "0x600C2E3")]
	[Address(RVA = "0x1C55C20", Offset = "0x1C55C20", VA = "0x1C55C20")]
	public UIHudSceneEditCodeSearchController()
	{
	}

	[Token(Token = "0x600C2E4")]
	[Address(RVA = "0x1C55C28", Offset = "0x1C55C28", VA = "0x1C55C28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C2E5")]
	[Address(RVA = "0x1C55CCC", Offset = "0x1C55CCC", VA = "0x1C55CCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C2E6")]
	[Address(RVA = "0x1C560FC", Offset = "0x1C560FC", VA = "0x1C560FC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C2E7")]
	[Address(RVA = "0x1C56274", Offset = "0x1C56274", VA = "0x1C56274")]
	private void OnReportBtnClick()
	{
	}

	[Token(Token = "0x600C2E8")]
	[Address(RVA = "0x1C56420", Offset = "0x1C56420", VA = "0x1C56420")]
	private void OnPreviewBtnClick()
	{
	}

	[Token(Token = "0x600C2E9")]
	[Address(RVA = "0x1C564DC", Offset = "0x1C564DC", VA = "0x1C564DC")]
	private void OnSubscribeBtnClick()
	{
	}

	[Token(Token = "0x600C2EA")]
	[Address(RVA = "0x1C5658C", Offset = "0x1C5658C", VA = "0x1C5658C")]
	private void OnEnterPreviewMode(object[] data)
	{
	}

	[Token(Token = "0x600C2EB")]
	[Address(RVA = "0x1C56688", Offset = "0x1C56688", VA = "0x1C56688")]
	public void SetUIData(SceneEditSlotInfo info, uint id, bool gmMode = false)
	{
	}

	[Token(Token = "0x600C2EC")]
	[Address(RVA = "0x1C56A5C", Offset = "0x1C56A5C", VA = "0x1C56A5C")]
	private void _003CSetUIData_003Em__0()
	{
	}

	[Token(Token = "0x600C2ED")]
	[Address(RVA = "0x1C56B3C", Offset = "0x1C56B3C", VA = "0x1C56B3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C2EE")]
	[Address(RVA = "0x1C56B44", Offset = "0x1C56B44", VA = "0x1C56B44")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
