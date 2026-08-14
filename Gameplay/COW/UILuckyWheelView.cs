using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003863")]
public class UILuckyWheelView : UIBaseView
{
	[Token(Token = "0x4017226")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TimeBtn;

	[Token(Token = "0x4017227")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TimeLabel;

	[Token(Token = "0x4017228")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Title;

	[Token(Token = "0x4017229")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture TitileCDN;

	[Token(Token = "0x401722A")]
	[FieldOffset(Offset = "0x24")]
	public Transform DrawContainer;

	[Token(Token = "0x401722B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DrawHintVfx;

	[Token(Token = "0x401722C")]
	[FieldOffset(Offset = "0x2C")]
	public Transform Reward0;

	[Token(Token = "0x401722D")]
	[FieldOffset(Offset = "0x30")]
	public Transform Reward1;

	[Token(Token = "0x401722E")]
	[FieldOffset(Offset = "0x34")]
	public Transform Reward2;

	[Token(Token = "0x401722F")]
	[FieldOffset(Offset = "0x38")]
	public Transform Reward3;

	[Token(Token = "0x4017230")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Reward4;

	[Token(Token = "0x4017231")]
	[FieldOffset(Offset = "0x40")]
	public Transform Reward5;

	[Token(Token = "0x4017232")]
	[FieldOffset(Offset = "0x44")]
	public Transform Reward6;

	[Token(Token = "0x4017233")]
	[FieldOffset(Offset = "0x48")]
	public Transform Reward7;

	[Token(Token = "0x4017234")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ResetCircleVfx;

	[Token(Token = "0x4017235")]
	[FieldOffset(Offset = "0x50")]
	public GameObject glow01;

	[Token(Token = "0x4017236")]
	[FieldOffset(Offset = "0x54")]
	public GameObject glow02;

	[Token(Token = "0x4017237")]
	[FieldOffset(Offset = "0x58")]
	public GameObject glow03;

	[Token(Token = "0x4017238")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject glow04;

	[Token(Token = "0x4017239")]
	[FieldOffset(Offset = "0x60")]
	public GameObject glow05;

	[Token(Token = "0x401723A")]
	[FieldOffset(Offset = "0x64")]
	public GameObject glow06;

	[Token(Token = "0x401723B")]
	[FieldOffset(Offset = "0x68")]
	public GameObject glow07;

	[Token(Token = "0x401723C")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject glow08;

	[Token(Token = "0x401723D")]
	[FieldOffset(Offset = "0x70")]
	public UIButton DrawBtn;

	[Token(Token = "0x401723E")]
	[FieldOffset(Offset = "0x74")]
	public Animation DrawBtnAnimation;

	[Token(Token = "0x401723F")]
	[FieldOffset(Offset = "0x78")]
	public UISprite DrawBtnSprite;

	[Token(Token = "0x4017240")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DrawBtnVfx;

	[Token(Token = "0x4017241")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DrawLabel;

	[Token(Token = "0x4017242")]
	[FieldOffset(Offset = "0x84")]
	public GameObject CurrentDiscount;

	[Token(Token = "0x4017243")]
	[FieldOffset(Offset = "0x88")]
	public UILabel CurrentDiscountLabel;

	[Token(Token = "0x4017244")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject CurrentPrice;

	[Token(Token = "0x4017245")]
	[FieldOffset(Offset = "0x90")]
	public UILabel CurrentPriceLabel;

	[Token(Token = "0x4017246")]
	[FieldOffset(Offset = "0x94")]
	public GameObject RewardPoolRefreshVfx;

	[Token(Token = "0x4017247")]
	[FieldOffset(Offset = "0x98")]
	public UIButton RewardPoolBtn;

	[Token(Token = "0x4017248")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton RewardPoolCloseBtn;

	[Token(Token = "0x4017249")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject CanNotRefreshLabel;

	[Token(Token = "0x401724A")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject RewardPoolContainer;

	[Token(Token = "0x401724B")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x401724C")]
	[FieldOffset(Offset = "0xAC")]
	public UIGrid ItemGrid;

	[Token(Token = "0x401724D")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton RefreshRewardPoolBtn;

	[Token(Token = "0x401724E")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel RefreshPriceLabel;

	[Token(Token = "0x401724F")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite RefreshPriceIcon;

	[Token(Token = "0x4017250")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel FreeRefreshLabel;

	[Token(Token = "0x4017251")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel RewardPoolDiscountLabel;

	[Token(Token = "0x4017252")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel OffLabel;

	[Token(Token = "0x4017253")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel OffLabelWidget;

	[Token(Token = "0x4017254")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel RewardPoolPriceLabel;

	[Token(Token = "0x4017255")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject ShowDiscountVfx;

	[Token(Token = "0x4017256")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject RewardPoolPreviewContainer;

	[Token(Token = "0x4017257")]
	[FieldOffset(Offset = "0xD8")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017258")]
	[FieldOffset(Offset = "0xDC")]
	public UIEasyList PreviewItemEasyList;

	[Token(Token = "0x4017259")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject FinishedHintLabel;

	[Token(Token = "0x401725A")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject OwnDiscountVfx;

	[Token(Token = "0x401725B")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject DrawResultVfx;

	[Token(Token = "0x401725C")]
	[FieldOffset(Offset = "0xEC")]
	public UINetworkTexture BGCDN;

	[Token(Token = "0x401725D")]
	[FieldOffset(Offset = "0xF0")]
	public UIButton InterfaceMask;

	[Token(Token = "0x6016CD4")]
	[Address(RVA = "0x18CF6F8", Offset = "0x18CF6F8", VA = "0x18CF6F8")]
	public UILuckyWheelView()
	{
	}

	[Token(Token = "0x6016CD5")]
	[Address(RVA = "0x18CF700", Offset = "0x18CF700", VA = "0x18CF700", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CD6")]
	[Address(RVA = "0x18D0AD8", Offset = "0x18D0AD8", VA = "0x18D0AD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
