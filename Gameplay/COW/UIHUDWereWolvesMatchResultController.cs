using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002C45")]
internal class UIHUDWereWolvesMatchResultController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x4010E1C")]
	private const int CONST_LEFTCOUNT = 5;

	[Token(Token = "0x4010E1D")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesMatchResultView m_View;

	[Token(Token = "0x4010E1E")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsLocalPlayerWolf;

	[Token(Token = "0x4010E1F")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_IsQuited;

	[Token(Token = "0x4010E20")]
	[FieldOffset(Offset = "0x30")]
	protected UIModelMatch m_ModelMatch;

	[Token(Token = "0x4010E21")]
	[FieldOffset(Offset = "0x34")]
	protected MatchStats m_MatchStats;

	[Token(Token = "0x4010E22")]
	[FieldOffset(Offset = "0x38")]
	protected MatchIncome m_MatchIncome;

	[Token(Token = "0x4010E23")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<ulong, UIHUDWereWolvesPlayerResultItem> m_PlayerItemList;

	[Token(Token = "0x4010E24")]
	[FieldOffset(Offset = "0x40")]
	private float m_EndTime;

	[Token(Token = "0x4010E25")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601276D")]
	[Address(RVA = "0x1621038", Offset = "0x1621038", VA = "0x1621038")]
	public UIHUDWereWolvesMatchResultController()
	{
	}

	[Token(Token = "0x601276E")]
	[Address(RVA = "0x16210F0", Offset = "0x16210F0", VA = "0x16210F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601276F")]
	[Address(RVA = "0x1621198", Offset = "0x1621198", VA = "0x1621198", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012770")]
	[Address(RVA = "0x1621B60", Offset = "0x1621B60", VA = "0x1621B60", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012771")]
	[Address(RVA = "0x1621E4C", Offset = "0x1621E4C", VA = "0x1621E4C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6012772")]
	[Address(RVA = "0x16224AC", Offset = "0x16224AC", VA = "0x16224AC")]
	public void InitDataShow()
	{
	}

	[Token(Token = "0x6012773")]
	[Address(RVA = "0x16229E4", Offset = "0x16229E4", VA = "0x16229E4")]
	private void InitPlayersInfo(List<EFDMPMPPEAK> PlayerList)
	{
	}

	[Token(Token = "0x6012774")]
	[Address(RVA = "0x1622E34", Offset = "0x1622E34", VA = "0x1622E34")]
	private void OnRefreshChatInfo(object[] data)
	{
	}

	[Token(Token = "0x6012775")]
	[Address(RVA = "0x1623078", Offset = "0x1623078", VA = "0x1623078")]
	private void OnSendChat()
	{
	}

	[Token(Token = "0x6012776")]
	[Address(RVA = "0x16234D0", Offset = "0x16234D0", VA = "0x16234D0")]
	public void OnEndTimeCome(object[] param)
	{
	}

	[Token(Token = "0x6012777")]
	[Address(RVA = "0x16235C4", Offset = "0x16235C4", VA = "0x16235C4")]
	private void OnVoice()
	{
	}

	[Token(Token = "0x6012778")]
	[Address(RVA = "0x162375C", Offset = "0x162375C", VA = "0x162375C")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x6012779")]
	[Address(RVA = "0x1621EB8", Offset = "0x1621EB8", VA = "0x1621EB8")]
	public void RefreshVoiceButtonState()
	{
	}

	[Token(Token = "0x601277A")]
	[Address(RVA = "0x16237C4", Offset = "0x16237C4", VA = "0x16237C4")]
	private void Update()
	{
	}

	[Token(Token = "0x601277B")]
	[Address(RVA = "0x1623824", Offset = "0x1623824", VA = "0x1623824")]
	private void UpdateLeftTimeShow()
	{
	}

	[Token(Token = "0x601277C")]
	[Address(RVA = "0x16241C8", Offset = "0x16241C8", VA = "0x16241C8")]
	private void OpenSharePage()
	{
	}

	[Token(Token = "0x601277D")]
	[Address(RVA = "0x16243E8", Offset = "0x16243E8", VA = "0x16243E8")]
	private void FromSharePage()
	{
	}

	[Token(Token = "0x601277E")]
	[Address(RVA = "0x16244F0", Offset = "0x16244F0", VA = "0x16244F0", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x601277F")]
	[Address(RVA = "0x16239DC", Offset = "0x16239DC", VA = "0x16239DC")]
	private void QuitGame()
	{
	}

	[Token(Token = "0x6012780")]
	[Address(RVA = "0x1624604", Offset = "0x1624604", VA = "0x1624604", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6012781")]
	[Address(RVA = "0x1624734", Offset = "0x1624734", VA = "0x1624734", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6012782")]
	[Address(RVA = "0x16247B0", Offset = "0x16247B0", VA = "0x16247B0")]
	private void OnPlayerVoiceStateChange(object[] data)
	{
	}

	[Token(Token = "0x6012783")]
	[Address(RVA = "0x16249E0", Offset = "0x16249E0", VA = "0x16249E0")]
	private void OnLocalPlayerVoiceStateChange(object[] data)
	{
	}

	[Token(Token = "0x6012784")]
	[Address(RVA = "0x1621A4C", Offset = "0x1621A4C", VA = "0x1621A4C")]
	private void InitReward()
	{
	}

	[Token(Token = "0x6012785")]
	[Address(RVA = "0x1624FCC", Offset = "0x1624FCC", VA = "0x1624FCC", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012786")]
	[Address(RVA = "0x1625060", Offset = "0x1625060", VA = "0x1625060", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012787")]
	[Address(RVA = "0x1624B90", Offset = "0x1624B90", VA = "0x1624B90")]
	private void ShowReward(MatchIncome income)
	{
	}

	[Token(Token = "0x6012788")]
	[Address(RVA = "0x162522C", Offset = "0x162522C", VA = "0x162522C")]
	private static void _003CQuitGame_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6012789")]
	[Address(RVA = "0x1625230", Offset = "0x1625230", VA = "0x1625230")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601278A")]
	[Address(RVA = "0x1625238", Offset = "0x1625238", VA = "0x1625238")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601278B")]
	[Address(RVA = "0x1625240", Offset = "0x1625240", VA = "0x1625240")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601278C")]
	[Address(RVA = "0x1625248", Offset = "0x1625248", VA = "0x1625248")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}
}
