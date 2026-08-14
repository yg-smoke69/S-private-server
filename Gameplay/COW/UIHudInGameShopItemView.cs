using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003677")]
public class UIHudInGameShopItemView : UIBaseView
{
	[Token(Token = "0x4015DD9")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton ItemBtn;

	[Token(Token = "0x4015DDA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg02;

	[Token(Token = "0x4015DDB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OneObjectContainer;

	[Token(Token = "0x4015DDC")]
	[FieldOffset(Offset = "0x20")]
	public UISprite itemSprite;

	[Token(Token = "0x4015DDD")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelItemCount;

	[Token(Token = "0x4015DDE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TwoObjectContainer;

	[Token(Token = "0x4015DDF")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite itemSprite1;

	[Token(Token = "0x4015DE0")]
	[FieldOffset(Offset = "0x30")]
	public UISprite itemSprite2;

	[Token(Token = "0x4015DE1")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ItemName;

	[Token(Token = "0x4015DE2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Highlight;

	[Token(Token = "0x4015DE3")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite CoinIcon;

	[Token(Token = "0x4015DE4")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Price;

	[Token(Token = "0x4015DE5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject CD;

	[Token(Token = "0x4015DE6")]
	[FieldOffset(Offset = "0x48")]
	public TweenAlpha CDTweenA;

	[Token(Token = "0x4015DE7")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelCD;

	[Token(Token = "0x4015DE8")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GrayMask;

	[Token(Token = "0x4015DE9")]
	[FieldOffset(Offset = "0x54")]
	public TweenAlpha GrayMaskTweenA;

	[Token(Token = "0x4015DEA")]
	[FieldOffset(Offset = "0x58")]
	public UILabel Limitation;

	[Token(Token = "0x4015DEB")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel SoldOut;

	[Token(Token = "0x4015DEC")]
	[FieldOffset(Offset = "0x60")]
	public UISprite qualityBg;

	[Token(Token = "0x4015DED")]
	[FieldOffset(Offset = "0x64")]
	public UISprite bonus;

	[Token(Token = "0x4015DEE")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CSMysteryBoxVFX;

	[Token(Token = "0x4015DEF")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite TagNew;

	[Token(Token = "0x4015DF0")]
	[FieldOffset(Offset = "0x70")]
	public UILabel LabelLimitNum;

	[Token(Token = "0x4015DF1")]
	[FieldOffset(Offset = "0x74")]
	public UILabel LabelStackNum;

	[Token(Token = "0x4015DF2")]
	[FieldOffset(Offset = "0x78")]
	public UIButton OthersChoosingMask;

	[Token(Token = "0x4015DF3")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton InfoBtn;

	[Token(Token = "0x4015DF4")]
	[FieldOffset(Offset = "0x80")]
	public UILabel InfoLabel;

	[Token(Token = "0x4015DF5")]
	[FieldOffset(Offset = "0x84")]
	public GameObject UIHudInGameShopItem;

	[Token(Token = "0x4015DF6")]
	[FieldOffset(Offset = "0x88")]
	public GameObject stateicon;

	[Token(Token = "0x4015DF7")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject ReplacerTip;

	[Token(Token = "0x4015DF8")]
	[FieldOffset(Offset = "0x90")]
	public UILabel ReplacerMaxTip;

	[Token(Token = "0x4015DF9")]
	[FieldOffset(Offset = "0x94")]
	public GameObject ReplacerEffectRoot;

	[Token(Token = "0x4015DFA")]
	[FieldOffset(Offset = "0x98")]
	public GameObject ReplacerNormallEffect;

	[Token(Token = "0x4015DFB")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject ReplacerMaxEffect;

	[Token(Token = "0x6016712")]
	[Address(RVA = "0x22A3350", Offset = "0x22A3350", VA = "0x22A3350")]
	public UIHudInGameShopItemView()
	{
	}

	[Token(Token = "0x6016713")]
	[Address(RVA = "0x22A3358", Offset = "0x22A3358", VA = "0x22A3358", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016714")]
	[Address(RVA = "0x22A4130", Offset = "0x22A4130", VA = "0x22A4130")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
