using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037FE")]
public class UIIntegerateRewardPoolTabItemView : UIBaseView
{
	[Token(Token = "0x4016BF4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TabBtn;

	[Token(Token = "0x4016BF5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpriteLock;

	[Token(Token = "0x4016BF6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Selected;

	[Token(Token = "0x4016BF7")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Sprite;

	[Token(Token = "0x4016BF8")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Sprite_inter;

	[Token(Token = "0x4016BF9")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PoolName;

	[Token(Token = "0x6016BA5")]
	[Address(RVA = "0x1281784", Offset = "0x1281784", VA = "0x1281784")]
	public UIIntegerateRewardPoolTabItemView()
	{
	}

	[Token(Token = "0x6016BA6")]
	[Address(RVA = "0x128178C", Offset = "0x128178C", VA = "0x128178C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BA7")]
	[Address(RVA = "0x1281A34", Offset = "0x1281A34", VA = "0x1281A34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
