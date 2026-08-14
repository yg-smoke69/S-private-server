using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200216E")]
internal class UILadderMatchSeasonChangeController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x200216F")]
	public class SeasonRewardEasyList : _Attribute
	{
		[Token(Token = "0x400D1E3")]
		[FieldOffset(Offset = "0x8")]
		private UILadderMatchSeasonChangeController seasonchangeCtrl;

		[Token(Token = "0x600B0FF")]
		[Address(RVA = "0x22C5444", Offset = "0x22C5444", VA = "0x22C5444")]
		public SeasonRewardEasyList(UILadderMatchSeasonChangeController seasonchangeController)
		{
		}

		[Token(Token = "0x600B100")]
		[Address(RVA = "0x22C7E4C", Offset = "0x22C7E4C", VA = "0x22C7E4C", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B101")]
		[Address(RVA = "0x22C7EC8", Offset = "0x22C7EC8", VA = "0x22C7EC8", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x2002170")]
	public class ExchangeRewardEasyList : _Attribute
	{
		[Token(Token = "0x400D1E4")]
		[FieldOffset(Offset = "0x8")]
		private UILadderMatchSeasonChangeController seasonchangeCtrl;

		[Token(Token = "0x600B102")]
		[Address(RVA = "0x22C5464", Offset = "0x22C5464", VA = "0x22C5464")]
		public ExchangeRewardEasyList(UILadderMatchSeasonChangeController seasonchangeController)
		{
		}

		[Token(Token = "0x600B103")]
		[Address(RVA = "0x22C7CC4", Offset = "0x22C7CC4", VA = "0x22C7CC4", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B104")]
		[Address(RVA = "0x22C7D40", Offset = "0x22C7D40", VA = "0x22C7D40", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400D1D5")]
	[FieldOffset(Offset = "0x48")]
	private LadderMatchSeasonChangePopupView m_View;

	[Token(Token = "0x400D1D6")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLadderMatch m_LadderModel;

	[Token(Token = "0x400D1D7")]
	[FieldOffset(Offset = "0x50")]
	private SeasonRewardEasyList m_SeasonRewardEasyList;

	[Token(Token = "0x400D1D8")]
	[FieldOffset(Offset = "0x54")]
	private ExchangeRewardEasyList m_ExchangeRewardEasyList;

	[Token(Token = "0x400D1D9")]
	[FieldOffset(Offset = "0x58")]
	private UIFrontEndPreviewItemDescBaseController m_UIFrontEndPreviewItemDescBaseController;

	[Token(Token = "0x400D1DA")]
	[FieldOffset(Offset = "0x5C")]
	private int btn_click_count;

	[Token(Token = "0x400D1DB")]
	[FieldOffset(Offset = "0x60")]
	private bool m_WaitForEnd;

	[Token(Token = "0x400D1DC")]
	private const float NEEDWAITTIME = 0.5f;

	[Token(Token = "0x400D1DD")]
	[FieldOffset(Offset = "0x64")]
	private float m_WaitForEndTime;

	[Token(Token = "0x400D1DE")]
	[FieldOffset(Offset = "0x68")]
	private float m_ClickWaitTime;

	[Token(Token = "0x400D1DF")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_CanClick;

	[Token(Token = "0x400D1E0")]
	[FieldOffset(Offset = "0x70")]
	private RankingInfo lastSeasonInfo;

	[Token(Token = "0x400D1E1")]
	[FieldOffset(Offset = "0x74")]
	private uint m_DelayCallTid;

	[Token(Token = "0x400D1E2")]
	private const float DELAYTIME = 0.25f;

	[Token(Token = "0x600B0EB")]
	[Address(RVA = "0x22C4944", Offset = "0x22C4944", VA = "0x22C4944")]
	public UILadderMatchSeasonChangeController()
	{
	}

	[Token(Token = "0x600B0EC")]
	[Address(RVA = "0x22C4968", Offset = "0x22C4968", VA = "0x22C4968")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B0ED")]
	[Address(RVA = "0x22C4A0C", Offset = "0x22C4A0C", VA = "0x22C4A0C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B0EE")]
	[Address(RVA = "0x22C4B30", Offset = "0x22C4B30", VA = "0x22C4B30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B0EF")]
	[Address(RVA = "0x22C58BC", Offset = "0x22C58BC", VA = "0x22C58BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600B0F0")]
	[Address(RVA = "0x22C59A8", Offset = "0x22C59A8", VA = "0x22C59A8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B0F1")]
	[Address(RVA = "0x22C5B18", Offset = "0x22C5B18", VA = "0x22C5B18", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B0F2")]
	[Address(RVA = "0x22C5C2C", Offset = "0x22C5C2C", VA = "0x22C5C2C")]
	private void ShowNewSeasonReward()
	{
	}

	[Token(Token = "0x600B0F3")]
	[Address(RVA = "0x22C6564", Offset = "0x22C6564", VA = "0x22C6564")]
	private void ShowBigAward()
	{
	}

	[Token(Token = "0x600B0F4")]
	[Address(RVA = "0x22C5484", Offset = "0x22C5484", VA = "0x22C5484")]
	private void ShowNewSeasonInfo()
	{
	}

	[Token(Token = "0x600B0F5")]
	[Address(RVA = "0x22C685C", Offset = "0x22C685C", VA = "0x22C685C")]
	private void ShowRankSeasonTime(RankingSeasonInfo info)
	{
	}

	[Token(Token = "0x600B0F6")]
	[Address(RVA = "0x22C6A78", Offset = "0x22C6A78", VA = "0x22C6A78")]
	private void ShowSeasonRank(uint rank, uint peakRankPos, string label_show, bool currentSeason)
	{
	}

	[Token(Token = "0x600B0F7")]
	[Address(RVA = "0x22C75F4", Offset = "0x22C75F4", VA = "0x22C75F4")]
	private void OnContinueBtnClick()
	{
	}

	[Token(Token = "0x600B0F8")]
	[Address(RVA = "0x22C796C", Offset = "0x22C796C", VA = "0x22C796C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B0F9")]
	[Address(RVA = "0x22C7A60", Offset = "0x22C7A60", VA = "0x22C7A60", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B0FA")]
	[Address(RVA = "0x22C7B3C", Offset = "0x22C7B3C", VA = "0x22C7B3C")]
	private void _003COnContinueBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600B0FB")]
	[Address(RVA = "0x22C7CA4", Offset = "0x22C7CA4", VA = "0x22C7CA4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600B0FC")]
	[Address(RVA = "0x22C7CAC", Offset = "0x22C7CAC", VA = "0x22C7CAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B0FD")]
	[Address(RVA = "0x22C7CB4", Offset = "0x22C7CB4", VA = "0x22C7CB4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B0FE")]
	[Address(RVA = "0x22C7CBC", Offset = "0x22C7CBC", VA = "0x22C7CBC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
