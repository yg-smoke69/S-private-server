using System;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x20026BF")]
public class UIGuildSignInItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EF1B")]
	private const uint m_Yellow = 4256760319u;

	[Token(Token = "0x400EF1C")]
	[FieldOffset(Offset = "0x28")]
	private UIGuildSignInItemView m_View;

	[Token(Token = "0x400EF1D")]
	[FieldOffset(Offset = "0x2C")]
	private EClan.ClanSignInRewardStatus m_State;

	[Token(Token = "0x400EF1E")]
	[FieldOffset(Offset = "0x30")]
	private DayOfWeek m_Day;

	[Token(Token = "0x400EF1F")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsRequestResponse;

	[Token(Token = "0x400EF20")]
	[FieldOffset(Offset = "0x38")]
	private uint m_DelayCallID;

	[Token(Token = "0x400EF21")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x400EF22")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsShowCurrentDay;

	[Token(Token = "0x400EF23")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600EA0B")]
	[Address(RVA = "0x147B960", Offset = "0x147B960", VA = "0x147B960")]
	public UIGuildSignInItemController()
	{
	}

	[Token(Token = "0x600EA0C")]
	[Address(RVA = "0x147B9E4", Offset = "0x147B9E4", VA = "0x147B9E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA0D")]
	[Address(RVA = "0x147BA48", Offset = "0x147BA48", VA = "0x147BA48", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600EA0E")]
	[Address(RVA = "0x147BA8C", Offset = "0x147BA8C", VA = "0x147BA8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA0F")]
	[Address(RVA = "0x147BC30", Offset = "0x147BC30", VA = "0x147BC30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EA10")]
	[Address(RVA = "0x147BD8C", Offset = "0x147BD8C", VA = "0x147BD8C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600EA11")]
	[Address(RVA = "0x147A914", Offset = "0x147A914", VA = "0x147A914")]
	public void SetData(BaseItemInfo info, DayOfWeek day, EClan.ClanSignInRewardStatus state = EClan.ClanSignInRewardStatus.ClanSignInRewardStatus_NOT_SIGNED, bool showCurrentDay = true)
	{
	}

	[Token(Token = "0x600EA12")]
	[Address(RVA = "0x147C0A4", Offset = "0x147C0A4", VA = "0x147C0A4")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x600EA13")]
	[Address(RVA = "0x147C7BC", Offset = "0x147C7BC", VA = "0x147C7BC")]
	private void OnClickItem()
	{
	}

	[Token(Token = "0x600EA14")]
	[Address(RVA = "0x147CA84", Offset = "0x147CA84", VA = "0x147CA84")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600EA15")]
	[Address(RVA = "0x147CA8C", Offset = "0x147CA8C", VA = "0x147CA8C")]
	private void _003COnClickItem_003Em__1()
	{
	}
}
