using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003723")]
public class UIHudSceneEditActionView : UIBaseView
{
	[Token(Token = "0x40164A1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ActionBtn;

	[Token(Token = "0x40164A2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Highlight;

	[Token(Token = "0x40164A3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x40164A4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Name;

	[Token(Token = "0x40164A5")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Cost;

	[Token(Token = "0x40164A6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DestructibleIcon;

	[Token(Token = "0x40164A7")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton AttributeBtn;

	[Token(Token = "0x40164A8")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DetailBtn;

	[Token(Token = "0x6016914")]
	[Address(RVA = "0x1C52B84", Offset = "0x1C52B84", VA = "0x1C52B84")]
	public UIHudSceneEditActionView()
	{
	}

	[Token(Token = "0x6016915")]
	[Address(RVA = "0x1C52B8C", Offset = "0x1C52B8C", VA = "0x1C52B8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016916")]
	[Address(RVA = "0x1C52FBC", Offset = "0x1C52FBC", VA = "0x1C52FBC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
