using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003473")]
public class UICollectionVehicleSkinScoreItemView : UIBaseView
{
	[Token(Token = "0x4014687")]
	[FieldOffset(Offset = "0x14")]
	public UILabel scoreName;

	[Token(Token = "0x4014688")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha alphaName;

	[Token(Token = "0x4014689")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject up;

	[Token(Token = "0x401468A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite up1;

	[Token(Token = "0x401468B")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha alphaUp1;

	[Token(Token = "0x401468C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite up2;

	[Token(Token = "0x401468D")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha alphaUp2;

	[Token(Token = "0x401468E")]
	[FieldOffset(Offset = "0x30")]
	public UISprite up3;

	[Token(Token = "0x401468F")]
	[FieldOffset(Offset = "0x34")]
	public TweenAlpha alphaUp3;

	[Token(Token = "0x4014690")]
	[FieldOffset(Offset = "0x38")]
	public GameObject down;

	[Token(Token = "0x4014691")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite down3;

	[Token(Token = "0x4014692")]
	[FieldOffset(Offset = "0x40")]
	public TweenAlpha alphaDown3;

	[Token(Token = "0x4014693")]
	[FieldOffset(Offset = "0x44")]
	public UISprite down2;

	[Token(Token = "0x4014694")]
	[FieldOffset(Offset = "0x48")]
	public TweenAlpha alphaDown2;

	[Token(Token = "0x4014695")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite down1;

	[Token(Token = "0x4014696")]
	[FieldOffset(Offset = "0x50")]
	public TweenAlpha alphaDown1;

	[Token(Token = "0x601610D")]
	[Address(RVA = "0x2CDA110", Offset = "0x2CDA110", VA = "0x2CDA110")]
	public UICollectionVehicleSkinScoreItemView()
	{
	}

	[Token(Token = "0x601610E")]
	[Address(RVA = "0x2CDA118", Offset = "0x2CDA118", VA = "0x2CDA118", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601610F")]
	[Address(RVA = "0x2CDA848", Offset = "0x2CDA848", VA = "0x2CDA848")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
