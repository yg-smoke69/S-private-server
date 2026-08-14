using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003337")]
internal class UITrainingGameScene : UIInGameScene
{
	[Token(Token = "0x2003338")]
	private sealed class _003COnTryStartOrQuitMiniGame_003Ec__AnonStorey0
	{
		[Token(Token = "0x401384E")]
		[FieldOffset(Offset = "0x8")]
		internal CBNIKECJHAN currentGame;

		[Token(Token = "0x401384F")]
		[FieldOffset(Offset = "0xC")]
		internal UITrainingGameScene _0024this;

		[Token(Token = "0x6015BE7")]
		[Address(RVA = "0x1C2B040", Offset = "0x1C2B040", VA = "0x1C2B040")]
		public _003COnTryStartOrQuitMiniGame_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015BE8")]
		[Address(RVA = "0x1C2C6F0", Offset = "0x1C2C6F0", VA = "0x1C2C6F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401383D")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudGameShowInfoController m_ShowInfoCtrl;

	[Token(Token = "0x401383E")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudTrainingMiniGameController m_MiniGameCtrl;

	[Token(Token = "0x401383F")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudHumanlikeTargetDamageResultController m_TrainingHumanTargetCtrl;

	[Token(Token = "0x4013840")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudTokenComboController m_ComboCtrl;

	[Token(Token = "0x4013841")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudServeMiniGameInviteController m_MiniGameInviteCtrl;

	[Token(Token = "0x4013842")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudServerMiniGameReceiveController m_MiniGameReceiveCtrl;

	[Token(Token = "0x4013843")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHudMiniGameMarkController m_MiniGameMarkCtrl;

	[Token(Token = "0x4013844")]
	[FieldOffset(Offset = "0x2E4")]
	private UIHudTrainingVehicleTimerController m_VehicleSpeedTimerCtrl;

	[Token(Token = "0x4013845")]
	[FieldOffset(Offset = "0x2E8")]
	private UIHudTrainingVehicleSpeedActionController m_VehilceSpeedActionCtrl;

	[Token(Token = "0x4013846")]
	[FieldOffset(Offset = "0x2EC")]
	private UIHudFerrisWheelTakePhotoController m_FerrisWheelTakePhotoCtrl;

	[Token(Token = "0x4013847")]
	[FieldOffset(Offset = "0x2F0")]
	private UIHudTrainingDeadSummaryController m_DeadSummaryCtrl;

	[Token(Token = "0x4013848")]
	[FieldOffset(Offset = "0x2F4")]
	private UIHudTrainingGameLineupEndController m_GameLineupEndController;

	[Token(Token = "0x4013849")]
	[FieldOffset(Offset = "0x2F8")]
	private UIHudTrainingGameQueueInfoController m_GameQueueInfoController;

	[Token(Token = "0x401384A")]
	[FieldOffset(Offset = "0x2FC")]
	private uint m_DelayID;

	[Token(Token = "0x401384B")]
	[FieldOffset(Offset = "0x300")]
	private bool m_NeverReceiveMiniGame;

	[Token(Token = "0x401384C")]
	[FieldOffset(Offset = "0x304")]
	private GameObject m_BoybandBZone;

	[Token(Token = "0x401384D")]
	[FieldOffset(Offset = "0x308")]
	private byte MiniGameQueuePlayerCnt;

	[Token(Token = "0x6015BC8")]
	[Address(RVA = "0x1C26830", Offset = "0x1C26830", VA = "0x1C26830")]
	public UITrainingGameScene()
	{
	}

	[Token(Token = "0x6015BC9")]
	[Address(RVA = "0x1C268B4", Offset = "0x1C268B4", VA = "0x1C268B4", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015BCA")]
	[Address(RVA = "0x1C26BC8", Offset = "0x1C26BC8", VA = "0x1C26BC8", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015BCB")]
	[Address(RVA = "0x1C26FAC", Offset = "0x1C26FAC", VA = "0x1C26FAC", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BCC")]
	[Address(RVA = "0x1C27760", Offset = "0x1C27760", VA = "0x1C27760", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015BCD")]
	[Address(RVA = "0x1C27F88", Offset = "0x1C27F88", VA = "0x1C27F88")]
	private void OnTrainingZoneChanged(object[] data)
	{
	}

	[Token(Token = "0x6015BCE")]
	[Address(RVA = "0x1C289E0", Offset = "0x1C289E0", VA = "0x1C289E0")]
	private void CheckRetainQueueInfo()
	{
	}

	[Token(Token = "0x6015BCF")]
	[Address(RVA = "0x1C28C50", Offset = "0x1C28C50", VA = "0x1C28C50")]
	private void OnServerMiniGameInvite(object[] data)
	{
	}

	[Token(Token = "0x6015BD0")]
	[Address(RVA = "0x1C28ECC", Offset = "0x1C28ECC", VA = "0x1C28ECC")]
	private void OnPlayerLineupEndInfo(object[] data)
	{
	}

	[Token(Token = "0x6015BD1")]
	[Address(RVA = "0x1C292A8", Offset = "0x1C292A8", VA = "0x1C292A8")]
	private void OnPlayerInQueueIdxChange(object[] data)
	{
	}

	[Token(Token = "0x6015BD2")]
	[Address(RVA = "0x1C297FC", Offset = "0x1C297FC", VA = "0x1C297FC")]
	private void OnQueuePlayerCntChange(object[] data)
	{
	}

	[Token(Token = "0x6015BD3")]
	[Address(RVA = "0x1C296AC", Offset = "0x1C296AC", VA = "0x1C296AC")]
	private bool ShouldShowPlayerQueueInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6015BD4")]
	[Address(RVA = "0x1C285E0", Offset = "0x1C285E0", VA = "0x1C285E0")]
	private void OnMiniGameMarkChanged(object[] data)
	{
	}

	[Token(Token = "0x6015BD5")]
	[Address(RVA = "0x1C29BA8", Offset = "0x1C29BA8", VA = "0x1C29BA8")]
	private void OnServerMiniGameReceive(object[] data)
	{
	}

	[Token(Token = "0x6015BD6")]
	[Address(RVA = "0x1C29FB4", Offset = "0x1C29FB4", VA = "0x1C29FB4")]
	private void OnShowDamageInfo(object[] data)
	{
	}

	[Token(Token = "0x6015BD7")]
	[Address(RVA = "0x1C26920", Offset = "0x1C26920", VA = "0x1C26920")]
	private void SetMiniGameRanking()
	{
	}

	[Token(Token = "0x6015BD8")]
	[Address(RVA = "0x1C2A254", Offset = "0x1C2A254", VA = "0x1C2A254")]
	private Transform FindMiniGameRoot(JNGKMJDINHC t)
	{
		return null;
	}

	[Token(Token = "0x6015BD9")]
	[Address(RVA = "0x1C2A3B0", Offset = "0x1C2A3B0", VA = "0x1C2A3B0")]
	private void OpenMiniGameRanking(Transform root, JNGKMJDINHC t)
	{
	}

	[Token(Token = "0x6015BDA")]
	[Address(RVA = "0x1C2A644", Offset = "0x1C2A644", VA = "0x1C2A644")]
	private void OnTryStartOrQuitMiniGame(object[] param)
	{
	}

	[Token(Token = "0x6015BDB")]
	[Address(RVA = "0x1C2B048", Offset = "0x1C2B048", VA = "0x1C2B048")]
	private void OnShowCombo(object[] data)
	{
	}

	[Token(Token = "0x6015BDC")]
	[Address(RVA = "0x1C2B448", Offset = "0x1C2B448", VA = "0x1C2B448")]
	private void OnVehicleSpeedEnterStartPoint(object[] data)
	{
	}

	[Token(Token = "0x6015BDD")]
	[Address(RVA = "0x1C2B5D4", Offset = "0x1C2B5D4", VA = "0x1C2B5D4")]
	private void OnVehicleSpeedStart(object[] data)
	{
	}

	[Token(Token = "0x6015BDE")]
	[Address(RVA = "0x1C2BA18", Offset = "0x1C2BA18", VA = "0x1C2BA18")]
	private void OnPlayerGetoffVehicle(object[] data)
	{
	}

	[Token(Token = "0x6015BDF")]
	[Address(RVA = "0x1C2BED4", Offset = "0x1C2BED4", VA = "0x1C2BED4")]
	private void OnLPQuitVehicleSpeed(object[] data)
	{
	}

	[Token(Token = "0x6015BE0")]
	[Address(RVA = "0x1C2C138", Offset = "0x1C2C138", VA = "0x1C2C138")]
	private void OnPlayerGetOnGetOffFerrisWheel(object[] data)
	{
	}

	[Token(Token = "0x6015BE1")]
	[Address(RVA = "0x1C2C364", Offset = "0x1C2C364", VA = "0x1C2C364")]
	private void OnDeadSummaryShow(object[] data)
	{
	}

	[Token(Token = "0x6015BE2")]
	[Address(RVA = "0x1C2C5C4", Offset = "0x1C2C5C4", VA = "0x1C2C5C4")]
	private void OnLocalPlayerRevive(object[] data)
	{
	}

	[Token(Token = "0x6015BE3")]
	[Address(RVA = "0x1C2C6D0", Offset = "0x1C2C6D0", VA = "0x1C2C6D0")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x6015BE4")]
	[Address(RVA = "0x1C2C6D8", Offset = "0x1C2C6D8", VA = "0x1C2C6D8")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015BE5")]
	[Address(RVA = "0x1C2C6E0", Offset = "0x1C2C6E0", VA = "0x1C2C6E0")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BE6")]
	[Address(RVA = "0x1C2C6E8", Offset = "0x1C2C6E8", VA = "0x1C2C6E8")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
