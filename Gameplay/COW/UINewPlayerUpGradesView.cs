using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C5")]
public class UINewPlayerUpGradesView : UIBaseView
{
	[Token(Token = "0x4017858")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnNewPlayerUpCharacter;

	[Token(Token = "0x4017859")]
	[FieldOffset(Offset = "0x18")]
	public UISprite characterlock;

	[Token(Token = "0x401785A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel characterLevelText;

	[Token(Token = "0x401785B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite characterSprite;

	[Token(Token = "0x401785C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel characterLabel;

	[Token(Token = "0x401785D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnMatchGame;

	[Token(Token = "0x401785E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite gamelock;

	[Token(Token = "0x401785F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel gameLevelText;

	[Token(Token = "0x4017860")]
	[FieldOffset(Offset = "0x34")]
	public UISprite gameSprite;

	[Token(Token = "0x4017861")]
	[FieldOffset(Offset = "0x38")]
	public UILabel gameLabel;

	[Token(Token = "0x4017862")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnTrainingCamp;

	[Token(Token = "0x4017863")]
	[FieldOffset(Offset = "0x40")]
	public UILabel trainingCampLabel;

	[Token(Token = "0x6016DFA")]
	[Address(RVA = "0x27B0CBC", Offset = "0x27B0CBC", VA = "0x27B0CBC")]
	public UINewPlayerUpGradesView()
	{
	}

	[Token(Token = "0x6016DFB")]
	[Address(RVA = "0x27B0CC4", Offset = "0x27B0CC4", VA = "0x27B0CC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DFC")]
	[Address(RVA = "0x27B128C", Offset = "0x27B128C", VA = "0x27B128C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
