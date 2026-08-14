using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003330")]
internal class UISingerBGameScene : UIInGameScene
{
	[Token(Token = "0x2003331")]
	private sealed class _003COnShowTips_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013831")]
		[FieldOffset(Offset = "0x8")]
		internal SingersBTipsType tipsType;

		[Token(Token = "0x4013832")]
		[FieldOffset(Offset = "0xC")]
		internal float countTime;

		[Token(Token = "0x4013833")]
		[FieldOffset(Offset = "0x10")]
		internal UISingerBGameScene _0024this;

		[Token(Token = "0x6015B8C")]
		[Address(RVA = "0x2056770", Offset = "0x2056770", VA = "0x2056770")]
		public _003COnShowTips_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015B8D")]
		[Address(RVA = "0x2058214", Offset = "0x2058214", VA = "0x2058214")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401381F")]
	public const uint VISIBILITY_STATE_StarOrSkate = 134217728u;

	[Token(Token = "0x4013820")]
	public const uint VISIBILITY_STATE_Cutscene = 268435456u;

	[Token(Token = "0x4013821")]
	public const uint VISIBILITY_STATE_HideAll = 536870912u;

	[Token(Token = "0x4013822")]
	public const uint VISIBILITY_STATE_Movie = 1073741824u;

	[Token(Token = "0x4013823")]
	[FieldOffset(Offset = "0x2C8")]
	private List<UIBaseController> m_NeedHideAllHUD;

	[Token(Token = "0x4013824")]
	[FieldOffset(Offset = "0x2CC")]
	private List<UIBaseController> m_NeedHideInCutsceneHUD;

	[Token(Token = "0x4013825")]
	[FieldOffset(Offset = "0x2D0")]
	private List<UIBaseController> m_NeedHideInMovieHUD;

	[Token(Token = "0x4013826")]
	[FieldOffset(Offset = "0x2D4")]
	private List<UIBaseController> m_NeedHideInStarOrSkate;

	[Token(Token = "0x4013827")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHUDSingersBEnterMovieCameraController m_EnterMovieCameraUI;

	[Token(Token = "0x4013828")]
	[FieldOffset(Offset = "0x2DC")]
	protected UIHudIngameSingerMusicMiniGamePhaseOneController m_PhaseOneMusicGameController;

	[Token(Token = "0x4013829")]
	[FieldOffset(Offset = "0x2E0")]
	protected UIHudIngameSingerMusicMiniGamePhaseThreeController m_PhaseThreeMusicGameController;

	[Token(Token = "0x401382A")]
	[FieldOffset(Offset = "0x2E4")]
	protected UIHudActiveSkillController skillcontroller;

	[Token(Token = "0x401382B")]
	[FieldOffset(Offset = "0x2E8")]
	protected UIHUDSingersBTipsController tipscontroller;

	[Token(Token = "0x401382C")]
	[FieldOffset(Offset = "0x2EC")]
	private bool m_IsInMoive;

	[Token(Token = "0x401382D")]
	[FieldOffset(Offset = "0x2ED")]
	private bool m_IsHideAll;

	[Token(Token = "0x401382E")]
	[FieldOffset(Offset = "0x2EE")]
	private bool m_IsInStarOrSkate;

	[Token(Token = "0x401382F")]
	[FieldOffset(Offset = "0x2EF")]
	private bool m_IsInCutScene;

	[Token(Token = "0x4013830")]
	[FieldOffset(Offset = "0x2F0")]
	private UIHUDSingerCallDanceController m_CallDanceUI;

	[Token(Token = "0x6015B68")]
	[Address(RVA = "0x2054EEC", Offset = "0x2054EEC", VA = "0x2054EEC")]
	public UISingerBGameScene()
	{
	}

	[Token(Token = "0x6015B69")]
	[Address(RVA = "0x2054FF4", Offset = "0x2054FF4", VA = "0x2054FF4", Slot = "17")]
	public override void OpenHud()
	{
	}

	[Token(Token = "0x6015B6A")]
	[Address(RVA = "0x2055910", Offset = "0x2055910", VA = "0x2055910", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B6B")]
	[Address(RVA = "0x2055964", Offset = "0x2055964", VA = "0x2055964", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B6C")]
	[Address(RVA = "0x2055F10", Offset = "0x2055F10", VA = "0x2055F10")]
	public void StartPhaseOneMusicGame()
	{
	}

	[Token(Token = "0x6015B6D")]
	[Address(RVA = "0x2056064", Offset = "0x2056064", VA = "0x2056064")]
	public void StartPhaseThreeMusicGame(int callNumber)
	{
	}

	[Token(Token = "0x6015B6E")]
	[Address(RVA = "0x20561C4", Offset = "0x20561C4", VA = "0x20561C4")]
	public void OnPhaseOneMusicGameBegin(object[] param)
	{
	}

	[Token(Token = "0x6015B6F")]
	[Address(RVA = "0x205622C", Offset = "0x205622C", VA = "0x205622C")]
	public void OnCallDance(object[] param)
	{
	}

	[Token(Token = "0x6015B70")]
	[Address(RVA = "0x20563C8", Offset = "0x20563C8", VA = "0x20563C8")]
	public void OnShowTips(object[] param)
	{
	}

	[Token(Token = "0x6015B71")]
	[Address(RVA = "0x2056778", Offset = "0x2056778", VA = "0x2056778")]
	protected void OnPhaseOneMusicGameStop(object[] param)
	{
	}

	[Token(Token = "0x6015B72")]
	[Address(RVA = "0x205687C", Offset = "0x205687C", VA = "0x205687C")]
	public void OnPhaseThreeMusicGameBegin(object[] param)
	{
	}

	[Token(Token = "0x6015B73")]
	[Address(RVA = "0x2056A74", Offset = "0x2056A74", VA = "0x2056A74")]
	protected void OnPhaseThreeMusicGameStop(object[] param)
	{
	}

	[Token(Token = "0x6015B74")]
	[Address(RVA = "0x2056B78", Offset = "0x2056B78", VA = "0x2056B78")]
	protected void OnShowFireHUD(object[] param)
	{
	}

	[Token(Token = "0x6015B75")]
	[Address(RVA = "0x2056CC8", Offset = "0x2056CC8", VA = "0x2056CC8")]
	private void OnHideAllUI(object[] param)
	{
	}

	[Token(Token = "0x6015B76")]
	[Address(RVA = "0x2056EC4", Offset = "0x2056EC4", VA = "0x2056EC4")]
	private void OnUIInCutscene(object[] param)
	{
	}

	[Token(Token = "0x6015B77")]
	[Address(RVA = "0x20570C0", Offset = "0x20570C0", VA = "0x20570C0")]
	private void OnUIInMovie(object[] param)
	{
	}

	[Token(Token = "0x6015B78")]
	[Address(RVA = "0x20572BC", Offset = "0x20572BC", VA = "0x20572BC")]
	private void OnShowEnterMovieCamera(object[] param)
	{
	}

	[Token(Token = "0x6015B79")]
	[Address(RVA = "0x2057440", Offset = "0x2057440", VA = "0x2057440")]
	private void OnMusicGameOneBegin(object[] param)
	{
	}

	[Token(Token = "0x6015B7A")]
	[Address(RVA = "0x2055714", Offset = "0x2055714", VA = "0x2055714")]
	private void OnInStarOrSkate(object[] param)
	{
	}

	[Token(Token = "0x6015B7B")]
	[Address(RVA = "0x20574A8", Offset = "0x20574A8", VA = "0x20574A8")]
	private void CacheNeedHidAllHUD(UIBaseController controller)
	{
	}

	[Token(Token = "0x6015B7C")]
	[Address(RVA = "0x20575E0", Offset = "0x20575E0", VA = "0x20575E0")]
	private void CacheNeedHideInCutsceneHUD(UIBaseController controller)
	{
	}

	[Token(Token = "0x6015B7D")]
	[Address(RVA = "0x2057718", Offset = "0x2057718", VA = "0x2057718")]
	private void CacheNeedHideInMovieHUD(UIBaseController controller)
	{
	}

	[Token(Token = "0x6015B7E")]
	[Address(RVA = "0x2057850", Offset = "0x2057850", VA = "0x2057850")]
	private void CacheNeedHideInStarAndSkate(UIBaseController controller)
	{
	}

	[Token(Token = "0x6015B7F")]
	[Address(RVA = "0x2057988", Offset = "0x2057988", VA = "0x2057988", Slot = "8")]
	public override void RemoveRootController(UIBaseController uiController)
	{
	}

	[Token(Token = "0x6015B80")]
	public T OpenSingersBUIInternal<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isNeedHideAll = true, bool isHideInCutscene = true, bool isHideInMovie = true, bool isHideInStarAndSkate = true) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015B81")]
	protected T OpenSingersBUIFromConfig<T>(Transform parent, bool isNeedHideAll = true, bool isHideInCutscene = true, bool isHideInMovie = true, bool isHideInStarAndSkate = true) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015B82")]
	public T OpenSingersBUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isNeedHideAll = true, bool isHideInCutscene = true, bool isHideInMovie = true, bool isHideInStarAndSkate = true, bool isChildCon = false, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015B83")]
	[Address(RVA = "0x2057AF4", Offset = "0x2057AF4", VA = "0x2057AF4", Slot = "23")]
	protected override void SetEmotionPanelVisible(object[] param)
	{
	}

	[Token(Token = "0x6015B84")]
	[Address(RVA = "0x2057CC8", Offset = "0x2057CC8", VA = "0x2057CC8", Slot = "24")]
	protected override void AddTeammateHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x6015B85")]
	[Address(RVA = "0x2057FCC", Offset = "0x2057FCC", VA = "0x2057FCC")]
	private void _003COnPhaseThreeMusicGameBegin_003Em__0()
	{
	}

	[Token(Token = "0x6015B86")]
	[Address(RVA = "0x20581B8", Offset = "0x20581B8", VA = "0x20581B8")]
	public void _003C_003EiFixBaseProxy_OpenHud()
	{
	}

	[Token(Token = "0x6015B87")]
	[Address(RVA = "0x20581C0", Offset = "0x20581C0", VA = "0x20581C0")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B88")]
	[Address(RVA = "0x20581C8", Offset = "0x20581C8", VA = "0x20581C8")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B89")]
	[Address(RVA = "0x20581D0", Offset = "0x20581D0", VA = "0x20581D0")]
	public void _003C_003EiFixBaseProxy_RemoveRootController(UIBaseController P0)
	{
	}

	[Token(Token = "0x6015B8A")]
	[Address(RVA = "0x20581D8", Offset = "0x20581D8", VA = "0x20581D8")]
	public void _003C_003EiFixBaseProxy_SetEmotionPanelVisible(object[] P0)
	{
	}

	[Token(Token = "0x6015B8B")]
	[Address(RVA = "0x20581E0", Offset = "0x20581E0", VA = "0x20581E0")]
	public void _003C_003EiFixBaseProxy_AddTeammateHud(IHAAMHPPLMG P0)
	{
	}
}
