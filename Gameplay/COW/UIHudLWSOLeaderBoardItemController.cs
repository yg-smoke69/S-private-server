using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x20021A4")]
internal class UIHudLWSOLeaderBoardItemController : UIBaseController
{
	[Token(Token = "0x20021A5")]
	private sealed class _003CSetItemInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D2BE")]
		[FieldOffset(Offset = "0x8")]
		internal float waitingTime;

		[Token(Token = "0x400D2BF")]
		[FieldOffset(Offset = "0xC")]
		internal int randomCount;

		[Token(Token = "0x400D2C0")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudLWSOLeaderBoardItemController _0024this;

		[Token(Token = "0x600B2BF")]
		[Address(RVA = "0x1BC56B0", Offset = "0x1BC56B0", VA = "0x1BC56B0")]
		public _003CSetItemInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B2C0")]
		[Address(RVA = "0x1BC5AEC", Offset = "0x1BC5AEC", VA = "0x1BC5AEC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D2B8")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSOLeaderBoardItemView m_View;

	[Token(Token = "0x400D2B9")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D2BA")]
	[FieldOffset(Offset = "0x30")]
	private ANBHLMNFJMP m_Game;

	[Token(Token = "0x400D2BB")]
	[FieldOffset(Offset = "0x34")]
	private NBJFOKDNNBK m_Data;

	[Token(Token = "0x400D2BC")]
	[FieldOffset(Offset = "0x38")]
	private List<UISprite> m_HPList;

	[Token(Token = "0x400D2BD")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_RandomIconDelayCallID;

	[Token(Token = "0x600B2B6")]
	[Address(RVA = "0x1BC51F4", Offset = "0x1BC51F4", VA = "0x1BC51F4")]
	public UIHudLWSOLeaderBoardItemController()
	{
	}

	[Token(Token = "0x600B2B7")]
	[Address(RVA = "0x1BC52AC", Offset = "0x1BC52AC", VA = "0x1BC52AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B2B8")]
	[Address(RVA = "0x1BC5354", Offset = "0x1BC5354", VA = "0x1BC5354", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B2B9")]
	[Address(RVA = "0x1BC16CC", Offset = "0x1BC16CC", VA = "0x1BC16CC")]
	public bool SetItemInfo(NBJFOKDNNBK data, bool matchMaking, bool changeData)
	{
		return default(bool);
	}

	[Token(Token = "0x600B2BA")]
	[Address(RVA = "0x1BC56B8", Offset = "0x1BC56B8", VA = "0x1BC56B8")]
	private void ShowZoneIconInfo(int zone, int Identity)
	{
	}

	[Token(Token = "0x600B2BB")]
	[Address(RVA = "0x1BC3F98", Offset = "0x1BC3F98", VA = "0x1BC3F98")]
	public void HideInfo()
	{
	}

	[Token(Token = "0x600B2BC")]
	[Address(RVA = "0x1BC59C0", Offset = "0x1BC59C0", VA = "0x1BC59C0", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600B2BD")]
	[Address(RVA = "0x1BC5ADC", Offset = "0x1BC5ADC", VA = "0x1BC5ADC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B2BE")]
	[Address(RVA = "0x1BC5AE4", Offset = "0x1BC5AE4", VA = "0x1BC5AE4")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
