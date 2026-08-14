using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200285A")]
internal class UIHudSpeedupAreaController : UIHudButtonBaseController
{
	[Token(Token = "0x400F8E2")]
	private const string ICON_SKYDASHING = "SG_UI_icon_AutoSliding";

	[Token(Token = "0x400F8E3")]
	private const string ICON_SPEEDUP = "SG_UI_icon_speedup";

	[Token(Token = "0x400F8E4")]
	private const string ICON_Skateboarding = "SG_UI_icon_AutoSliding";

	[Token(Token = "0x400F8E5")]
	private const string ICON_FLIGHT_SKYDASHING = "SG_UI_icon_Mounts_Accelerate";

	[Token(Token = "0x400F8E6")]
	[FieldOffset(Offset = "0x2C")]
	private string m_IconUse;

	[Token(Token = "0x400F8E7")]
	[FieldOffset(Offset = "0x30")]
	private string ICON_SPEEUPCHOOSE;

	[Token(Token = "0x400F8E8")]
	[FieldOffset(Offset = "0x34")]
	private UIHudSpeedupAreaView m_View;

	[Token(Token = "0x400F8E9")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsHighlight;

	[Token(Token = "0x400F8EA")]
	[FieldOffset(Offset = "0x39")]
	private bool m_bIsPullingBolt;

	[Token(Token = "0x400F8EB")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_ShowingInAirBtnSprite;

	[Token(Token = "0x400F8EC")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_ClickSkyDashingBtnCount;

	[Token(Token = "0x400F8ED")]
	[FieldOffset(Offset = "0x40")]
	private UIEventTrigger m_Trigger;

	[Token(Token = "0x400F8EE")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider m_Collider;

	[Token(Token = "0x400F8EF")]
	[FieldOffset(Offset = "0x48")]
	private float m_CdTime;

	[Token(Token = "0x400F8F0")]
	[FieldOffset(Offset = "0x4C")]
	private float m_LeftTime;

	[Token(Token = "0x400F8F1")]
	[FieldOffset(Offset = "0x50")]
	private bool m_UseNewRunning;

	[Token(Token = "0x400F8F2")]
	[FieldOffset(Offset = "0x54")]
	private float m_CurrentAlpha;

	[Token(Token = "0x400F8F3")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsFollowHide;

	[Token(Token = "0x600FC6E")]
	[Address(RVA = "0x1FE4204", Offset = "0x1FE4204", VA = "0x1FE4204")]
	public UIHudSpeedupAreaController()
	{
	}

	[Token(Token = "0x600FC6F")]
	[Address(RVA = "0x1FE42C0", Offset = "0x1FE42C0", VA = "0x1FE42C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC70")]
	[Address(RVA = "0x1FE4364", Offset = "0x1FE4364", VA = "0x1FE4364")]
	public GameObject GetCollider()
	{
		return null;
	}

	[Token(Token = "0x600FC71")]
	[Address(RVA = "0x1FE43F0", Offset = "0x1FE43F0", VA = "0x1FE43F0")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600FC72")]
	[Address(RVA = "0x1FE4454", Offset = "0x1FE4454", VA = "0x1FE4454")]
	public void UpdateAreaState()
	{
	}

	[Token(Token = "0x600FC73")]
	[Address(RVA = "0x1FE47EC", Offset = "0x1FE47EC", VA = "0x1FE47EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC74")]
	[Address(RVA = "0x1FE4F88", Offset = "0x1FE4F88", VA = "0x1FE4F88", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC75")]
	[Address(RVA = "0x1FE5464", Offset = "0x1FE5464", VA = "0x1FE5464")]
	private void OnUseNewRunningChange(object[] data)
	{
	}

	[Token(Token = "0x600FC76")]
	[Address(RVA = "0x1FE5548", Offset = "0x1FE5548", VA = "0x1FE5548")]
	private void OnChargeStateChange(object[] data)
	{
	}

	[Token(Token = "0x600FC77")]
	[Address(RVA = "0x1FE5710", Offset = "0x1FE5710", VA = "0x1FE5710")]
	private void OnChangeCancelVisible(object[] data)
	{
	}

	[Token(Token = "0x600FC78")]
	[Address(RVA = "0x1FE581C", Offset = "0x1FE581C", VA = "0x1FE581C")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600FC79")]
	[Address(RVA = "0x1FE5A20", Offset = "0x1FE5A20", VA = "0x1FE5A20")]
	private void OnPullBoldUnderSightingChanged(object[] data)
	{
	}

	[Token(Token = "0x600FC7A")]
	[Address(RVA = "0x1FE5B5C", Offset = "0x1FE5B5C", VA = "0x1FE5B5C")]
	private void Update()
	{
	}

	[Token(Token = "0x600FC7B")]
	[Address(RVA = "0x1FE62F0", Offset = "0x1FE62F0", VA = "0x1FE62F0", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FC7C")]
	[Address(RVA = "0x1FE5EC0", Offset = "0x1FE5EC0", VA = "0x1FE5EC0")]
	private void SetHightlight(bool highlight, Player localPlayer)
	{
	}

	[Token(Token = "0x600FC7D")]
	[Address(RVA = "0x1FE6438", Offset = "0x1FE6438", VA = "0x1FE6438")]
	private void OnTutorialRunFaster(object[] data)
	{
	}

	[Token(Token = "0x600FC7E")]
	[Address(RVA = "0x1FE68A8", Offset = "0x1FE68A8", VA = "0x1FE68A8")]
	private void OnTutorialSliding(object[] data)
	{
	}

	[Token(Token = "0x600FC7F")]
	[Address(RVA = "0x1FE6A04", Offset = "0x1FE6A04", VA = "0x1FE6A04")]
	private void HideSlidingTutorial()
	{
	}

	[Token(Token = "0x600FC80")]
	[Address(RVA = "0x1FE6B14", Offset = "0x1FE6B14", VA = "0x1FE6B14")]
	private void OnLocalPlayerStateChange(object[] data)
	{
	}

	[Token(Token = "0x600FC81")]
	[Address(RVA = "0x1FE7118", Offset = "0x1FE7118", VA = "0x1FE7118")]
	private void OnLocalPlayerAdd(object[] data)
	{
	}

	[Token(Token = "0x600FC82")]
	[Address(RVA = "0x1FE709C", Offset = "0x1FE709C", VA = "0x1FE709C")]
	private bool IsInAir(Player.DFKKGHCFGNM state)
	{
		return default(bool);
	}

	[Token(Token = "0x600FC83")]
	[Address(RVA = "0x1FE7184", Offset = "0x1FE7184", VA = "0x1FE7184")]
	public void UpdateStateByLateCreated()
	{
	}

	[Token(Token = "0x600FC84")]
	[Address(RVA = "0x1FE6DB4", Offset = "0x1FE6DB4", VA = "0x1FE6DB4")]
	private void UpdateState([Optional] Player localPlayer)
	{
	}

	[Token(Token = "0x600FC85")]
	[Address(RVA = "0x1FE71E8", Offset = "0x1FE71E8", VA = "0x1FE71E8")]
	private bool UpdateShowing(Player.DFKKGHCFGNM state)
	{
		return default(bool);
	}

	[Token(Token = "0x600FC86")]
	[Address(RVA = "0x1FE7348", Offset = "0x1FE7348", VA = "0x1FE7348")]
	private void UpdateIconSprite(Player.DFKKGHCFGNM state, bool inAir, bool haveFlight)
	{
	}

	[Token(Token = "0x600FC87")]
	[Address(RVA = "0x1FE6394", Offset = "0x1FE6394", VA = "0x1FE6394")]
	private void UpdateIconSprite(string sprite)
	{
	}

	[Token(Token = "0x600FC88")]
	[Address(RVA = "0x1FE77AC", Offset = "0x1FE77AC", VA = "0x1FE77AC")]
	private void ShowSkateboardDashTutorial()
	{
	}

	[Token(Token = "0x600FC89")]
	[Address(RVA = "0x1FE7900", Offset = "0x1FE7900", VA = "0x1FE7900")]
	private void OnLocalPlayerSkateboardDashCd(object[] param)
	{
	}

	[Token(Token = "0x600FC8A")]
	[Address(RVA = "0x1FE7698", Offset = "0x1FE7698", VA = "0x1FE7698")]
	private void ShowCdBar(float cd, float remain)
	{
	}

	[Token(Token = "0x600FC8B")]
	[Address(RVA = "0x1FE79F0", Offset = "0x1FE79F0", VA = "0x1FE79F0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600FC8C")]
	[Address(RVA = "0x1FE7D84", Offset = "0x1FE7D84", VA = "0x1FE7D84")]
	private void UpdateClickSkyDashingBtnCount()
	{
	}

	[Token(Token = "0x600FC8D")]
	[Address(RVA = "0x1FE7EAC", Offset = "0x1FE7EAC", VA = "0x1FE7EAC")]
	private void OnLocalPlayerTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x600FC8E")]
	[Address(RVA = "0x1FE7FF0", Offset = "0x1FE7FF0", VA = "0x1FE7FF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC8F")]
	[Address(RVA = "0x1FE7FF8", Offset = "0x1FE7FF8", VA = "0x1FE7FF8")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
