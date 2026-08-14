using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200333C")]
internal class UIWereWolvesGameScene : UIInGameScene
{
	[Token(Token = "0x4013857")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudWereWolvesTaskController m_HudTask;

	[Token(Token = "0x4013858")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudWereWolvesVoteController m_HudVote;

	[Token(Token = "0x4013859")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHUDWolfKillActionController m_WolfKill;

	[Token(Token = "0x401385A")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHUDSelfInfoController m_SelfInfo;

	[Token(Token = "0x401385B")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudWereWolvesInteractController m_Interact;

	[Token(Token = "0x401385C")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHUDReadyVote m_ReadyVote;

	[Token(Token = "0x401385D")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHUDUseTrapController m_UseTrapController;

	[Token(Token = "0x401385E")]
	[FieldOffset(Offset = "0x2E4")]
	private Dictionary<uint, List<UIBaseController>> m_PhaseShowControllerMap;

	[Token(Token = "0x401385F")]
	[FieldOffset(Offset = "0x2E8")]
	private DAHEMOKAHIN m_CurPhase;

	[Token(Token = "0x4013860")]
	[FieldOffset(Offset = "0x2EC")]
	private Dictionary<UIHudTaskNameIconController, bool> m_ActiveTaskNameIconMap;

	[Token(Token = "0x4013861")]
	[FieldOffset(Offset = "0x2F0")]
	private UIHudWereWolvesVoiceEngineController m_VoiceController;

	[Token(Token = "0x4013862")]
	[FieldOffset(Offset = "0x2F4")]
	private UIHudMovingJoystickController m_MoveBtn;

	[Token(Token = "0x4013863")]
	[FieldOffset(Offset = "0x2F8")]
	private UIHudWereWolvesInfoController m_GameInfoHUD;

	[Token(Token = "0x4013864")]
	[FieldOffset(Offset = "0x2FC")]
	private UIBigMapController m_BigMap;

	[Token(Token = "0x4013865")]
	[FieldOffset(Offset = "0x300")]
	private UIHudWolfTaskController m_WolfTask;

	[Token(Token = "0x4013866")]
	[FieldOffset(Offset = "0x304")]
	private UIHUDWereWolvesPrepareInfoController m_PrepareInfoController;

	[Token(Token = "0x4013867")]
	[FieldOffset(Offset = "0x308")]
	private UIHudModeIntroInfoController m_IntroController;

	[Token(Token = "0x4013868")]
	[FieldOffset(Offset = "0x30C")]
	private UIHUDWereWolvesCampInfoController m_CampInfoController;

	[Token(Token = "0x4013869")]
	[FieldOffset(Offset = "0x310")]
	private UIHUDWereWolvesEndShowTime m_EndShowTime;

	[Token(Token = "0x401386A")]
	[FieldOffset(Offset = "0x314")]
	private UIHudJumpController m_JumpCtrl;

	[Token(Token = "0x401386B")]
	[FieldOffset(Offset = "0x318")]
	private UIHUDTrapActionController m_TrapRescureAction;

	[Token(Token = "0x401386C")]
	[FieldOffset(Offset = "0x31C")]
	private UIHUDTrapActionController m_InTrapAction;

	[Token(Token = "0x401386D")]
	[FieldOffset(Offset = "0x320")]
	private UIHUDWereWolvesUsePredictTool m_UsePredict;

	[Token(Token = "0x401386E")]
	[FieldOffset(Offset = "0x324")]
	private UIHUDWereWolvesPredictToolCountDown m_PredictCountDown;

	[Token(Token = "0x6015C0F")]
	[Address(RVA = "0x1B84B5C", Offset = "0x1B84B5C", VA = "0x1B84B5C")]
	public UIWereWolvesGameScene()
	{
	}

	[Token(Token = "0x6015C10")]
	[Address(RVA = "0x1B84C48", Offset = "0x1B84C48", VA = "0x1B84C48", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015C11")]
	[Address(RVA = "0x1B86570", Offset = "0x1B86570", VA = "0x1B86570", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015C12")]
	[Address(RVA = "0x1B86BEC", Offset = "0x1B86BEC", VA = "0x1B86BEC", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015C13")]
	[Address(RVA = "0x1B87268", Offset = "0x1B87268", VA = "0x1B87268")]
	private void OnPlayerRoleChange(object[] data)
	{
	}

	[Token(Token = "0x6015C14")]
	[Address(RVA = "0x1B8737C", Offset = "0x1B8737C", VA = "0x1B8737C")]
	private void ProcessLocalPlayerRoleChange(DAMCDPIBGNE role)
	{
	}

	[Token(Token = "0x6015C15")]
	[Address(RVA = "0x1B87D74", Offset = "0x1B87D74", VA = "0x1B87D74")]
	private void OnShowTaskPanel(object[] data)
	{
	}

	[Token(Token = "0x6015C16")]
	[Address(RVA = "0x1B88408", Offset = "0x1B88408", VA = "0x1B88408")]
	private void OnShowVotePanel(object[] data)
	{
	}

	[Token(Token = "0x6015C17")]
	[Address(RVA = "0x1B88550", Offset = "0x1B88550", VA = "0x1B88550")]
	private void OnPlayerReadyVote(object[] data)
	{
	}

	[Token(Token = "0x6015C18")]
	[Address(RVA = "0x1B88680", Offset = "0x1B88680", VA = "0x1B88680")]
	private void OnPlayerExitReadyVote(object[] data)
	{
	}

	[Token(Token = "0x6015C19")]
	[Address(RVA = "0x1B8880C", Offset = "0x1B8880C", VA = "0x1B8880C")]
	private void OnBuffNoMap(object[] data)
	{
	}

	[Token(Token = "0x6015C1A")]
	[Address(RVA = "0x1B88A34", Offset = "0x1B88A34", VA = "0x1B88A34")]
	private void ShowOrHideTaskName(bool isShow)
	{
	}

	[Token(Token = "0x6015C1B")]
	[Address(RVA = "0x1B84EBC", Offset = "0x1B84EBC", VA = "0x1B84EBC")]
	public void OpenMiniMap()
	{
	}

	[Token(Token = "0x6015C1C")]
	[Address(RVA = "0x1B85090", Offset = "0x1B85090", VA = "0x1B85090")]
	public void OpenBigMap()
	{
	}

	[Token(Token = "0x6015C1D")]
	[Address(RVA = "0x1B852BC", Offset = "0x1B852BC", VA = "0x1B852BC")]
	public void OpenMoveBtn()
	{
	}

	[Token(Token = "0x6015C1E")]
	[Address(RVA = "0x1B85904", Offset = "0x1B85904", VA = "0x1B85904")]
	public void OpenInteract()
	{
	}

	[Token(Token = "0x6015C1F")]
	[Address(RVA = "0x1B85A78", Offset = "0x1B85A78", VA = "0x1B85A78")]
	public void OpenReadyVote()
	{
	}

	[Token(Token = "0x6015C20")]
	[Address(RVA = "0x1B860C0", Offset = "0x1B860C0", VA = "0x1B860C0")]
	public void OpenVoteResult()
	{
	}

	[Token(Token = "0x6015C21")]
	[Address(RVA = "0x1B85428", Offset = "0x1B85428", VA = "0x1B85428")]
	public void OpenTaskHUD()
	{
	}

	[Token(Token = "0x6015C22")]
	[Address(RVA = "0x1B8559C", Offset = "0x1B8559C", VA = "0x1B8559C")]
	public void OpenVoteHUD()
	{
	}

	[Token(Token = "0x6015C23")]
	[Address(RVA = "0x1B85750", Offset = "0x1B85750", VA = "0x1B85750")]
	private void OpenGameInfoHUD()
	{
	}

	[Token(Token = "0x6015C24")]
	[Address(RVA = "0x1B87764", Offset = "0x1B87764", VA = "0x1B87764")]
	private void OpenTaskList()
	{
	}

	[Token(Token = "0x6015C25")]
	[Address(RVA = "0x1B87C04", Offset = "0x1B87C04", VA = "0x1B87C04")]
	private void OpenTaskWolfList()
	{
	}

	[Token(Token = "0x6015C26")]
	[Address(RVA = "0x1B87A90", Offset = "0x1B87A90", VA = "0x1B87A90")]
	private void OpenWolfTask()
	{
	}

	[Token(Token = "0x6015C27")]
	[Address(RVA = "0x1B85D74", Offset = "0x1B85D74", VA = "0x1B85D74")]
	private void OpenWolfCount()
	{
	}

	[Token(Token = "0x6015C28")]
	[Address(RVA = "0x1B85C58", Offset = "0x1B85C58", VA = "0x1B85C58")]
	private void OpenVoiceEngine()
	{
	}

	[Token(Token = "0x6015C29")]
	[Address(RVA = "0x1B88D44", Offset = "0x1B88D44", VA = "0x1B88D44")]
	private void CloseVoiceEngine()
	{
	}

	[Token(Token = "0x6015C2A")]
	[Address(RVA = "0x1B85F4C", Offset = "0x1B85F4C", VA = "0x1B85F4C")]
	private void OpenPrepareHUD()
	{
	}

	[Token(Token = "0x6015C2B")]
	[Address(RVA = "0x1B86298", Offset = "0x1B86298", VA = "0x1B86298")]
	private void OpenSpeedUpHUD()
	{
	}

	[Token(Token = "0x6015C2C")]
	[Address(RVA = "0x1B878D4", Offset = "0x1B878D4", VA = "0x1B878D4")]
	private void OpenWolfKillHUD()
	{
	}

	[Token(Token = "0x6015C2D")]
	[Address(RVA = "0x1B88E48", Offset = "0x1B88E48", VA = "0x1B88E48")]
	private void OpenIntroInfoHUD()
	{
	}

	[Token(Token = "0x6015C2E")]
	[Address(RVA = "0x1B88F90", Offset = "0x1B88F90", VA = "0x1B88F90")]
	public void OpenCampInfo(bool isWolf, int wolfCount, List<byte> wolfsColorIndex, bool isPredictToolOwner)
	{
	}

	[Token(Token = "0x6015C2F")]
	[Address(RVA = "0x1B89224", Offset = "0x1B89224", VA = "0x1B89224")]
	public void OpenHumanKilledHUD(IHAAMHPPLMG humanPlayerID, IHAAMHPPLMG wolfPlayerID, bool isFinalKill)
	{
	}

	[Token(Token = "0x6015C30")]
	[Address(RVA = "0x1B895A8", Offset = "0x1B895A8", VA = "0x1B895A8")]
	public void OnNewPhaseCome(object[] param)
	{
	}

	[Token(Token = "0x6015C31")]
	[Address(RVA = "0x1B89F40", Offset = "0x1B89F40", VA = "0x1B89F40")]
	public void OpenEndShowTime()
	{
	}

	[Token(Token = "0x6015C32")]
	[Address(RVA = "0x1B8A05C", Offset = "0x1B8A05C", VA = "0x1B8A05C")]
	public void OpenMatchResult()
	{
	}

	[Token(Token = "0x6015C33")]
	[Address(RVA = "0x1B86404", Offset = "0x1B86404", VA = "0x1B86404")]
	public void OpenJumpBtn()
	{
	}

	[Token(Token = "0x6015C34")]
	[Address(RVA = "0x1B8A1B4", Offset = "0x1B8A1B4", VA = "0x1B8A1B4")]
	private void OnLocalPlayerBunkerStateCome(object[] param)
	{
	}

	[Token(Token = "0x6015C35")]
	public T OpenUIByGamePhase<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, [Optional] List<uint> gamePhases) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015C36")]
	[Address(RVA = "0x1B8A6D8", Offset = "0x1B8A6D8", VA = "0x1B8A6D8")]
	public void OnAddTaskNameController(UIHudTaskNameIconController controller)
	{
	}

	[Token(Token = "0x6015C37")]
	[Address(RVA = "0x1B8A7EC", Offset = "0x1B8A7EC", VA = "0x1B8A7EC")]
	public void OnRemoveTaskNameController(UIHudTaskNameIconController controller)
	{
	}

	[Token(Token = "0x6015C38")]
	[Address(RVA = "0x1B8A8FC", Offset = "0x1B8A8FC", VA = "0x1B8A8FC")]
	private UIHudTaskNameIconController FindNearestTaskNameIcon()
	{
		return null;
	}

	[Token(Token = "0x6015C39")]
	[Address(RVA = "0x1B8AD48", Offset = "0x1B8AD48", VA = "0x1B8AD48")]
	public void BeginTutorial(bool isWolf)
	{
	}

	[Token(Token = "0x6015C3A")]
	[Address(RVA = "0x1B8ADC4", Offset = "0x1B8ADC4", VA = "0x1B8ADC4")]
	private void ShowTaskIconTurorial(bool isWolf)
	{
	}

	[Token(Token = "0x6015C3B")]
	[Address(RVA = "0x1B8AED0", Offset = "0x1B8AED0", VA = "0x1B8AED0")]
	private void ShowKillTutorial()
	{
	}

	[Token(Token = "0x6015C3C")]
	[Address(RVA = "0x1B8B0CC", Offset = "0x1B8B0CC", VA = "0x1B8B0CC")]
	private void OnShowWolfDestroyTutorial(object[] param)
	{
	}

	[Token(Token = "0x6015C3D")]
	[Address(RVA = "0x1B8B27C", Offset = "0x1B8B27C", VA = "0x1B8B27C")]
	private void OnShowWolfFakeTaskTutorial(object[] param)
	{
	}

	[Token(Token = "0x6015C3E")]
	[Address(RVA = "0x1B8B2E8", Offset = "0x1B8B2E8", VA = "0x1B8B2E8")]
	public void ShowFinalTaskComplete(string nickName)
	{
	}

	[Token(Token = "0x6015C3F")]
	[Address(RVA = "0x1B8B3F0", Offset = "0x1B8B3F0", VA = "0x1B8B3F0")]
	private void OnTrapCountUpdate(object[] param)
	{
	}

	[Token(Token = "0x6015C40")]
	[Address(RVA = "0x1B8B660", Offset = "0x1B8B660", VA = "0x1B8B660")]
	private void OnRefreshTrapRescureShow(object[] param)
	{
	}

	[Token(Token = "0x6015C41")]
	[Address(RVA = "0x1B8B8F4", Offset = "0x1B8B8F4", VA = "0x1B8B8F4")]
	private void OnRefreshInTrapState(object[] param)
	{
	}

	[Token(Token = "0x6015C42")]
	[Address(RVA = "0x1B8BC18", Offset = "0x1B8BC18", VA = "0x1B8BC18")]
	private void InTrapDisableOperationUI(bool isDisable)
	{
	}

	[Token(Token = "0x6015C43")]
	[Address(RVA = "0x1B8C014", Offset = "0x1B8C014", VA = "0x1B8C014")]
	private void OnPredictToolEndTimeCome(object[] param)
	{
	}

	[Token(Token = "0x6015C44")]
	[Address(RVA = "0x1B8C468", Offset = "0x1B8C468", VA = "0x1B8C468")]
	private void _003COpenIntroInfoHUD_003Em__0()
	{
	}

	[Token(Token = "0x6015C45")]
	[Address(RVA = "0x1B8C530", Offset = "0x1B8C530", VA = "0x1B8C530")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015C46")]
	[Address(RVA = "0x1B8C538", Offset = "0x1B8C538", VA = "0x1B8C538")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015C47")]
	[Address(RVA = "0x1B8C540", Offset = "0x1B8C540", VA = "0x1B8C540")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
