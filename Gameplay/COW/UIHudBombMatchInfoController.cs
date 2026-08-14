using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026F3")]
internal class UIHudBombMatchInfoController : UIBaseController
{
	[Token(Token = "0x20026F4")]
	private sealed class _003COnODFactionSwitchDone_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F08E")]
		[FieldOffset(Offset = "0x8")]
		internal int odFaction;

		[Token(Token = "0x400F08F")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBombMatchInfoController _0024this;

		[Token(Token = "0x600EC58")]
		[Address(RVA = "0x1E10464", Offset = "0x1E10464", VA = "0x1E10464")]
		public _003COnODFactionSwitchDone_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EC59")]
		[Address(RVA = "0x1E115FC", Offset = "0x1E115FC", VA = "0x1E115FC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F07F")]
	[FieldOffset(Offset = "0x0")]
	public static float AnimationTime;

	[Token(Token = "0x400F080")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBombMatchInfoView m_View;

	[Token(Token = "0x400F081")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	[Token(Token = "0x400F082")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	[Token(Token = "0x400F083")]
	[FieldOffset(Offset = "0x34")]
	private PJIBHMGGMEL mGame;

	[Token(Token = "0x400F084")]
	[FieldOffset(Offset = "0x38")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F085")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_BaseTeamCount;

	[Token(Token = "0x400F086")]
	[FieldOffset(Offset = "0x40")]
	private uint m_BaseItemSize;

	[Token(Token = "0x400F087")]
	[FieldOffset(Offset = "0x44")]
	private uint m_BombExplodeTime;

	[Token(Token = "0x400F088")]
	[FieldOffset(Offset = "0x48")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400F089")]
	[FieldOffset(Offset = "0x4C")]
	private uint min;

	[Token(Token = "0x400F08A")]
	[FieldOffset(Offset = "0x50")]
	private uint sec;

	[Token(Token = "0x400F08B")]
	[FieldOffset(Offset = "0x54")]
	private byte m_MyScore;

	[Token(Token = "0x400F08C")]
	[FieldOffset(Offset = "0x55")]
	private byte m_OtherScore;

	[Token(Token = "0x400F08D")]
	[FieldOffset(Offset = "0x56")]
	private bool m_IsMatchPointSoundPlayed;

	[Token(Token = "0x600EC3B")]
	[Address(RVA = "0x1E0CF5C", Offset = "0x1E0CF5C", VA = "0x1E0CF5C")]
	public UIHudBombMatchInfoController()
	{
	}

	[Token(Token = "0x600EC3C")]
	[Address(RVA = "0x1E0D03C", Offset = "0x1E0D03C", VA = "0x1E0D03C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC3D")]
	[Address(RVA = "0x1E0D0E4", Offset = "0x1E0D0E4", VA = "0x1E0D0E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC3E")]
	[Address(RVA = "0x1E0E1A0", Offset = "0x1E0E1A0", VA = "0x1E0E1A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EC3F")]
	[Address(RVA = "0x1E0E67C", Offset = "0x1E0E67C", VA = "0x1E0E67C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EC40")]
	[Address(RVA = "0x1E0E7D8", Offset = "0x1E0E7D8", VA = "0x1E0E7D8")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600EC41")]
	[Address(RVA = "0x1E0E6F8", Offset = "0x1E0E6F8", VA = "0x1E0E6F8")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600EC42")]
	[Address(RVA = "0x1E0F238", Offset = "0x1E0F238", VA = "0x1E0F238")]
	private void RefreshTeamStatesUI(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600EC43")]
	[Address(RVA = "0x1E0ECB4", Offset = "0x1E0ECB4", VA = "0x1E0ECB4")]
	private void SetTeamStatesUI(List<IHAAMHPPLMG> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	[Token(Token = "0x600EC44")]
	[Address(RVA = "0x1E0F3CC", Offset = "0x1E0F3CC", VA = "0x1E0F3CC")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600EC45")]
	[Address(RVA = "0x1E0F524", Offset = "0x1E0F524", VA = "0x1E0F524")]
	private void OnPlayerStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600EC46")]
	[Address(RVA = "0x1E0F638", Offset = "0x1E0F638", VA = "0x1E0F638")]
	private void OnPlayerQuit(object[] data)
	{
	}

	[Token(Token = "0x600EC47")]
	[Address(RVA = "0x1E0F788", Offset = "0x1E0F788", VA = "0x1E0F788")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600EC48")]
	[Address(RVA = "0x1E0FB80", Offset = "0x1E0FB80", VA = "0x1E0FB80")]
	private void PlayMatchPointSound(byte myScore, byte otherScore)
	{
	}

	[Token(Token = "0x600EC49")]
	[Address(RVA = "0x1E0FCF4", Offset = "0x1E0FCF4", VA = "0x1E0FCF4")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x600EC4A")]
	[Address(RVA = "0x1E0FDC4", Offset = "0x1E0FDC4", VA = "0x1E0FDC4")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x600EC4B")]
	[Address(RVA = "0x1E0E930", Offset = "0x1E0E930", VA = "0x1E0E930")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x600EC4C")]
	[Address(RVA = "0x1E101C0", Offset = "0x1E101C0", VA = "0x1E101C0")]
	private void OnODFactionSwitchDone(object[] data)
	{
	}

	[Token(Token = "0x600EC4D")]
	[Address(RVA = "0x1E1068C", Offset = "0x1E1068C", VA = "0x1E1068C")]
	private void OnODFactionChanged(object[] data)
	{
	}

	[Token(Token = "0x600EC4E")]
	[Address(RVA = "0x1E0E0F8", Offset = "0x1E0E0F8", VA = "0x1E0E0F8")]
	private void ResetSwitchAnimation()
	{
	}

	[Token(Token = "0x600EC4F")]
	[Address(RVA = "0x1E1057C", Offset = "0x1E1057C", VA = "0x1E1057C")]
	private void ShowSwitchFactionSprites(bool v)
	{
	}

	[Token(Token = "0x600EC50")]
	[Address(RVA = "0x1E1046C", Offset = "0x1E1046C", VA = "0x1E1046C")]
	private void ShowFixedFactionSprites(bool v)
	{
	}

	[Token(Token = "0x600EC51")]
	[Address(RVA = "0x1E0FE94", Offset = "0x1E0FE94", VA = "0x1E0FE94")]
	private void SetODFaction(int ODFactionId)
	{
	}

	[Token(Token = "0x600EC52")]
	[Address(RVA = "0x1E10824", Offset = "0x1E10824", VA = "0x1E10824")]
	private void OnBombPlantTimeSync(object[] data)
	{
	}

	[Token(Token = "0x600EC53")]
	[Address(RVA = "0x1E108FC", Offset = "0x1E108FC", VA = "0x1E108FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600EC55")]
	[Address(RVA = "0x1E115E4", Offset = "0x1E115E4", VA = "0x1E115E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC56")]
	[Address(RVA = "0x1E115EC", Offset = "0x1E115EC", VA = "0x1E115EC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EC57")]
	[Address(RVA = "0x1E115F4", Offset = "0x1E115F4", VA = "0x1E115F4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
