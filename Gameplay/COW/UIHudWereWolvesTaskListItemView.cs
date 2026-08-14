using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D9")]
public class UIHudWereWolvesTaskListItemView : UIBaseView
{
	[Token(Token = "0x4016A58")]
	[FieldOffset(Offset = "0x14")]
	public UILabel NameLabel;

	[Token(Token = "0x4016A59")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TaskUnComplete;

	[Token(Token = "0x4016A5A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel StateLabel;

	[Token(Token = "0x4016A5B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TaskComplete;

	[Token(Token = "0x4016A5C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject AlertBG;

	[Token(Token = "0x6016B36")]
	[Address(RVA = "0x257111C", Offset = "0x257111C", VA = "0x257111C")]
	public UIHudWereWolvesTaskListItemView()
	{
	}

	[Token(Token = "0x6016B37")]
	[Address(RVA = "0x2571124", Offset = "0x2571124", VA = "0x2571124", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B38")]
	[Address(RVA = "0x2571434", Offset = "0x2571434", VA = "0x2571434")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
