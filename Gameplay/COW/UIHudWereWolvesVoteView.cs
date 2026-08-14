using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E5")]
public class UIHudWereWolvesVoteView : UIBaseView
{
	[Token(Token = "0x4016AA0")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4016AA1")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList ContentList;

	[Token(Token = "0x4016AA2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnVote;

	[Token(Token = "0x4016AA3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnSkip;

	[Token(Token = "0x4016AA4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CountDownLabel;

	[Token(Token = "0x4016AA5")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnMap;

	[Token(Token = "0x4016AA6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MapHint;

	[Token(Token = "0x4016AA7")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget BtnMapTutorialWidget;

	[Token(Token = "0x4016AA8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TitleLabel;

	[Token(Token = "0x4016AA9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel DescLabel;

	[Token(Token = "0x4016AAA")]
	[FieldOffset(Offset = "0x3C")]
	public UIProgressBar CountDownProgress;

	[Token(Token = "0x4016AAB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SponsorNode;

	[Token(Token = "0x4016AAC")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnSpeaker;

	[Token(Token = "0x4016AAD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SpeakerOn;

	[Token(Token = "0x4016AAE")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SpeakerOff;

	[Token(Token = "0x4016AAF")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget MicTutorialWiget;

	[Token(Token = "0x4016AB0")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SkipVoteNode;

	[Token(Token = "0x4016AB1")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid SkipNodeGrid;

	[Token(Token = "0x4016AB2")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject QuickChatNode;

	[Token(Token = "0x4016AB3")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SpeakerNode;

	[Token(Token = "0x4016AB4")]
	[FieldOffset(Offset = "0x64")]
	public UIToggleButton ChatTab;

	[Token(Token = "0x4016AB5")]
	[FieldOffset(Offset = "0x68")]
	public UIToggleButton HistroyTab;

	[Token(Token = "0x4016AB6")]
	[FieldOffset(Offset = "0x6C")]
	public UIScrollView ChatScrollView;

	[Token(Token = "0x4016AB7")]
	[FieldOffset(Offset = "0x70")]
	public UIEasyList ChatEasyList;

	[Token(Token = "0x4016AB8")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnMic;

	[Token(Token = "0x4016AB9")]
	[FieldOffset(Offset = "0x78")]
	public GameObject MicOn;

	[Token(Token = "0x4016ABA")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject MicOff;

	[Token(Token = "0x4016ABB")]
	[FieldOffset(Offset = "0x80")]
	public GameObject MicBan;

	[Token(Token = "0x4016ABC")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ChatNode;

	[Token(Token = "0x4016ABD")]
	[FieldOffset(Offset = "0x88")]
	public UIInput ChatInput;

	[Token(Token = "0x4016ABE")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton BtnSendChat;

	[Token(Token = "0x4016ABF")]
	[FieldOffset(Offset = "0x90")]
	public UIButton BtnQuickChat;

	[Token(Token = "0x4016AC0")]
	[FieldOffset(Offset = "0x94")]
	public GameObject DisChatNode;

	[Token(Token = "0x4016AC1")]
	[FieldOffset(Offset = "0x98")]
	public GameObject HistroyRoot;

	[Token(Token = "0x4016AC2")]
	[FieldOffset(Offset = "0x9C")]
	public UIScrollView HistroyScorllView;

	[Token(Token = "0x4016AC3")]
	[FieldOffset(Offset = "0xA0")]
	public UIEasyList HistroyEasyList;

	[Token(Token = "0x4016AC4")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject EmptyHistroyRoot;

	[Token(Token = "0x4016AC5")]
	[FieldOffset(Offset = "0xA8")]
	public UIToggleButton TabHistroyOne;

	[Token(Token = "0x4016AC6")]
	[FieldOffset(Offset = "0xAC")]
	public UIToggleButton TabHistroyTwo;

	[Token(Token = "0x4016AC7")]
	[FieldOffset(Offset = "0xB0")]
	public UIToggleButton TabHistroyThree;

	[Token(Token = "0x4016AC8")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject NoOneVoteRoot;

	[Token(Token = "0x4016AC9")]
	[FieldOffset(Offset = "0xB8")]
	public UIWidget ChatTutorialWiget;

	[Token(Token = "0x4016ACA")]
	[FieldOffset(Offset = "0xBC")]
	public UIWidget VoteAndSkipTutorialWiget;

	[Token(Token = "0x4016ACB")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget TitleTutorialWidget;

	[Token(Token = "0x6016B5A")]
	[Address(RVA = "0x293F7A8", Offset = "0x293F7A8", VA = "0x293F7A8")]
	public UIHudWereWolvesVoteView()
	{
	}

	[Token(Token = "0x6016B5B")]
	[Address(RVA = "0x293F7B0", Offset = "0x293F7B0", VA = "0x293F7B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B5C")]
	[Address(RVA = "0x29408C4", Offset = "0x29408C4", VA = "0x29408C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
