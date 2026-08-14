using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003930")]
public class UIProfileTagView : UIBaseView
{
	[Token(Token = "0x4017DEC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIProfileTag;

	[Token(Token = "0x4017DED")]
	[FieldOffset(Offset = "0x18")]
	public Animation TagAnim;

	[Token(Token = "0x4017DEE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tag;

	[Token(Token = "0x4017DEF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LevelBg;

	[Token(Token = "0x4017DF0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Lock;

	[Token(Token = "0x4017DF1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Selected;

	[Token(Token = "0x4017DF2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ConditionNum;

	[Token(Token = "0x4017DF3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Equiped;

	[Token(Token = "0x6016F37")]
	[Address(RVA = "0x1AB8900", Offset = "0x1AB8900", VA = "0x1AB8900")]
	public UIProfileTagView()
	{
	}

	[Token(Token = "0x6016F38")]
	[Address(RVA = "0x1AB8908", Offset = "0x1AB8908", VA = "0x1AB8908", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F39")]
	[Address(RVA = "0x1AB8D38", Offset = "0x1AB8D38", VA = "0x1AB8D38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
