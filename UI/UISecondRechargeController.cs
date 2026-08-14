using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002B11")]
public class UISecondRechargeController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002B12")]
	private enum OperateStatus
	{
		[Token(Token = "0x4010846")]
		None,
		[Token(Token = "0x4010847")]
		GoTo,
		[Token(Token = "0x4010848")]
		UnFinished,
		[Token(Token = "0x4010849")]
		Available,
		[Token(Token = "0x401084A")]
		Received
	}

	[Token(Token = "0x401083F")]
	[FieldOffset(Offset = "0x48")]
	private UISecondRechargeView m_View;

	[Token(Token = "0x4010840")]
	[FieldOffset(Offset = "0x4C")]
	private List<UISecondRechargeRewardItemController> m_Items;

	[Token(Token = "0x4010841")]
	[FieldOffset(Offset = "0x50")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x4010842")]
	[FieldOffset(Offset = "0x54")]
	private ActivityGroupDesc m_GroupDesc;

	[Token(Token = "0x4010843")]
	[FieldOffset(Offset = "0x58")]
	private OperateStatus m_OperateStatus;

	[Token(Token = "0x4010844")]
	[FieldOffset(Offset = "0x5C")]
	private UISecondRechargeRewardItemController m_CurrentSelectItem;

	[Token(Token = "0x6011B33")]
	[Address(RVA = "0x22448D0", Offset = "0x22448D0", VA = "0x22448D0")]
	public UISecondRechargeController()
	{
	}

	[Token(Token = "0x6011B34")]
	[Address(RVA = "0x224495C", Offset = "0x224495C", VA = "0x224495C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B35")]
	[Address(RVA = "0x22449C4", Offset = "0x22449C4", VA = "0x22449C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B36")]
	[Address(RVA = "0x2245270", Offset = "0x2245270", VA = "0x2245270", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011B37")]
	[Address(RVA = "0x22452B0", Offset = "0x22452B0", VA = "0x22452B0")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6011B38")]
	[Address(RVA = "0x22452B8", Offset = "0x22452B8", VA = "0x22452B8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011B39")]
	[Address(RVA = "0x2244ED4", Offset = "0x2244ED4", VA = "0x2244ED4")]
	public void UpdateView(object data)
	{
	}

	[Token(Token = "0x6011B3A")]
	[Address(RVA = "0x2245C10", Offset = "0x2245C10", VA = "0x2245C10")]
	private void ShowUIAfterCDNLoaded()
	{
	}

	[Token(Token = "0x6011B3B")]
	[Address(RVA = "0x22452C0", Offset = "0x22452C0", VA = "0x22452C0")]
	private void CreateRewardItemList()
	{
	}

	[Token(Token = "0x6011B3C")]
	[Address(RVA = "0x2245638", Offset = "0x2245638", VA = "0x2245638")]
	private void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x6011B3D")]
	[Address(RVA = "0x2246050", Offset = "0x2246050", VA = "0x2246050")]
	private void OnClickCharge()
	{
	}

	[Token(Token = "0x6011B3E")]
	[Address(RVA = "0x22460F8", Offset = "0x22460F8", VA = "0x22460F8")]
	private void OnClickCliam()
	{
	}

	[Token(Token = "0x6011B3F")]
	[Address(RVA = "0x2245C60", Offset = "0x2245C60", VA = "0x2245C60")]
	private bool HasReceived()
	{
		return default(bool);
	}

	[Token(Token = "0x6011B40")]
	[Address(RVA = "0x2246844", Offset = "0x2246844", VA = "0x2246844")]
	public void OnSelectItem(UISecondRechargeRewardItemController rewardItem)
	{
	}

	[Token(Token = "0x6011B41")]
	[Address(RVA = "0x2246D2C", Offset = "0x2246D2C", VA = "0x2246D2C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011B42")]
	[Address(RVA = "0x2246D70", Offset = "0x2246D70", VA = "0x2246D70", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}
}
