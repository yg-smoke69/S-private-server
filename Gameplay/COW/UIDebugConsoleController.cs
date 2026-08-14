using System;
using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200209F")]
public class UIDebugConsoleController : UIPopupWindowController
{
	[Token(Token = "0x20020A0")]
	public enum CmdType
	{
		[Token(Token = "0x400CC93")]
		NoArg,
		[Token(Token = "0x400CC94")]
		Arg1,
		[Token(Token = "0x400CC95")]
		Arg2,
		[Token(Token = "0x400CC96")]
		ArgPopup2,
		[Token(Token = "0x400CC97")]
		Toggle,
		[Token(Token = "0x400CC98")]
		ToggleArgs
	}

	[Token(Token = "0x20020A1")]
	private sealed class _003CChangeServer_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CC99")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSVBaseData> serverSettings;

		[Token(Token = "0x400CC9A")]
		[FieldOffset(Offset = "0xC")]
		internal UIDebugConsoleController _0024this;

		[Token(Token = "0x600A850")]
		[Address(RVA = "0x2D78EF0", Offset = "0x2D78EF0", VA = "0x2D78EF0")]
		public _003CChangeServer_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A851")]
		[Address(RVA = "0x2D78EF8", Offset = "0x2D78EF8", VA = "0x2D78EF8")]
		internal void _003C_003Em__0(string server)
		{
		}
	}

	[Token(Token = "0x20020A2")]
	private sealed class _003CChangeLanguage_003Ec__AnonStorey1
	{
		[Token(Token = "0x400CC9B")]
		[FieldOffset(Offset = "0x8")]
		internal List<int> langList;

		[Token(Token = "0x400CC9C")]
		[FieldOffset(Offset = "0xC")]
		internal UIDebugConsoleController _0024this;

		[Token(Token = "0x600A852")]
		[Address(RVA = "0x2D787C8", Offset = "0x2D787C8", VA = "0x2D787C8")]
		public _003CChangeLanguage_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600A853")]
		[Address(RVA = "0x2D787D0", Offset = "0x2D787D0", VA = "0x2D787D0")]
		internal void _003C_003Em__0(string langName)
		{
		}
	}

	[Token(Token = "0x20020A3")]
	private sealed class _003COnCustomCmdRunClick_003Ec__AnonStorey2
	{
		[Token(Token = "0x400CC9D")]
		[FieldOffset(Offset = "0x8")]
		internal string DEBUG_GRAPH_ID;

		[Token(Token = "0x600A854")]
		[Address(RVA = "0x2D792A8", Offset = "0x2D792A8", VA = "0x2D792A8")]
		public _003COnCustomCmdRunClick_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600A855")]
		[Address(RVA = "0x2D792B0", Offset = "0x2D792B0", VA = "0x2D792B0")]
		internal bool _003C_003Em__0(GraphData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20020A4")]
	private sealed class _003COnCustomCmdRunClick_003Ec__AnonStorey3
	{
		[Token(Token = "0x400CC9E")]
		[FieldOffset(Offset = "0x8")]
		internal string DEBUG_GRAPH_ID;

		[Token(Token = "0x600A856")]
		[Address(RVA = "0x2D79354", Offset = "0x2D79354", VA = "0x2D79354")]
		public _003COnCustomCmdRunClick_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600A857")]
		[Address(RVA = "0x2D7935C", Offset = "0x2D7935C", VA = "0x2D7935C")]
		internal bool _003C_003Em__0(GraphData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CC4D")]
	[FieldOffset(Offset = "0x48")]
	private UIDebugConsoleView m_View;

	[Token(Token = "0x400CC4E")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_DebugInfoState;

	[Token(Token = "0x400CC4F")]
	private const string Cmd_Offline = "Offline";

	[Token(Token = "0x400CC50")]
	private const string Cmd_DebugLogin = "DebugLogin";

	[Token(Token = "0x400CC51")]
	private const string Cmd_PCSelectServer = "PCSelectServer";

	[Token(Token = "0x400CC52")]
	private const string Cmd_SoloTestBattleA = "SoloTestBattleA";

	[Token(Token = "0x400CC53")]
	private const string Cmd_SoloTestBattleB = "SoloTestBattleB";

	[Token(Token = "0x400CC54")]
	private const string Cmd_SoloTestBattleC = "SoloTestBattleC";

	[Token(Token = "0x400CC55")]
	private const string Cmd_SoloTestBattleNEO = "SoloTestBattleNEO";

	[Token(Token = "0x400CC56")]
	private const string Cmd_SoloTestBattleNEOMAX = "SoloTestBattleNeoMax";

	[Token(Token = "0x400CC57")]
	private const string Cmd_SoloOfflineBattle = "SoloOfflineGame";

	[Token(Token = "0x400CC58")]
	private const string Cmd_MultiParadise = "MultiParadise";

	[Token(Token = "0x400CC59")]
	private const string Cmd_MultiAzores = "MultiAzores";

	[Token(Token = "0x400CC5A")]
	private const string Cmd_Training = "TrainingMode";

	[Token(Token = "0x400CC5B")]
	private const string Cmd_Wating = "Wating";

	[Token(Token = "0x400CC5C")]
	private const string Cmd_SingleSingersB = "SingleSingersB";

	[Token(Token = "0x400CC5D")]
	private const string Cmd_MultiGame = "MultiGame";

	[Token(Token = "0x400CC5E")]
	private const string Cmd_SingleGame = "SingleGame";

	[Token(Token = "0x400CC5F")]
	private const string Cmd_SingleGamePopup = "SingleGamePopup";

	[Token(Token = "0x400CC60")]
	private const string Cmd_Room = "Room";

	[Token(Token = "0x400CC61")]
	private const string Cmd_AIObserver = "AIObserver";

	[Token(Token = "0x400CC62")]
	private const string Cmd_TutorialGame = "TutorialGame";

	[Token(Token = "0x400CC63")]
	private const string Cmd_Cloth = "Cloth";

	[Token(Token = "0x400CC64")]
	private const string Cmd_LDWhiteBox = "LDWhiteBox";

	[Token(Token = "0x400CC65")]
	private const string Cmd_SetGS = "SetGS";

	[Token(Token = "0x400CC66")]
	private const string Cmd_SetOnlineGS = "SetOnlineGS";

	[Token(Token = "0x400CC67")]
	private const string Cmd_Notch = "Notch";

	[Token(Token = "0x400CC68")]
	private const string Cmd_LoginBGSwitch = "LoginBGSwitch";

	[Token(Token = "0x400CC69")]
	private const string Cmd_ChangeServer = "ChangeServer";

	[Token(Token = "0x400CC6A")]
	private const string Cmd_LobbyBGSwitch = "LobbyBGSwitch";

	[Token(Token = "0x400CC6B")]
	private const string Cmd_BountyWaiting = "BountyWaiting";

	[Token(Token = "0x400CC6C")]
	private const string Cmd_Monopoly = "Monopoly";

	[Token(Token = "0x400CC6D")]
	private const string Cmd_ChangeLanguage = "ChangeLanguage";

	[Token(Token = "0x400CC6E")]
	private const string Cmd_ShowTestBtn = "ShowTestBtn";

	[Token(Token = "0x400CC6F")]
	private const string Cmd_ShowLabelParam = "ShowLabelParam";

	[Token(Token = "0x400CC70")]
	private const string Cmd_LocStyleSwitch = "LocStyleSwitch";

	[Token(Token = "0x400CC71")]
	private const string Cmd_WereWholves = "WereWholves";

	[Token(Token = "0x400CC72")]
	private const string Cmd_SingleWereWholves = "SingleWereWholves";

	[Token(Token = "0x400CC73")]
	private const string Cmd_CupMatchFaction = "CupMatchFaction";

	[Token(Token = "0x400CC74")]
	private const string Cmd_CupMatchCourse = "CupMatchCourse";

	[Token(Token = "0x400CC75")]
	private const string Cmd_CupMatchChampion = "CupMatchChampion";

	[Token(Token = "0x400CC76")]
	private const string Cmd_CupMatchReward = "CupMatchReward";

	[Token(Token = "0x400CC77")]
	private const string Cmd_Navigate = "Navigate";

	[Token(Token = "0x400CC78")]
	private const string Cmd_PlayerprefDeleteAll = "PlayerprefDeleteAll";

	[Token(Token = "0x400CC79")]
	private const string Cmd_SetDevId = "SetDevId";

	[Token(Token = "0x400CC7A")]
	private const string Cmd_ResetIngameTutorial = "ResetIngameTutorial";

	[Token(Token = "0x400CC7B")]
	private const string Cmd_Replay = "Replay";

	[Token(Token = "0x400CC7C")]
	private const string Cmd_OpenProxy = "Proxy";

	[Token(Token = "0x400CC7D")]
	private const string Cmd_RunUGC = "UGCEditMode";

	[Token(Token = "0x400CC7E")]
	private const string Cmd_VeteranReturn = "VeteranReturn";

	[Token(Token = "0x400CC7F")]
	private const string Cmd_LobbyRepop = "LobbyRepop";

	[Token(Token = "0x400CC80")]
	private const string Cmd_ReturnRepop = "ReturnRepop";

	[Token(Token = "0x400CC81")]
	private const string Cmd_CopyPlatformInfo = "CopyPlatformInfo";

	[Token(Token = "0x400CC82")]
	private const string Cmd_DebugPlatformLogin = "DebugPlatformLogin";

	[Token(Token = "0x400CC83")]
	private const string Cmd_TutorialBR = "TutorialBR";

	[Token(Token = "0x400CC84")]
	private const string Cmd_DebugPlatformProductionExchange = "DebugPlatformProductionExchange";

	[Token(Token = "0x400CC85")]
	private const string Cmd_TutorialCS = "TutorialCS";

	[Token(Token = "0x400CC86")]
	private const string Cmd_LegentClothVault = "LegentClothVault";

	[Token(Token = "0x400CC87")]
	private const string Cmd_ResetTutorial = "ResetTutorial";

	[Token(Token = "0x400CC88")]
	private const string Cmd_TriggerCrash = "TriggerCrash";

	[Token(Token = "0x400CC89")]
	private const string Cmd_LobbyAutoTaskPop = "LobbyAutoTaskPop";

	[Token(Token = "0x400CC8A")]
	public const string KeyLobbyAutoTaskPop = "KeyLobbyAutoTaskPop";

	[Token(Token = "0x400CC8B")]
	private const string Cmd_SkipTutorialBR = "SkipTutorialBR";

	[Token(Token = "0x400CC8C")]
	public const string KeySkipTutorialBR = "KeySkipTutorialBR";

	[Token(Token = "0x400CC8D")]
	private const string Cmd_NewPreviewTest = "NewPreviewTest";

	[Token(Token = "0x400CC8E")]
	private const string Cmd_HideClientDamage = "HideClientDamage";

	[Token(Token = "0x400CC8F")]
	public const string Cmd_AutoAddPlayer = "AutoAddPlayer";

	[Token(Token = "0x400CC90")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<int, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CC91")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<CSVBaseData, PlatformPromotionProductsData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600A810")]
	[Address(RVA = "0x11FA454", Offset = "0x11FA454", VA = "0x11FA454")]
	public UIDebugConsoleController()
	{
	}

	[Token(Token = "0x600A811")]
	[Address(RVA = "0x11FA45C", Offset = "0x11FA45C", VA = "0x11FA45C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A812")]
	[Address(RVA = "0x11FA504", Offset = "0x11FA504", VA = "0x11FA504", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A813")]
	[Address(RVA = "0x11FE778", Offset = "0x11FE778", VA = "0x11FE778", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A814")]
	[Address(RVA = "0x11FA728", Offset = "0x11FA728", VA = "0x11FA728")]
	private void InitCmdTemplate()
	{
	}

	[Token(Token = "0x600A815")]
	[Address(RVA = "0x11FAA74", Offset = "0x11FAA74", VA = "0x11FAA74")]
	private void InitCmds()
	{
	}

	[Token(Token = "0x600A816")]
	[Address(RVA = "0x11FE85C", Offset = "0x11FE85C", VA = "0x11FE85C")]
	private void RunCmd(string cmd, object[] args)
	{
	}

	[Token(Token = "0x600A817")]
	[Address(RVA = "0x1208F58", Offset = "0x1208F58", VA = "0x1208F58")]
	private void GotoNewPreviewTest()
	{
	}

	[Token(Token = "0x600A818")]
	[Address(RVA = "0x1202204", Offset = "0x1202204", VA = "0x1202204")]
	private void OnBtnLoginOfflineClick()
	{
	}

	[Token(Token = "0x600A819")]
	[Address(RVA = "0x120270C", Offset = "0x120270C", VA = "0x120270C")]
	private void OnBtnPCSelectServerClick()
	{
	}

	[Token(Token = "0x600A81A")]
	[Address(RVA = "0x1202C40", Offset = "0x1202C40", VA = "0x1202C40")]
	private void GotoSinglePlayerGame(ulong matchID, uint mapID)
	{
	}

	[Token(Token = "0x600A81B")]
	[Address(RVA = "0x1203244", Offset = "0x1203244", VA = "0x1203244")]
	private void GotoSingleSingersBGame()
	{
	}

	[Token(Token = "0x600A81C")]
	[Address(RVA = "0x1202FC8", Offset = "0x1202FC8", VA = "0x1202FC8")]
	private void OnBtnEnterGameMGClick(uint matchID, uint mapID)
	{
	}

	[Token(Token = "0x600A81D")]
	[Address(RVA = "0x12038C8", Offset = "0x12038C8", VA = "0x12038C8")]
	private void OnBtnTestSingleplayerGameClick(uint mapID, uint modeID)
	{
	}

	[Token(Token = "0x600A81E")]
	[Address(RVA = "0x12035DC", Offset = "0x12035DC", VA = "0x12035DC")]
	private void OnBtnTestMultiplayerGameClick(uint mapID, uint modeID)
	{
	}

	[Token(Token = "0x600A81F")]
	[Address(RVA = "0x1203CD8", Offset = "0x1203CD8", VA = "0x1203CD8")]
	private void OnRoomTestClick(uint mapID, uint modeID)
	{
	}

	[Token(Token = "0x600A820")]
	[Address(RVA = "0x12041CC", Offset = "0x12041CC", VA = "0x12041CC")]
	private void OnAIObserverTestClick(uint roomID, uint mapID)
	{
	}

	[Token(Token = "0x600A821")]
	[Address(RVA = "0x12046BC", Offset = "0x12046BC", VA = "0x12046BC")]
	private void OnBtnTestClothClick()
	{
	}

	[Token(Token = "0x600A822")]
	[Address(RVA = "0x1204914", Offset = "0x1204914", VA = "0x1204914")]
	private void OnBtnLDWhiteBoxClick()
	{
	}

	[Token(Token = "0x600A823")]
	[Address(RVA = "0x1204968", Offset = "0x1204968", VA = "0x1204968")]
	private void OnWatingClick()
	{
	}

	[Token(Token = "0x600A824")]
	[Address(RVA = "0x1204E54", Offset = "0x1204E54", VA = "0x1204E54")]
	private void OnBountyWaitingClick()
	{
	}

	[Token(Token = "0x600A825")]
	[Address(RVA = "0x1205410", Offset = "0x1205410", VA = "0x1205410")]
	private void OnTutorialGameClick()
	{
	}

	[Token(Token = "0x600A826")]
	[Address(RVA = "0x1206D64", Offset = "0x1206D64", VA = "0x1206D64")]
	private void OnWereWholvesClick()
	{
	}

	[Token(Token = "0x600A827")]
	[Address(RVA = "0x1207088", Offset = "0x1207088", VA = "0x1207088")]
	private void OnSingleWereWovlesClick()
	{
	}

	[Token(Token = "0x600A828")]
	[Address(RVA = "0x12090B0", Offset = "0x12090B0", VA = "0x12090B0")]
	private void OnSingleWereWholvesClick()
	{
	}

	[Token(Token = "0x600A829")]
	[Address(RVA = "0x12057A4", Offset = "0x12057A4", VA = "0x12057A4")]
	private void SetGS(string gsIP, string port)
	{
	}

	[Token(Token = "0x600A82A")]
	[Address(RVA = "0x1205AAC", Offset = "0x1205AAC", VA = "0x1205AAC")]
	private void SetNotch()
	{
	}

	[Token(Token = "0x600A82B")]
	[Address(RVA = "0x1205D28", Offset = "0x1205D28", VA = "0x1205D28")]
	private void LoginBGSwitch()
	{
	}

	[Token(Token = "0x600A82C")]
	[Address(RVA = "0x1206224", Offset = "0x1206224", VA = "0x1206224")]
	private void LobbyBGSwitch()
	{
	}

	[Token(Token = "0x600A82D")]
	[Address(RVA = "0x1205E40", Offset = "0x1205E40", VA = "0x1205E40")]
	private void ChangeServer()
	{
	}

	[Token(Token = "0x600A82E")]
	[Address(RVA = "0x120633C", Offset = "0x120633C", VA = "0x120633C")]
	private void ChangeLanguage()
	{
	}

	[Token(Token = "0x600A82F")]
	[Address(RVA = "0x12065D0", Offset = "0x12065D0", VA = "0x12065D0")]
	private void ShowTestBtn(bool show)
	{
	}

	[Token(Token = "0x600A830")]
	[Address(RVA = "0x12085DC", Offset = "0x12085DC", VA = "0x12085DC")]
	private void ShowProxyContent(bool show)
	{
	}

	[Token(Token = "0x600A831")]
	[Address(RVA = "0x12087E8", Offset = "0x12087E8", VA = "0x12087E8")]
	private void ToggleLobbyAutoTaskPop(bool isChecked)
	{
	}

	[Token(Token = "0x600A832")]
	[Address(RVA = "0x1208908", Offset = "0x1208908", VA = "0x1208908")]
	private void OnToggleSkipTutorialBRClick(bool isChecked)
	{
	}

	[Token(Token = "0x600A833")]
	[Address(RVA = "0x1206770", Offset = "0x1206770", VA = "0x1206770")]
	private void ShowLabelParam(bool show)
	{
	}

	[Token(Token = "0x600A834")]
	[Address(RVA = "0x1207404", Offset = "0x1207404", VA = "0x1207404")]
	private void OnCupMatchFactionClick(string win)
	{
	}

	[Token(Token = "0x600A835")]
	[Address(RVA = "0x12078BC", Offset = "0x12078BC", VA = "0x12078BC")]
	private void OnCupMatchCouseClick(string result)
	{
	}

	[Token(Token = "0x600A836")]
	[Address(RVA = "0x1207FD4", Offset = "0x1207FD4", VA = "0x1207FD4")]
	private void OnCupMatchChampionClick()
	{
	}

	[Token(Token = "0x600A837")]
	[Address(RVA = "0x12081C8", Offset = "0x12081C8", VA = "0x12081C8")]
	private void OnCupMatchRewardClick(string result)
	{
	}

	[Token(Token = "0x600A838")]
	[Address(RVA = "0x12092E4", Offset = "0x12092E4", VA = "0x12092E4")]
	private void OpenProxy()
	{
	}

	[Token(Token = "0x600A839")]
	[Address(RVA = "0x1208A28", Offset = "0x1208A28", VA = "0x1208A28")]
	private void OnCopyPlatformInfo()
	{
	}

	[Token(Token = "0x600A83A")]
	[Address(RVA = "0x1209338", Offset = "0x1209338", VA = "0x1209338")]
	private void OnCustomCmdRunClick()
	{
	}

	[Token(Token = "0x600A83B")]
	[Address(RVA = "0x12067CC", Offset = "0x12067CC", VA = "0x12067CC")]
	private void OnLocStyleSwitch()
	{
	}

	[Token(Token = "0x600A83C")]
	[Address(RVA = "0x1206934", Offset = "0x1206934", VA = "0x1206934")]
	private void OnDebugExchangeProdution()
	{
	}

	[Token(Token = "0x600A83D")]
	[Address(RVA = "0x120B8AC", Offset = "0x120B8AC", VA = "0x120B8AC")]
	private void ShowPlatformPromotionProductMessageBox()
	{
	}

	[Token(Token = "0x600A83E")]
	[Address(RVA = "0x120B83C", Offset = "0x120B83C", VA = "0x120B83C")]
	private void CheckCustomCmd(string cmd, string[] args)
	{
	}

	[Token(Token = "0x600A83F")]
	[Address(RVA = "0x120BA70", Offset = "0x120BA70", VA = "0x120BA70")]
	public void StartSingleGame(string mapid, string modeid)
	{
	}

	[Token(Token = "0x600A840")]
	[Address(RVA = "0x120BC0C", Offset = "0x120BC0C", VA = "0x120BC0C")]
	private IUITable2Item _003CInitCmdTemplate_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x600A841")]
	[Address(RVA = "0x120BD3C", Offset = "0x120BD3C", VA = "0x120BD3C")]
	private IUITable2Item _003CInitCmdTemplate_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x600A842")]
	[Address(RVA = "0x120BE6C", Offset = "0x120BE6C", VA = "0x120BE6C")]
	private IUITable2Item _003CInitCmdTemplate_003Em__2()
	{
		return null;
	}

	[Token(Token = "0x600A843")]
	[Address(RVA = "0x120BF9C", Offset = "0x120BF9C", VA = "0x120BF9C")]
	private IUITable2Item _003CInitCmdTemplate_003Em__3()
	{
		return null;
	}

	[Token(Token = "0x600A844")]
	[Address(RVA = "0x120C0CC", Offset = "0x120C0CC", VA = "0x120C0CC")]
	private IUITable2Item _003CInitCmdTemplate_003Em__4()
	{
		return null;
	}

	[Token(Token = "0x600A845")]
	[Address(RVA = "0x120C1FC", Offset = "0x120C1FC", VA = "0x120C1FC")]
	private IUITable2Item _003CInitCmdTemplate_003Em__5()
	{
		return null;
	}

	[Token(Token = "0x600A846")]
	[Address(RVA = "0x120C32C", Offset = "0x120C32C", VA = "0x120C32C")]
	private static string _003CChangeLanguage_003Em__6(int lang)
	{
		return null;
	}

	[Token(Token = "0x600A847")]
	[Address(RVA = "0x120C3B0", Offset = "0x120C3B0", VA = "0x120C3B0")]
	private static PlatformPromotionProductsData _003COnDebugExchangeProdution_003Em__7(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x600A848")]
	[Address(RVA = "0x120C444", Offset = "0x120C444", VA = "0x120C444")]
	private void _003CInitCmdTemplate_003Em__8(string cmd)
	{
	}

	[Token(Token = "0x600A849")]
	[Address(RVA = "0x120C4BC", Offset = "0x120C4BC", VA = "0x120C4BC")]
	private void _003CInitCmdTemplate_003Em__9(string cmd, string arg)
	{
	}

	[Token(Token = "0x600A84A")]
	[Address(RVA = "0x120C59C", Offset = "0x120C59C", VA = "0x120C59C")]
	private void _003CInitCmdTemplate_003Em__A(string cmd, string arg1, string arg2)
	{
	}

	[Token(Token = "0x600A84B")]
	[Address(RVA = "0x120C6D0", Offset = "0x120C6D0", VA = "0x120C6D0")]
	private void _003CInitCmdTemplate_003Em__B(string cmd, string arg1, string arg2)
	{
	}

	[Token(Token = "0x600A84C")]
	[Address(RVA = "0x120C804", Offset = "0x120C804", VA = "0x120C804")]
	private void _003CInitCmdTemplate_003Em__C(string cmd, bool arg1)
	{
	}

	[Token(Token = "0x600A84D")]
	[Address(RVA = "0x120C90C", Offset = "0x120C90C", VA = "0x120C90C")]
	private void _003CInitCmdTemplate_003Em__D(string cmd, int index, bool togglevalue, object[] args)
	{
	}

	[Token(Token = "0x600A84E")]
	[Address(RVA = "0x120CBCC", Offset = "0x120CBCC", VA = "0x120CBCC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A84F")]
	[Address(RVA = "0x120CBD4", Offset = "0x120CBD4", VA = "0x120CBD4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
