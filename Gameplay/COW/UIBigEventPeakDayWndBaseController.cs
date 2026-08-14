using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F8F")]
public class UIBigEventPeakDayWndBaseController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C60E")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEventPeakDayWndBaseView m_View;

	[Token(Token = "0x400C60F")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C610")]
	[FieldOffset(Offset = "0x50")]
	private ClientActivityDesc m_PeakDayDesc;

	[Token(Token = "0x400C611")]
	[FieldOffset(Offset = "0x54")]
	private List<UIStandardItemMiniController> itemList;

	[Token(Token = "0x400C612")]
	[FieldOffset(Offset = "0x58")]
	protected bool itemMiniTween;

	[Token(Token = "0x6009D04")]
	[Address(RVA = "0x3015668", Offset = "0x3015668", VA = "0x3015668")]
	public UIBigEventPeakDayWndBaseController()
	{
	}

	[Token(Token = "0x6009D05")]
	[Address(RVA = "0x30156FC", Offset = "0x30156FC", VA = "0x30156FC", Slot = "48")]
	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009D06")]
	[Address(RVA = "0x3015754", Offset = "0x3015754", VA = "0x3015754", Slot = "49")]
	public virtual EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009D07")]
	[Address(RVA = "0x30157AC", Offset = "0x30157AC", VA = "0x30157AC", Slot = "50")]
	public virtual UIStandardItemMiniController GetItemController()
	{
		return null;
	}

	[Token(Token = "0x6009D08")]
	[Address(RVA = "0x30158D4", Offset = "0x30158D4", VA = "0x30158D4", Slot = "51")]
	public virtual string GetPeakDayLoginKey()
	{
		return null;
	}

	[Token(Token = "0x6009D09")]
	[Address(RVA = "0x3015978", Offset = "0x3015978", VA = "0x3015978", Slot = "52")]
	public virtual string GetPeakDayExpiredKey()
	{
		return null;
	}

	[Token(Token = "0x6009D0A")]
	[Address(RVA = "0x3015A1C", Offset = "0x3015A1C", VA = "0x3015A1C", Slot = "53")]
	public virtual UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return default(UICommonRewardWndController.WndStyleEnum);
	}

	[Token(Token = "0x6009D0B")]
	[Address(RVA = "0x3015A74", Offset = "0x3015A74", VA = "0x3015A74", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D0C")]
	[Address(RVA = "0x3016B1C", Offset = "0x3016B1C", VA = "0x3016B1C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009D0D")]
	[Address(RVA = "0x3016C34", Offset = "0x3016C34", VA = "0x3016C34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009D0E")]
	[Address(RVA = "0x3016CBC", Offset = "0x3016CBC", VA = "0x3016CBC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009D0F")]
	[Address(RVA = "0x3016D20", Offset = "0x3016D20", VA = "0x3016D20")]
	private void CloseAllItem()
	{
	}

	[Token(Token = "0x6009D10")]
	[Address(RVA = "0x3015C6C", Offset = "0x3015C6C", VA = "0x3015C6C")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x6009D11")]
	[Address(RVA = "0x3016EF0", Offset = "0x3016EF0", VA = "0x3016EF0")]
	private void OnBtnClaimClick()
	{
	}

	[Token(Token = "0x6009D12")]
	[Address(RVA = "0x3017074", Offset = "0x3017074", VA = "0x3017074", Slot = "54")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009D13")]
	[Address(RVA = "0x3017144", Offset = "0x3017144", VA = "0x3017144", Slot = "55")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009D14")]
	[Address(RVA = "0x30171D8", Offset = "0x30171D8", VA = "0x30171D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009D15")]
	[Address(RVA = "0x30171E0", Offset = "0x30171E0", VA = "0x30171E0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009D16")]
	[Address(RVA = "0x30171E8", Offset = "0x30171E8", VA = "0x30171E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009D17")]
	[Address(RVA = "0x30171F0", Offset = "0x30171F0", VA = "0x30171F0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
