using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003943")]
public class UIRankGuideView : UIBaseView
{
	[Token(Token = "0x4017F66")]
	[FieldOffset(Offset = "0x14")]
	public UILabel GuideText;

	[Token(Token = "0x4017F67")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Guide_MapBtn_Anim;

	[Token(Token = "0x4017F68")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Guide_MapBtn_Anim_In;

	[Token(Token = "0x4017F69")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Guide_Unlock_Anim;

	[Token(Token = "0x4017F6A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Guide_MapBtn_Anim_Small;

	[Token(Token = "0x6016F70")]
	[Address(RVA = "0x1AC8F2C", Offset = "0x1AC8F2C", VA = "0x1AC8F2C")]
	public UIRankGuideView()
	{
	}

	[Token(Token = "0x6016F71")]
	[Address(RVA = "0x1AC8F34", Offset = "0x1AC8F34", VA = "0x1AC8F34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F72")]
	[Address(RVA = "0x1AC922C", Offset = "0x1AC922C", VA = "0x1AC922C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
