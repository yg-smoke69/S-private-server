using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002153")]
internal class UICSLadderMatchSeasonChangeController : UIPopupWindowController
{
	[Token(Token = "0x2002154")]
	public class SeasonRewardEasyList : _Attribute
	{
		[Token(Token = "0x400D15B")]
		[FieldOffset(Offset = "0x8")]
		private UICSLadderMatchSeasonChangeController seasonchangeCtrl;

		[Token(Token = "0x600AFFC")]
		[Address(RVA = "0x145419C", Offset = "0x145419C", VA = "0x145419C")]
		public SeasonRewardEasyList(UICSLadderMatchSeasonChangeController seasonchangeController)
		{
		}

		[Token(Token = "0x600AFFD")]
		[Address(RVA = "0x1456A44", Offset = "0x1456A44", VA = "0x1456A44", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600AFFE")]
		[Address(RVA = "0x1456AC0", Offset = "0x1456AC0", VA = "0x1456AC0", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x2002155")]
	public class ExchangeRewardEasyList : _Attribute
	{
		[Token(Token = "0x400D15C")]
		[FieldOffset(Offset = "0x8")]
		private UICSLadderMatchSeasonChangeController seasonchangeCtrl;

		[Token(Token = "0x600AFFF")]
		[Address(RVA = "0x14541BC", Offset = "0x14541BC", VA = "0x14541BC")]
		public ExchangeRewardEasyList(UICSLadderMatchSeasonChangeController seasonchangeController)
		{
		}

		[Token(Token = "0x600B000")]
		[Address(RVA = "0x14568BC", Offset = "0x14568BC", VA = "0x14568BC", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B001")]
		[Address(RVA = "0x1456938", Offset = "0x1456938", VA = "0x1456938", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400D14D")]
	[FieldOffset(Offset = "0x48")]
	private LadderMatchSeasonChangePopupView m_View;

	[Token(Token = "0x400D14E")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCSLadderMatch m_LadderModel;

	[Token(Token = "0x400D14F")]
	[FieldOffset(Offset = "0x50")]
	private SeasonRewardEasyList m_SeasonRewardEasyList;

	[Token(Token = "0x400D150")]
	[FieldOffset(Offset = "0x54")]
	private ExchangeRewardEasyList m_ExchangeRewardEasyList;

	[Token(Token = "0x400D151")]
	[FieldOffset(Offset = "0x58")]
	private UIFrontEndPreviewItemDescBaseController m_UIFrontEndPreviewItemDescBaseController;

	[Token(Token = "0x400D152")]
	[FieldOffset(Offset = "0x5C")]
	private int btn_click_count;

	[Token(Token = "0x400D153")]
	[FieldOffset(Offset = "0x60")]
	private bool m_WaitForEnd;

	[Token(Token = "0x400D154")]
	private const float NEEDWAITTIME = 0.5f;

	[Token(Token = "0x400D155")]
	[FieldOffset(Offset = "0x64")]
	private float m_WaitForEndTime;

	[Token(Token = "0x400D156")]
	[FieldOffset(Offset = "0x68")]
	private float m_ClickWaitTime;

	[Token(Token = "0x400D157")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_CanClick;

	[Token(Token = "0x400D158")]
	[FieldOffset(Offset = "0x70")]
	private CSRankingInfo lastSeasonInfo;

	[Token(Token = "0x400D159")]
	[FieldOffset(Offset = "0x74")]
	private uint m_DelayCallTid;

	[Token(Token = "0x400D15A")]
	private const float DELAYTIME = 0.25f;

	[Token(Token = "0x600AFE9")]
	[Address(RVA = "0x14536A4", Offset = "0x14536A4", VA = "0x14536A4")]
	public UICSLadderMatchSeasonChangeController()
	{
	}

	[Token(Token = "0x600AFEA")]
	[Address(RVA = "0x14536C8", Offset = "0x14536C8", VA = "0x14536C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AFEB")]
	[Address(RVA = "0x145376C", Offset = "0x145376C", VA = "0x145376C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600AFEC")]
	[Address(RVA = "0x1453890", Offset = "0x1453890", VA = "0x1453890", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AFED")]
	[Address(RVA = "0x145461C", Offset = "0x145461C", VA = "0x145461C")]
	private void Update()
	{
	}

	[Token(Token = "0x600AFEE")]
	[Address(RVA = "0x1454708", Offset = "0x1454708", VA = "0x1454708", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AFEF")]
	[Address(RVA = "0x145481C", Offset = "0x145481C", VA = "0x145481C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AFF0")]
	[Address(RVA = "0x14541DC", Offset = "0x14541DC", VA = "0x14541DC")]
	private void ShowNewSeasonInfo()
	{
	}

	[Token(Token = "0x600AFF1")]
	[Address(RVA = "0x1454950", Offset = "0x1454950", VA = "0x1454950")]
	private void ShowSeasonRank(uint rank, uint peakRankPos, string label_show, bool currentSeason)
	{
	}

	[Token(Token = "0x600AFF2")]
	[Address(RVA = "0x1455424", Offset = "0x1455424", VA = "0x1455424")]
	private void ShowNewSeasonReward()
	{
	}

	[Token(Token = "0x600AFF3")]
	[Address(RVA = "0x1455CE0", Offset = "0x1455CE0", VA = "0x1455CE0")]
	private void ShowBigAward()
	{
	}

	[Token(Token = "0x600AFF4")]
	[Address(RVA = "0x1455FDC", Offset = "0x1455FDC", VA = "0x1455FDC")]
	private void HideNewSeasonReward()
	{
	}

	[Token(Token = "0x600AFF5")]
	[Address(RVA = "0x14560C8", Offset = "0x14560C8", VA = "0x14560C8")]
	private void ShowRankSeasonTime(int seasonID)
	{
	}

	[Token(Token = "0x600AFF6")]
	[Address(RVA = "0x14563A0", Offset = "0x14563A0", VA = "0x14563A0")]
	private void OnContinueBtnClick()
	{
	}

	[Token(Token = "0x600AFF7")]
	[Address(RVA = "0x14566D0", Offset = "0x14566D0", VA = "0x14566D0")]
	private void _003COnContinueBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600AFF8")]
	[Address(RVA = "0x145689C", Offset = "0x145689C", VA = "0x145689C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600AFF9")]
	[Address(RVA = "0x14568A4", Offset = "0x14568A4", VA = "0x14568A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AFFA")]
	[Address(RVA = "0x14568AC", Offset = "0x14568AC", VA = "0x14568AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AFFB")]
	[Address(RVA = "0x14568B4", Offset = "0x14568B4", VA = "0x14568B4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
