using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E4")]
public class UIHudWereWolvesVoteSpeakerView : UIBaseView
{
	[Token(Token = "0x4016A9A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSpeaker;

	[Token(Token = "0x4016A9B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpeakerOn;

	[Token(Token = "0x4016A9C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SpeakerOff;

	[Token(Token = "0x4016A9D")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4016A9E")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList ContentList;

	[Token(Token = "0x4016A9F")]
	[FieldOffset(Offset = "0x28")]
	public UIButton bgmask;

	[Token(Token = "0x6016B57")]
	[Address(RVA = "0x293F428", Offset = "0x293F428", VA = "0x293F428")]
	public UIHudWereWolvesVoteSpeakerView()
	{
	}

	[Token(Token = "0x6016B58")]
	[Address(RVA = "0x293F430", Offset = "0x293F430", VA = "0x293F430", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B59")]
	[Address(RVA = "0x293F7A0", Offset = "0x293F7A0", VA = "0x293F7A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
