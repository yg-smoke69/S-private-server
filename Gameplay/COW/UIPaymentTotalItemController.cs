using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A44")]
public class UIPaymentTotalItemController : UIBaseController
{
	[Token(Token = "0x2002A45")]
	private enum BtnOperateType
	{
		[Token(Token = "0x40103DB")]
		GetReward,
		[Token(Token = "0x40103DC")]
		RewardFinished,
		[Token(Token = "0x40103DD")]
		RewardUnfinish,
		[Token(Token = "0x40103DE")]
		Forcast
	}

	[Token(Token = "0x40103D6")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentTotalItemView m_View;

	[Token(Token = "0x40103D7")]
	[FieldOffset(Offset = "0x2C")]
	private BtnOperateType m_curOperation;

	[Token(Token = "0x40103D8")]
	[FieldOffset(Offset = "0x30")]
	private ClientActivityDesc m_Data;

	[Token(Token = "0x40103D9")]
	[FieldOffset(Offset = "0x34")]
	private List<UIPaymentTotalContentItemController> m_ContentItems;

	[Token(Token = "0x601126E")]
	[Address(RVA = "0x23DE298", Offset = "0x23DE298", VA = "0x23DE298")]
	public UIPaymentTotalItemController()
	{
	}

	[Token(Token = "0x601126F")]
	[Address(RVA = "0x23DE350", Offset = "0x23DE350", VA = "0x23DE350")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011270")]
	[Address(RVA = "0x23DE3F8", Offset = "0x23DE3F8", VA = "0x23DE3F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011271")]
	[Address(RVA = "0x23DE554", Offset = "0x23DE554", VA = "0x23DE554", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011272")]
	[Address(RVA = "0x23DD0A8", Offset = "0x23DD0A8", VA = "0x23DD0A8")]
	public void SetData(ClientActivityDesc desc)
	{
	}

	[Token(Token = "0x6011273")]
	[Address(RVA = "0x23DE7A0", Offset = "0x23DE7A0", VA = "0x23DE7A0")]
	private void OnGetRewardClick()
	{
	}

	[Token(Token = "0x6011274")]
	[Address(RVA = "0x23DE5B8", Offset = "0x23DE5B8", VA = "0x23DE5B8")]
	private void UpdateBtnOperateStatus()
	{
	}

	[Token(Token = "0x6011275")]
	[Address(RVA = "0x23DE948", Offset = "0x23DE948", VA = "0x23DE948")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011276")]
	[Address(RVA = "0x23DE950", Offset = "0x23DE950", VA = "0x23DE950")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
