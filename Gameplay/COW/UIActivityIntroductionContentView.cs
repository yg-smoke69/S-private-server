using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033AC")]
public class UIActivityIntroductionContentView : UIBaseView
{
	[Token(Token = "0x4013BB6")]
	[FieldOffset(Offset = "0x14")]
	public UITable ContentTable;

	[Token(Token = "0x4013BB7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Introduction;

	[Token(Token = "0x4013BB8")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Operation;

	[Token(Token = "0x4013BB9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject OperateBtnWhite;

	[Token(Token = "0x4013BBA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GoToRedpoint;

	[Token(Token = "0x6015EBA")]
	[Address(RVA = "0x2FB65CC", Offset = "0x2FB65CC", VA = "0x2FB65CC")]
	public UIActivityIntroductionContentView()
	{
	}

	[Token(Token = "0x6015EBB")]
	[Address(RVA = "0x2FB65D4", Offset = "0x2FB65D4", VA = "0x2FB65D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EBC")]
	[Address(RVA = "0x2FB68E4", Offset = "0x2FB68E4", VA = "0x2FB68E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
