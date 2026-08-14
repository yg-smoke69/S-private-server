using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E3")]
public class UIHudWereWolvesVoteSpeakerItemView : UIBaseView
{
	[Token(Token = "0x4016A94")]
	[FieldOffset(Offset = "0x14")]
	public UISprite CountBG;

	[Token(Token = "0x4016A95")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountLabel;

	[Token(Token = "0x4016A96")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnSpeaker;

	[Token(Token = "0x4016A97")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpeakerOn;

	[Token(Token = "0x4016A98")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SpeakerOff;

	[Token(Token = "0x4016A99")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameLabel;

	[Token(Token = "0x6016B54")]
	[Address(RVA = "0x293F0A8", Offset = "0x293F0A8", VA = "0x293F0A8")]
	public UIHudWereWolvesVoteSpeakerItemView()
	{
	}

	[Token(Token = "0x6016B55")]
	[Address(RVA = "0x293F0B0", Offset = "0x293F0B0", VA = "0x293F0B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B56")]
	[Address(RVA = "0x293F420", Offset = "0x293F420", VA = "0x293F420")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
