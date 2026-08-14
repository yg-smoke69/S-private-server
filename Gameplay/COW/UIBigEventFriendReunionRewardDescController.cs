using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E8C")]
public class UIBigEventFriendReunionRewardDescController : UIBaseController
{
	[Token(Token = "0x2001E8D")]
	private enum BtnOperateType
	{
		[Token(Token = "0x400C01B")]
		GoTo,
		[Token(Token = "0x400C01C")]
		GetReward,
		[Token(Token = "0x400C01D")]
		RewardFinished,
		[Token(Token = "0x400C01E")]
		RewardUnfinish,
		[Token(Token = "0x400C01F")]
		Exchange,
		[Token(Token = "0x400C020")]
		ExchangeNo,
		[Token(Token = "0x400C021")]
		ExchangeNoFinished,
		[Token(Token = "0x400C022")]
		Forcast,
		[Token(Token = "0x400C023")]
		Callback
	}

	[Token(Token = "0x400C012")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEventFriendReunionRewardDescView m_View;

	[Token(Token = "0x400C013")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIStandardItemMiniController> m_List;

	[Token(Token = "0x400C014")]
	[FieldOffset(Offset = "0x30")]
	private UIStandardItemMiniController m_ExchangeRewardItem;

	[Token(Token = "0x400C015")]
	[FieldOffset(Offset = "0x34")]
	private ClientActivityDesc m_Desc;

	[Token(Token = "0x400C016")]
	[FieldOffset(Offset = "0x38")]
	private BtnOperateType m_curOperation;

	[Token(Token = "0x400C017")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C018")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ExchangeFinished;

	[Token(Token = "0x400C019")]
	[FieldOffset(Offset = "0x41")]
	private bool m_ExchangeItemLack;

	[Token(Token = "0x6009315")]
	[Address(RVA = "0x141D0C0", Offset = "0x141D0C0", VA = "0x141D0C0")]
	public UIBigEventFriendReunionRewardDescController()
	{
	}

	[Token(Token = "0x6009316")]
	[Address(RVA = "0x141D178", Offset = "0x141D178", VA = "0x141D178")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009317")]
	[Address(RVA = "0x141D220", Offset = "0x141D220", VA = "0x141D220", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009318")]
	[Address(RVA = "0x1419824", Offset = "0x1419824", VA = "0x1419824")]
	public void SetData(ClientActivityDesc desc, ActivityClientInfo info)
	{
	}

	[Token(Token = "0x6009319")]
	[Address(RVA = "0x141E82C", Offset = "0x141E82C", VA = "0x141E82C")]
	private void OnGetRewardClick()
	{
	}

	[Token(Token = "0x600931A")]
	[Address(RVA = "0x141E9A0", Offset = "0x141E9A0", VA = "0x141E9A0")]
	private void OnGoToClick()
	{
	}

	[Token(Token = "0x600931B")]
	[Address(RVA = "0x141EAE8", Offset = "0x141EAE8", VA = "0x141EAE8")]
	private void OnExchangeClick()
	{
	}

	[Token(Token = "0x600931C")]
	[Address(RVA = "0x141ED0C", Offset = "0x141ED0C", VA = "0x141ED0C")]
	private void OnExchangeNoClick()
	{
	}

	[Token(Token = "0x600931D")]
	[Address(RVA = "0x141F134", Offset = "0x141F134", VA = "0x141F134")]
	private void OnBtnOperate()
	{
	}

	[Token(Token = "0x600931E")]
	[Address(RVA = "0x141D3EC", Offset = "0x141D3EC", VA = "0x141D3EC")]
	private void UpdateBtnOperateStatus()
	{
	}

	[Token(Token = "0x600931F")]
	[Address(RVA = "0x141F2B4", Offset = "0x141F2B4", VA = "0x141F2B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
