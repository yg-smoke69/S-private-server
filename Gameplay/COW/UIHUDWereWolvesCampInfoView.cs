using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037CC")]
public class UIHUDWereWolvesCampInfoView : UIBaseView
{
	[Token(Token = "0x40169E9")]
	[FieldOffset(Offset = "0x14")]
	public UIProgressBar LeftTimeProgress;

	[Token(Token = "0x40169EA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite barFore;

	[Token(Token = "0x40169EB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject WolfRoot;

	[Token(Token = "0x40169EC")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SkillIconSprite;

	[Token(Token = "0x40169ED")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid IconGrid;

	[Token(Token = "0x40169EE")]
	[FieldOffset(Offset = "0x28")]
	public UIHUDWereWolvesCampWolfItem WolfIconTemplate;

	[Token(Token = "0x40169EF")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HumanRoot;

	[Token(Token = "0x40169F0")]
	[FieldOffset(Offset = "0x30")]
	public UILabel HumanTitleLabel;

	[Token(Token = "0x40169F1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PredictToolRoot;

	[Token(Token = "0x40169F2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LeftTimeLabel;

	[Token(Token = "0x6016B0F")]
	[Address(RVA = "0x2935FBC", Offset = "0x2935FBC", VA = "0x2935FBC")]
	public UIHUDWereWolvesCampInfoView()
	{
	}

	[Token(Token = "0x6016B10")]
	[Address(RVA = "0x2935FC4", Offset = "0x2935FC4", VA = "0x2935FC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B11")]
	[Address(RVA = "0x29364A8", Offset = "0x29364A8", VA = "0x29364A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
