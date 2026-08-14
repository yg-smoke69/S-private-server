using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034ED")]
public class UIDispatchCharacterItemView : UIBaseView
{
	[Token(Token = "0x4014CDD")]
	[FieldOffset(Offset = "0x14")]
	public Animation ContentContainer;

	[Token(Token = "0x4014CDE")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha ContentContainerAlpha;

	[Token(Token = "0x4014CDF")]
	[FieldOffset(Offset = "0x1C")]
	public TweenScale ContentContainerScale;

	[Token(Token = "0x4014CE0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton AvatarBtn;

	[Token(Token = "0x4014CE1")]
	[FieldOffset(Offset = "0x24")]
	public UISprite AvatarImage;

	[Token(Token = "0x4014CE2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Selected;

	[Token(Token = "0x4014CE3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Order;

	[Token(Token = "0x4014CE4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Dispatched;

	[Token(Token = "0x4014CE5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Name;

	[Token(Token = "0x4014CE6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Clickvfx;

	[Token(Token = "0x4014CE7")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Commonvfx;

	[Token(Token = "0x6016277")]
	[Address(RVA = "0x275D9AC", Offset = "0x275D9AC", VA = "0x275D9AC")]
	public UIDispatchCharacterItemView()
	{
	}

	[Token(Token = "0x6016278")]
	[Address(RVA = "0x275D9B4", Offset = "0x275D9B4", VA = "0x275D9B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016279")]
	[Address(RVA = "0x275DDD8", Offset = "0x275DDD8", VA = "0x275DDD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
