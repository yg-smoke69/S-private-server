using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200389C")]
public class UIMatchResultZombieScreenshotSelfItemView : UIBaseView
{
	[Token(Token = "0x4017665")]
	[FieldOffset(Offset = "0x14")]
	public GameObject baseProfile;

	[Token(Token = "0x4017666")]
	[FieldOffset(Offset = "0x18")]
	public GameObject briefProfile;

	[Token(Token = "0x4017667")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite WeaponIcon;

	[Token(Token = "0x4017668")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Kills;

	[Token(Token = "0x4017669")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Damages;

	[Token(Token = "0x401766A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SurvivedTime;

	[Token(Token = "0x401766B")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite NormalBG;

	[Token(Token = "0x401766C")]
	[FieldOffset(Offset = "0x30")]
	public UISprite FirstBG;

	[Token(Token = "0x401766D")]
	[FieldOffset(Offset = "0x34")]
	public GameObject MVPIcon;

	[Token(Token = "0x6016D7F")]
	[Address(RVA = "0x268FE14", Offset = "0x268FE14", VA = "0x268FE14")]
	public UIMatchResultZombieScreenshotSelfItemView()
	{
	}

	[Token(Token = "0x6016D80")]
	[Address(RVA = "0x268FE1C", Offset = "0x268FE1C", VA = "0x268FE1C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D81")]
	[Address(RVA = "0x26902A0", Offset = "0x26902A0", VA = "0x26902A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
