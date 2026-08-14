using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F61")]
public class UIActivityFriendReunionRewardDescController : UIBaseController
{
	[Token(Token = "0x2001F62")]
	private enum BtnOperateType
	{
		[Token(Token = "0x400C523")]
		GoTo,
		[Token(Token = "0x400C524")]
		GetReward,
		[Token(Token = "0x400C525")]
		RewardFinished,
		[Token(Token = "0x400C526")]
		RewardUnfinish,
		[Token(Token = "0x400C527")]
		Exchange,
		[Token(Token = "0x400C528")]
		ExchangeNo,
		[Token(Token = "0x400C529")]
		ExchangeNoFinished,
		[Token(Token = "0x400C52A")]
		Forcast,
		[Token(Token = "0x400C52B")]
		Callback
	}

	[Token(Token = "0x400C51A")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityFriendReunionRewardDescView m_View;

	[Token(Token = "0x400C51B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIStandardItemMiniController> m_List;

	[Token(Token = "0x400C51C")]
	[FieldOffset(Offset = "0x30")]
	private UIStandardItemMiniController m_ExchangeRewardItem;

	[Token(Token = "0x400C51D")]
	[FieldOffset(Offset = "0x34")]
	private ClientActivityDesc m_Desc;

	[Token(Token = "0x400C51E")]
	[FieldOffset(Offset = "0x38")]
	private BtnOperateType m_curOperation;

	[Token(Token = "0x400C51F")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C520")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ExchangeFinished;

	[Token(Token = "0x400C521")]
	[FieldOffset(Offset = "0x41")]
	private bool m_ExchangeItemLack;

	[Token(Token = "0x6009B6C")]
	[Address(RVA = "0x2FB2528", Offset = "0x2FB2528", VA = "0x2FB2528")]
	public UIActivityFriendReunionRewardDescController()
	{
	}

	[Token(Token = "0x6009B6D")]
	[Address(RVA = "0x2FB25E0", Offset = "0x2FB25E0", VA = "0x2FB25E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B6E")]
	[Address(RVA = "0x2FB2688", Offset = "0x2FB2688", VA = "0x2FB2688", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B6F")]
	[Address(RVA = "0x2FAF0E4", Offset = "0x2FAF0E4", VA = "0x2FAF0E4")]
	public void SetData(ClientActivityDesc desc, ActivityClientInfo info)
	{
	}

	[Token(Token = "0x6009B70")]
	[Address(RVA = "0x2FB3C94", Offset = "0x2FB3C94", VA = "0x2FB3C94")]
	private void OnGetRewardClick()
	{
	}

	[Token(Token = "0x6009B71")]
	[Address(RVA = "0x2FB3E08", Offset = "0x2FB3E08", VA = "0x2FB3E08")]
	private void OnGoToClick()
	{
	}

	[Token(Token = "0x6009B72")]
	[Address(RVA = "0x2FB3F50", Offset = "0x2FB3F50", VA = "0x2FB3F50")]
	private void OnExchangeClick()
	{
	}

	[Token(Token = "0x6009B73")]
	[Address(RVA = "0x2FB4174", Offset = "0x2FB4174", VA = "0x2FB4174")]
	private void OnExchangeNoClick()
	{
	}

	[Token(Token = "0x6009B74")]
	[Address(RVA = "0x2FB459C", Offset = "0x2FB459C", VA = "0x2FB459C")]
	private void OnBtnOperate()
	{
	}

	[Token(Token = "0x6009B75")]
	[Address(RVA = "0x2FB2854", Offset = "0x2FB2854", VA = "0x2FB2854")]
	private void UpdateBtnOperateStatus()
	{
	}

	[Token(Token = "0x6009B76")]
	[Address(RVA = "0x2FB471C", Offset = "0x2FB471C", VA = "0x2FB471C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
