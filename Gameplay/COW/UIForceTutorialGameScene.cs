using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003314")]
internal class UIForceTutorialGameScene : UIInGameScene
{
	[Token(Token = "0x2003315")]
	public enum HudType
	{
		[Token(Token = "0x4013690")]
		None,
		[Token(Token = "0x4013691")]
		FIRE,
		[Token(Token = "0x4013692")]
		SIGHT,
		[Token(Token = "0x4013693")]
		SPEEDUP,
		[Token(Token = "0x4013694")]
		WEAPON_INFO,
		[Token(Token = "0x4013695")]
		MINI_MAP,
		[Token(Token = "0x4013696")]
		QUICK_USE_MEDKIT,
		[Token(Token = "0x4013697")]
		RESCUE,
		[Token(Token = "0x4013698")]
		TEAMMATE_INFO,
		[Token(Token = "0x4013699")]
		MOVING_JOYSTICK
	}

	[Token(Token = "0x4013688")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudTutorialGamePopupWndController m_TutorialGamePopupWnd;

	[Token(Token = "0x4013689")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudTutorialMainTaskGuideController m_TutorialMainTaskCtrl;

	[Token(Token = "0x401368A")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudSightController m_HudSightCtrl;

	[Token(Token = "0x401368B")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudQuickUseMedkitController m_HudQuickUseMedkitCtrl;

	[Token(Token = "0x401368C")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudRescureController m_HudRescureCtrl;

	[Token(Token = "0x401368D")]
	[FieldOffset(Offset = "0x2DC")]
	private new Dictionary<IHAAMHPPLMG, UIBaseController> m_PlayerNames;

	[Token(Token = "0x401368E")]
	[FieldOffset(Offset = "0x2E0")]
	private UIBaseController m_TargetHud;

	[Token(Token = "0x60158EF")]
	[Address(RVA = "0x1B5EC8C", Offset = "0x1B5EC8C", VA = "0x1B5EC8C")]
	public UIForceTutorialGameScene()
	{
	}

	[Token(Token = "0x60158F0")]
	[Address(RVA = "0x1B5ED44", Offset = "0x1B5ED44", VA = "0x1B5ED44", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158F1")]
	[Address(RVA = "0x1B5F080", Offset = "0x1B5F080", VA = "0x1B5F080", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60158F2")]
	[Address(RVA = "0x1B5F168", Offset = "0x1B5F168", VA = "0x1B5F168", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60158F3")]
	[Address(RVA = "0x1B5F518", Offset = "0x1B5F518", VA = "0x1B5F518", Slot = "17")]
	public override void OpenHud()
	{
	}

	[Token(Token = "0x60158F4")]
	[Address(RVA = "0x1B5FC60", Offset = "0x1B5FC60", VA = "0x1B5FC60")]
	private void OnShowTutorialWelcome(object[] data)
	{
	}

	[Token(Token = "0x60158F5")]
	[Address(RVA = "0x1B5FECC", Offset = "0x1B5FECC", VA = "0x1B5FECC")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x60158F6")]
	[Address(RVA = "0x1B5FF30", Offset = "0x1B5FF30", VA = "0x1B5FF30")]
	private void RequestQuitMatch()
	{
	}

	[Token(Token = "0x60158F7")]
	[Address(RVA = "0x1B600B4", Offset = "0x1B600B4", VA = "0x1B600B4")]
	private void OnUIQuitGameRequest(object[] param)
	{
	}

	[Token(Token = "0x60158F8")]
	[Address(RVA = "0x1B6011C", Offset = "0x1B6011C", VA = "0x1B6011C")]
	private void OnShowTutorialMainTaskShow(object[] data)
	{
	}

	[Token(Token = "0x60158F9")]
	[Address(RVA = "0x1B60434", Offset = "0x1B60434", VA = "0x1B60434")]
	private void OnGameEnd(object[] data)
	{
	}

	[Token(Token = "0x60158FA")]
	[Address(RVA = "0x1B606B0", Offset = "0x1B606B0", VA = "0x1B606B0")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x60158FB")]
	[Address(RVA = "0x1B609DC", Offset = "0x1B609DC", VA = "0x1B609DC")]
	private void OnHudChange(object[] data)
	{
	}

	[Token(Token = "0x60158FC")]
	[Address(RVA = "0x1B61214", Offset = "0x1B61214", VA = "0x1B61214")]
	public void AddTargetGuideHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60158FD")]
	[Address(RVA = "0x1B61520", Offset = "0x1B61520", VA = "0x1B61520")]
	public void RecycleTargetGuideHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60158FE")]
	[Address(RVA = "0x1B61800", Offset = "0x1B61800", VA = "0x1B61800")]
	public void AddTargetGuideHud(Vector3 pos)
	{
	}

	[Token(Token = "0x60158FF")]
	[Address(RVA = "0x1B61994", Offset = "0x1B61994", VA = "0x1B61994")]
	public void RecycleTargetGuideHud()
	{
	}

	[Token(Token = "0x6015900")]
	[Address(RVA = "0x1B61B40", Offset = "0x1B61B40", VA = "0x1B61B40")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015901")]
	[Address(RVA = "0x1B61B48", Offset = "0x1B61B48", VA = "0x1B61B48")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x6015902")]
	[Address(RVA = "0x1B61B50", Offset = "0x1B61B50", VA = "0x1B61B50")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015903")]
	[Address(RVA = "0x1B61B58", Offset = "0x1B61B58", VA = "0x1B61B58")]
	public void _003C_003EiFixBaseProxy_OpenHud()
	{
	}
}
