using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x2002B13")]
public class UISecondRechargeRewardItemController : UIBaseController
{
	[Token(Token = "0x2002B14")]
	private enum OperateStatus
	{
		[Token(Token = "0x4010853")]
		None,
		[Token(Token = "0x4010854")]
		GoTo,
		[Token(Token = "0x4010855")]
		UnFinished,
		[Token(Token = "0x4010856")]
		Available,
		[Token(Token = "0x4010857")]
		Received
	}

	[Token(Token = "0x401084B")]
	[FieldOffset(Offset = "0x28")]
	private UISecondRechargeRewardItemView m_View;

	[Token(Token = "0x401084C")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x401084D")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsRequestResponse;

	[Token(Token = "0x401084E")]
	[FieldOffset(Offset = "0x34")]
	private int m_Index;

	[Token(Token = "0x401084F")]
	[FieldOffset(Offset = "0x38")]
	private ClientActivityDesc m_ActivityDesc;

	[Token(Token = "0x4010850")]
	[FieldOffset(Offset = "0x3C")]
	private OperateStatus m_OpState;

	[Token(Token = "0x4010851")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011B43")]
	[Address(RVA = "0x2246FAC", Offset = "0x2246FAC", VA = "0x2246FAC")]
	public UISecondRechargeRewardItemController()
	{
	}

	[Token(Token = "0x6011B44")]
	[Address(RVA = "0x2247030", Offset = "0x2247030", VA = "0x2247030")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B45")]
	[Address(RVA = "0x2247098", Offset = "0x2247098", VA = "0x2247098")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011B46")]
	[Address(RVA = "0x22470DC", Offset = "0x22470DC", VA = "0x22470DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B47")]
	[Address(RVA = "0x2247248", Offset = "0x2247248", VA = "0x2247248", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011B48")]
	[Address(RVA = "0x2245C54", Offset = "0x2245C54", VA = "0x2245C54")]
	public void SetData(ClientActivityDesc activity, int index)
	{
	}

	[Token(Token = "0x6011B49")]
	[Address(RVA = "0x22462A8", Offset = "0x22462A8", VA = "0x22462A8")]
	public void OnClickCliam()
	{
	}

	[Token(Token = "0x6011B4A")]
	[Address(RVA = "0x2247314", Offset = "0x2247314", VA = "0x2247314")]
	private void OnClickItem()
	{
	}

	[Token(Token = "0x6011B4B")]
	[Address(RVA = "0x2246CDC", Offset = "0x2246CDC", VA = "0x2246CDC")]
	public void SetSelectState(bool select)
	{
	}

	[Token(Token = "0x6011B4C")]
	[Address(RVA = "0x2246D24", Offset = "0x2246D24", VA = "0x2246D24")]
	public int GetIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6011B4D")]
	[Address(RVA = "0x2247424", Offset = "0x2247424", VA = "0x2247424")]
	private void RequestAward()
	{
	}

	[Token(Token = "0x6011B4E")]
	[Address(RVA = "0x2245E90", Offset = "0x2245E90", VA = "0x2245E90")]
	public void UpdateUI(uint state)
	{
	}

	[Token(Token = "0x6011B4F")]
	[Address(RVA = "0x2247668", Offset = "0x2247668", VA = "0x2247668")]
	private static BaseItemInfo _003COnClickCliam_003Em__0(AwardDesc s)
	{
		return null;
	}

	[Token(Token = "0x6011B50")]
	[Address(RVA = "0x22476EC", Offset = "0x22476EC", VA = "0x22476EC")]
	private void _003CRequestAward_003Em__1()
	{
	}
}
