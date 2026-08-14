using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200392F")]
public class UIProfileSmallTagView : UIBaseView
{
	[Token(Token = "0x4017DE2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIProfileSmallTag;

	[Token(Token = "0x4017DE3")]
	[FieldOffset(Offset = "0x18")]
	public Animation TagAnim;

	[Token(Token = "0x4017DE4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tag;

	[Token(Token = "0x4017DE5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LevelBg;

	[Token(Token = "0x4017DE6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Lock;

	[Token(Token = "0x4017DE7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Selected;

	[Token(Token = "0x4017DE8")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ConditionNum;

	[Token(Token = "0x4017DE9")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Equiped;

	[Token(Token = "0x4017DEA")]
	[FieldOffset(Offset = "0x34")]
	public UICustomHoverButton CustomBtn;

	[Token(Token = "0x4017DEB")]
	[FieldOffset(Offset = "0x38")]
	public Transform CustomTr;

	[Token(Token = "0x6016F34")]
	[Address(RVA = "0x1AB4900", Offset = "0x1AB4900", VA = "0x1AB4900")]
	public UIProfileSmallTagView()
	{
	}

	[Token(Token = "0x6016F35")]
	[Address(RVA = "0x1AB4908", Offset = "0x1AB4908", VA = "0x1AB4908", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F36")]
	[Address(RVA = "0x1AB4DD0", Offset = "0x1AB4DD0", VA = "0x1AB4DD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
