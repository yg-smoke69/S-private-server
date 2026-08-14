using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028C7")]
public class UIHudWereWolvesVoteController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FAE0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesVoteView m_View;

	[Token(Token = "0x400FAE1")]
	[FieldOffset(Offset = "0x2C")]
	private List<HDCFACOPKDC> m_VoteList;

	[Token(Token = "0x400FAE2")]
	[FieldOffset(Offset = "0x30")]
	private List<IHAAMHPPLMG> m_SkippedList;

	[Token(Token = "0x400FAE3")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudWereWolvesVoteIndexController> m_SkippedChildController;

	[Token(Token = "0x400FAE4")]
	[FieldOffset(Offset = "0x38")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400FAE5")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CountDownTime;

	[Token(Token = "0x400FAE6")]
	[FieldOffset(Offset = "0x40")]
	private UIHudWereWolvesVoteIndexController m_SponsorIndex;

	[Token(Token = "0x400FAE7")]
	[FieldOffset(Offset = "0x44")]
	private WereWolvesChatEasyListCallBack m_ChatEasyListCallback;

	[Token(Token = "0x400FAE8")]
	[FieldOffset(Offset = "0x48")]
	private WereWolvesHistroyListCallBack m_HistroyEasyListCallback;

	[Token(Token = "0x400FAE9")]
	[FieldOffset(Offset = "0x4C")]
	private UIHudWereWolvesQuickChatScrollController m_QuickChatNode;

	[Token(Token = "0x400FAEA")]
	[FieldOffset(Offset = "0x50")]
	private UIHudWereWolvesSpeakerController m_SpeakerController;

	[Token(Token = "0x400FAEB")]
	[FieldOffset(Offset = "0x54")]
	private uint m_LastQuickPlayerId;

	[Token(Token = "0x400FAEC")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, List<HistroyPlayerInfo>> m_HistroyInfoDic;

	[Token(Token = "0x400FAED")]
	[FieldOffset(Offset = "0x5C")]
	private int m_CurHistroyTab;

	[Token(Token = "0x400FAEE")]
	[FieldOffset(Offset = "0x60")]
	private TutorialEventEnum m_CurVoteTutorialType;

	[Token(Token = "0x400FAEF")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsMapOpen;

	[Token(Token = "0x400FAF0")]
	[FieldOffset(Offset = "0x65")]
	private bool m_IsChatPanleShowing;

	[Token(Token = "0x400FAF1")]
	[FieldOffset(Offset = "0x68")]
	private float lastLeftTimeS;

	[Token(Token = "0x400FAF2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<HistroyPlayerInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60100E4")]
	[Address(RVA = "0x2574504", Offset = "0x2574504", VA = "0x2574504")]
	public UIHudWereWolvesVoteController()
	{
	}

	[Token(Token = "0x60100E5")]
	[Address(RVA = "0x25745FC", Offset = "0x25745FC", VA = "0x25745FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60100E6")]
	[Address(RVA = "0x25746A4", Offset = "0x25746A4", VA = "0x25746A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60100E7")]
	[Address(RVA = "0x2575704", Offset = "0x2575704", VA = "0x2575704", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60100E8")]
	[Address(RVA = "0x2575D80", Offset = "0x2575D80", VA = "0x2575D80", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60100E9")]
	[Address(RVA = "0x25763D0", Offset = "0x25763D0", VA = "0x25763D0")]
	private void RefreshDescription()
	{
	}

	[Token(Token = "0x60100EA")]
	[Address(RVA = "0x257668C", Offset = "0x257668C", VA = "0x257668C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60100EB")]
	[Address(RVA = "0x2576BCC", Offset = "0x2576BCC", VA = "0x2576BCC")]
	private void OnQuickChatItemClick(object[] data)
	{
	}

	[Token(Token = "0x60100EC")]
	[Address(RVA = "0x2576170", Offset = "0x2576170", VA = "0x2576170")]
	private void OnRefreshChatInfo(object[] data)
	{
	}

	[Token(Token = "0x60100ED")]
	[Address(RVA = "0x2576DF0", Offset = "0x2576DF0", VA = "0x2576DF0")]
	private void OnRefreshSponsor(object[] data)
	{
	}

	[Token(Token = "0x60100EE")]
	[Address(RVA = "0x257708C", Offset = "0x257708C", VA = "0x257708C")]
	private void OnVotePlayer()
	{
	}

	[Token(Token = "0x60100EF")]
	[Address(RVA = "0x2577574", Offset = "0x2577574", VA = "0x2577574")]
	private void OnSkipVote()
	{
	}

	[Token(Token = "0x60100F0")]
	[Address(RVA = "0x257679C", Offset = "0x257679C", VA = "0x257679C")]
	public void OnRefreshVoteList(object[] data)
	{
	}

	[Token(Token = "0x60100F1")]
	[Address(RVA = "0x25776F0", Offset = "0x25776F0", VA = "0x25776F0")]
	private void RefreshSkippedList()
	{
	}

	[Token(Token = "0x60100F2")]
	[Address(RVA = "0x2577CF8", Offset = "0x2577CF8", VA = "0x2577CF8")]
	private void RefreshChatNode()
	{
	}

	[Token(Token = "0x60100F3")]
	[Address(RVA = "0x2578064", Offset = "0x2578064", VA = "0x2578064")]
	public void OnNewPhase(object[] param)
	{
	}

	[Token(Token = "0x60100F4")]
	[Address(RVA = "0x257846C", Offset = "0x257846C", VA = "0x257846C")]
	public void OnEndTimeCome(object[] param)
	{
	}

	[Token(Token = "0x60100F5")]
	[Address(RVA = "0x25786E8", Offset = "0x25786E8", VA = "0x25786E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60100F6")]
	[Address(RVA = "0x25789EC", Offset = "0x25789EC", VA = "0x25789EC")]
	private void OnMap()
	{
	}

	[Token(Token = "0x60100F7")]
	[Address(RVA = "0x2578C78", Offset = "0x2578C78", VA = "0x2578C78")]
	private void OnSendChat()
	{
	}

	[Token(Token = "0x60100F8")]
	[Address(RVA = "0x25790D0", Offset = "0x25790D0", VA = "0x25790D0")]
	private void OnQuickChat()
	{
	}

	[Token(Token = "0x60100F9")]
	[Address(RVA = "0x25792F0", Offset = "0x25792F0", VA = "0x25792F0")]
	private void OnMic()
	{
	}

	[Token(Token = "0x60100FA")]
	[Address(RVA = "0x2579590", Offset = "0x2579590", VA = "0x2579590")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x60100FB")]
	[Address(RVA = "0x25795F8", Offset = "0x25795F8", VA = "0x25795F8")]
	private void OnSpeaker()
	{
	}

	[Token(Token = "0x60100FC")]
	[Address(RVA = "0x2575F54", Offset = "0x2575F54", VA = "0x2575F54")]
	private void RefreshVoteButtonState()
	{
	}

	[Token(Token = "0x60100FD")]
	[Address(RVA = "0x2579788", Offset = "0x2579788", VA = "0x2579788")]
	private void OnVoiceChange(object[] data)
	{
	}

	[Token(Token = "0x60100FE")]
	[Address(RVA = "0x256DED0", Offset = "0x256DED0", VA = "0x256DED0")]
	public void RefreshButtonState()
	{
	}

	[Token(Token = "0x60100FF")]
	[Address(RVA = "0x25797F0", Offset = "0x25797F0", VA = "0x25797F0")]
	private int Cmp(HDCFACOPKDC infoA, HDCFACOPKDC infoB)
	{
		return default(int);
	}

	[Token(Token = "0x6010100")]
	[Address(RVA = "0x25798B4", Offset = "0x25798B4", VA = "0x25798B4", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010101")]
	[Address(RVA = "0x25799E4", Offset = "0x25799E4", VA = "0x25799E4", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010102")]
	[Address(RVA = "0x2579A60", Offset = "0x2579A60", VA = "0x2579A60")]
	public UIEasyListItemController GetChildController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010103")]
	[Address(RVA = "0x2579B58", Offset = "0x2579B58", VA = "0x2579B58")]
	public UIEasyListItemController GetHistroyChildController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010104")]
	[Address(RVA = "0x256E690", Offset = "0x256E690", VA = "0x256E690")]
	public void HideSpeakerNode()
	{
	}

	[Token(Token = "0x6010105")]
	[Address(RVA = "0x2579C50", Offset = "0x2579C50", VA = "0x2579C50")]
	private void OnRefreshHistroyInfo(object[] data)
	{
	}

	[Token(Token = "0x6010106")]
	[Address(RVA = "0x257AAA8", Offset = "0x257AAA8", VA = "0x257AAA8")]
	private void OnShowChatPanel()
	{
	}

	[Token(Token = "0x6010107")]
	[Address(RVA = "0x257ABA0", Offset = "0x257ABA0", VA = "0x257ABA0")]
	private void OnShowHistroyPanel()
	{
	}

	[Token(Token = "0x6010108")]
	[Address(RVA = "0x257AD4C", Offset = "0x257AD4C", VA = "0x257AD4C")]
	private void OnShowHistroyOne()
	{
	}

	[Token(Token = "0x6010109")]
	[Address(RVA = "0x257B024", Offset = "0x257B024", VA = "0x257B024")]
	private void OnShowHistroyTwo()
	{
	}

	[Token(Token = "0x601010A")]
	[Address(RVA = "0x257B08C", Offset = "0x257B08C", VA = "0x257B08C")]
	private void OnShowHistroyThree()
	{
	}

	[Token(Token = "0x601010B")]
	[Address(RVA = "0x257ADB4", Offset = "0x257ADB4", VA = "0x257ADB4")]
	private void RefreshHistroyList()
	{
	}

	[Token(Token = "0x601010C")]
	[Address(RVA = "0x257B0F4", Offset = "0x257B0F4", VA = "0x257B0F4")]
	public void OnStartVote()
	{
	}

	[Token(Token = "0x601010D")]
	[Address(RVA = "0x257B38C", Offset = "0x257B38C", VA = "0x257B38C")]
	private void OnOpenMapTutorial(object[] data)
	{
	}

	[Token(Token = "0x601010E")]
	[Address(RVA = "0x257B4D0", Offset = "0x257B4D0", VA = "0x257B4D0")]
	private void OnChatTutorial(object[] data)
	{
	}

	[Token(Token = "0x601010F")]
	[Address(RVA = "0x257B614", Offset = "0x257B614", VA = "0x257B614")]
	private void OnMicTutorial(object[] data)
	{
	}

	[Token(Token = "0x6010110")]
	[Address(RVA = "0x257B758", Offset = "0x257B758", VA = "0x257B758")]
	private void OnQuickChatTutorial(object[] data)
	{
	}

	[Token(Token = "0x6010111")]
	[Address(RVA = "0x257BB24", Offset = "0x257BB24", VA = "0x257BB24")]
	private void OnVoteOrSkipTutorial(object[] data)
	{
	}

	[Token(Token = "0x6010112")]
	[Address(RVA = "0x2576A40", Offset = "0x2576A40", VA = "0x2576A40")]
	private void OnShowContinueTutorial()
	{
	}

	[Token(Token = "0x6010113")]
	[Address(RVA = "0x257BC68", Offset = "0x257BC68", VA = "0x257BC68")]
	private static int _003COnRefreshHistroyInfo_003Em__0(HistroyPlayerInfo a, HistroyPlayerInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6010114")]
	[Address(RVA = "0x257BD38", Offset = "0x257BD38", VA = "0x257BD38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010115")]
	[Address(RVA = "0x257BD40", Offset = "0x257BD40", VA = "0x257BD40")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010116")]
	[Address(RVA = "0x257BD48", Offset = "0x257BD48", VA = "0x257BD48")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010117")]
	[Address(RVA = "0x257BD50", Offset = "0x257BD50", VA = "0x257BD50")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
