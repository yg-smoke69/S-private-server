using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D1")]
public class UIHudWereWolvesInfoView : UIBaseView
{
	[Token(Token = "0x4016A24")]
	[FieldOffset(Offset = "0x14")]
	public UIProgressBar Progress;

	[Token(Token = "0x4016A25")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TutorialEffect;

	[Token(Token = "0x4016A26")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4016A27")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TimerLabel;

	[Token(Token = "0x4016A28")]
	[FieldOffset(Offset = "0x24")]
	public GameObject AlertNode;

	[Token(Token = "0x4016A29")]
	[FieldOffset(Offset = "0x28")]
	public UILabel AlertCountDownLabel;

	[Token(Token = "0x4016A2A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel AlertInfoLabel;

	[Token(Token = "0x4016A2B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WinAlertInfo;

	[Token(Token = "0x4016A2C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject FinalCompleteTaskRoot;

	[Token(Token = "0x4016A2D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel FinalCompleteTaskLabel;

	[Token(Token = "0x6016B1E")]
	[Address(RVA = "0x2569518", Offset = "0x2569518", VA = "0x2569518")]
	public UIHudWereWolvesInfoView()
	{
	}

	[Token(Token = "0x6016B1F")]
	[Address(RVA = "0x2569520", Offset = "0x2569520", VA = "0x2569520", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B20")]
	[Address(RVA = "0x25699F8", Offset = "0x25699F8", VA = "0x25699F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
