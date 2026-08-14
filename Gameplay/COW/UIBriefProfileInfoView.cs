using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003405")]
public class UIBriefProfileInfoView : UIBaseView
{
	[Token(Token = "0x401410F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIBriefProfileInfo;

	[Token(Token = "0x4014110")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x4014111")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject fakebg;

	[Token(Token = "0x4014112")]
	[FieldOffset(Offset = "0x20")]
	public UILabel nickname;

	[Token(Token = "0x4014113")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BtnPinIcon;

	[Token(Token = "0x4014114")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnPin;

	[Token(Token = "0x4014115")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x4014116")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Self;

	[Token(Token = "0x4014117")]
	[FieldOffset(Offset = "0x34")]
	public UIButton Btnclose;

	[Token(Token = "0x4014118")]
	[FieldOffset(Offset = "0x38")]
	public GameObject GameVoiceBtnGroup;

	[Token(Token = "0x4014119")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton MicToggle;

	[Token(Token = "0x401411A")]
	[FieldOffset(Offset = "0x40")]
	public UISprite MicBan;

	[Token(Token = "0x401411B")]
	[FieldOffset(Offset = "0x44")]
	public UISprite MicSprite;

	[Token(Token = "0x401411C")]
	[FieldOffset(Offset = "0x48")]
	public UISprite MicMask;

	[Token(Token = "0x401411D")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton SpeakerToggle;

	[Token(Token = "0x401411E")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SpeakerSprite;

	[Token(Token = "0x401411F")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpeakerMask;

	[Token(Token = "0x6015FC3")]
	[Address(RVA = "0x1447D4C", Offset = "0x1447D4C", VA = "0x1447D4C")]
	public UIBriefProfileInfoView()
	{
	}

	[Token(Token = "0x6015FC4")]
	[Address(RVA = "0x1447D54", Offset = "0x1447D54", VA = "0x1447D54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FC5")]
	[Address(RVA = "0x14484CC", Offset = "0x14484CC", VA = "0x14484CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
