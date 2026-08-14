using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037DF")]
public class UIHudWereWolvesVoiceEngineView : UIBaseView
{
	[Token(Token = "0x4016A6F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnMic;

	[Token(Token = "0x4016A70")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MicOn;

	[Token(Token = "0x4016A71")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MicOff;

	[Token(Token = "0x4016A72")]
	[FieldOffset(Offset = "0x20")]
	public UISprite MicBan;

	[Token(Token = "0x4016A73")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnSpeaker;

	[Token(Token = "0x4016A74")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SpeakerOn;

	[Token(Token = "0x4016A75")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SpeakerOff;

	[Token(Token = "0x6016B48")]
	[Address(RVA = "0x257413C", Offset = "0x257413C", VA = "0x257413C")]
	public UIHudWereWolvesVoiceEngineView()
	{
	}

	[Token(Token = "0x6016B49")]
	[Address(RVA = "0x2574144", Offset = "0x2574144", VA = "0x2574144", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B4A")]
	[Address(RVA = "0x25744FC", Offset = "0x25744FC", VA = "0x25744FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
