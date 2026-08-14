using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037FF")]
public class UIIntegrationTestCaseView : UIBaseView
{
	[Token(Token = "0x4016BFA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Test;

	[Token(Token = "0x4016BFB")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList TestEasyList;

	[Token(Token = "0x4016BFC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TestClose;

	[Token(Token = "0x4016BFD")]
	[FieldOffset(Offset = "0x20")]
	public UIButton TestStart;

	[Token(Token = "0x4016BFE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TestTitle;

	[Token(Token = "0x4016BFF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TestKeyTemplate;

	[Token(Token = "0x6016BA8")]
	[Address(RVA = "0x1281A3C", Offset = "0x1281A3C", VA = "0x1281A3C")]
	public UIIntegrationTestCaseView()
	{
	}

	[Token(Token = "0x6016BA9")]
	[Address(RVA = "0x1281A44", Offset = "0x1281A44", VA = "0x1281A44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BAA")]
	[Address(RVA = "0x1281DB4", Offset = "0x1281DB4", VA = "0x1281DB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
