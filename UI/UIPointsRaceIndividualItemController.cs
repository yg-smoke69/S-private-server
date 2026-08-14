using System;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x2002A63")]
public class UIPointsRaceIndividualItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010472")]
	[FieldOffset(Offset = "0x28")]
	private UIPointsRaceIndividualItemView m_View;

	[Token(Token = "0x4010473")]
	[FieldOffset(Offset = "0x2C")]
	private AwardDesc m_Info;

	[Token(Token = "0x4010474")]
	[FieldOffset(Offset = "0x30")]
	private uint m_StageID;

	[Token(Token = "0x4010475")]
	[FieldOffset(Offset = "0x34")]
	private EClaimItemState m_State;

	[Token(Token = "0x4010476")]
	[FieldOffset(Offset = "0x38")]
	private uint m_ExchangePointsCost;

	[Token(Token = "0x4010477")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60113E3")]
	[Address(RVA = "0x223EEA0", Offset = "0x223EEA0", VA = "0x223EEA0")]
	public UIPointsRaceIndividualItemController()
	{
	}

	[Token(Token = "0x60113E4")]
	[Address(RVA = "0x223EF24", Offset = "0x223EF24", VA = "0x223EF24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113E5")]
	[Address(RVA = "0x223EF88", Offset = "0x223EF88", VA = "0x223EF88", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60113E6")]
	[Address(RVA = "0x223EFCC", Offset = "0x223EFCC", VA = "0x223EFCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113E7")]
	[Address(RVA = "0x223F334", Offset = "0x223F334", VA = "0x223F334", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60113E8")]
	[Address(RVA = "0x223F41C", Offset = "0x223F41C", VA = "0x223F41C")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60113E9")]
	[Address(RVA = "0x223F424", Offset = "0x223F424", VA = "0x223F424", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60113EA")]
	[Address(RVA = "0x223E588", Offset = "0x223E588", VA = "0x223E588")]
	public void SetData(AwardDesc info, uint stageId, uint minPoints, bool isUnlock, bool isClaimed, bool isOpen, uint minClanPoints)
	{
	}

	[Token(Token = "0x60113EB")]
	[Address(RVA = "0x223F1F4", Offset = "0x223F1F4", VA = "0x223F1F4")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x60113EC")]
	[Address(RVA = "0x223F858", Offset = "0x223F858", VA = "0x223F858")]
	public void OnClickClaim()
	{
	}

	[Token(Token = "0x60113ED")]
	[Address(RVA = "0x223FD58", Offset = "0x223FD58", VA = "0x223FD58")]
	public void OnClickTips()
	{
	}

	[Token(Token = "0x60113EE")]
	[Address(RVA = "0x223F5A0", Offset = "0x223F5A0", VA = "0x223F5A0")]
	private void OnClaimed()
	{
	}

	[Token(Token = "0x60113EF")]
	[Address(RVA = "0x223FF60", Offset = "0x223FF60", VA = "0x223FF60")]
	private static CommonRewardItemInfo _003COnClaimed_003Em__0(BaseItemInfo item)
	{
		return null;
	}
}
