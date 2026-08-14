using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021EF")]
public class UIMallItemBaseController : UIEasyListItemController
{
	[Token(Token = "0x400D44C")]
	[FieldOffset(Offset = "0x38")]
	protected CSSharedItemData m_ItemData;

	[Token(Token = "0x400D44D")]
	[FieldOffset(Offset = "0x3C")]
	protected UIModelMall m_ModelMall;

	[Token(Token = "0x400D44E")]
	[FieldOffset(Offset = "0x40")]
	protected UIModelGift m_ModelGift;

	[Token(Token = "0x400D44F")]
	[FieldOffset(Offset = "0x44")]
	protected UIModelRankingItem m_ModelRankingItem;

	[Token(Token = "0x400D450")]
	[FieldOffset(Offset = "0x48")]
	protected UIModelLadderMatch m_LadderModel;

	[Token(Token = "0x400D451")]
	[FieldOffset(Offset = "0x4C")]
	protected CSSharedItemData m_EffectedItemData;

	[Token(Token = "0x400D452")]
	[FieldOffset(Offset = "0x50")]
	protected UIMallDetailBaseController m_ParentController;

	[Token(Token = "0x400D453")]
	[FieldOffset(Offset = "0x54")]
	protected UIMallController m_MallController;

	[Token(Token = "0x400D454")]
	[FieldOffset(Offset = "0x58")]
	protected FullScreenAnimParams m_AnimParams;

	[Token(Token = "0x400D455")]
	[FieldOffset(Offset = "0x5C")]
	protected bool m_IsUniqueAndOwned;

	[Token(Token = "0x400D456")]
	[FieldOffset(Offset = "0x5D")]
	protected bool m_HavePurchaseTimes;

	[Token(Token = "0x400D457")]
	[FieldOffset(Offset = "0x60")]
	protected uint m_ItemIconGrey;

	[Token(Token = "0x400D458")]
	[FieldOffset(Offset = "0x64")]
	protected uint m_ItemIconWhite;

	[Token(Token = "0x400D459")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_NeedClearCache;

	[Token(Token = "0x400D45A")]
	[FieldOffset(Offset = "0x69")]
	protected bool m_IsItemABReady;

	[Token(Token = "0x400D45B")]
	[FieldOffset(Offset = "0x6A")]
	protected bool m_ShowInstallmentInfo;

	[Token(Token = "0x400D45C")]
	[FieldOffset(Offset = "0x6C")]
	protected ShowBoostAvatarParams m_ShowBoostAvatarParams;

	[Token(Token = "0x400D45D")]
	[FieldOffset(Offset = "0x70")]
	protected UIButton ItemBtn;

	[Token(Token = "0x400D45E")]
	[FieldOffset(Offset = "0x74")]
	protected UIWidget ItemWidget;

	[Token(Token = "0x400D45F")]
	[FieldOffset(Offset = "0x78")]
	protected GameObject NormalContainer;

	[Token(Token = "0x400D460")]
	[FieldOffset(Offset = "0x7C")]
	protected BaseItemView2 BaseInfoView;

	[Token(Token = "0x400D461")]
	[FieldOffset(Offset = "0x80")]
	protected GameObject HighLightBG;

	[Token(Token = "0x400D462")]
	[FieldOffset(Offset = "0x84")]
	protected UISprite BG;

	[Token(Token = "0x400D463")]
	[FieldOffset(Offset = "0x88")]
	protected UISprite BGQualityLine;

	[Token(Token = "0x400D464")]
	[FieldOffset(Offset = "0x8C")]
	protected UISprite SpriteQualityPlus;

	[Token(Token = "0x400D465")]
	[FieldOffset(Offset = "0x90")]
	protected UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x400D466")]
	[FieldOffset(Offset = "0x94")]
	protected GameObject BG_grey;

	[Token(Token = "0x400D467")]
	[FieldOffset(Offset = "0x98")]
	protected GameObject LimitedTitle;

	[Token(Token = "0x400D468")]
	[FieldOffset(Offset = "0x9C")]
	protected GameObject PreviewFemale;

	[Token(Token = "0x400D469")]
	[FieldOffset(Offset = "0xA0")]
	protected GameObject PreviewMale;

	[Token(Token = "0x400D46A")]
	[FieldOffset(Offset = "0xA4")]
	protected UISprite Descargar;

	[Token(Token = "0x400D46B")]
	[FieldOffset(Offset = "0xA8")]
	protected Transform GoldContainer;

	[Token(Token = "0x400D46C")]
	[FieldOffset(Offset = "0xAC")]
	protected UILabel GoldPriceLabel;

	[Token(Token = "0x400D46D")]
	[FieldOffset(Offset = "0xB0")]
	protected Transform DiamondContainer;

	[Token(Token = "0x400D46E")]
	[FieldOffset(Offset = "0xB4")]
	protected UILabel DiamondPriceLabel;

	[Token(Token = "0x400D46F")]
	[FieldOffset(Offset = "0xB8")]
	protected Transform ExchangeContainer;

	[Token(Token = "0x400D470")]
	[FieldOffset(Offset = "0xBC")]
	protected UILabel ExchangePriceLabel;

	[Token(Token = "0x400D471")]
	[FieldOffset(Offset = "0xC0")]
	protected UISprite ExchangeIcon;

	[Token(Token = "0x400D472")]
	[FieldOffset(Offset = "0xC4")]
	protected GameObject UniquedTitle;

	[Token(Token = "0x400D473")]
	[FieldOffset(Offset = "0xC8")]
	protected GameObject OtherChannelContainer;

	[Token(Token = "0x400D474")]
	[FieldOffset(Offset = "0xCC")]
	protected UILabel DiscountTag;

	[Token(Token = "0x400D475")]
	[FieldOffset(Offset = "0xD0")]
	protected GameObject NewTag;

	[Token(Token = "0x400D476")]
	[FieldOffset(Offset = "0xD4")]
	protected GameObject HotTag;

	[Token(Token = "0x400D477")]
	[FieldOffset(Offset = "0xD8")]
	protected GameObject LimitTag;

	[Token(Token = "0x400D478")]
	[FieldOffset(Offset = "0xDC")]
	protected GameObject LimitCountTag;

	[Token(Token = "0x400D479")]
	[FieldOffset(Offset = "0xE0")]
	protected GameObject EarlyAccess;

	[Token(Token = "0x400D47A")]
	[FieldOffset(Offset = "0xE4")]
	protected UISprite RankIcon;

	[Token(Token = "0x400D47B")]
	[FieldOffset(Offset = "0xE8")]
	protected GameObject DefaultContainer;

	[Token(Token = "0x400D47C")]
	[FieldOffset(Offset = "0xEC")]
	protected UILabel ClanLevelTitle;

	[Token(Token = "0x400D47D")]
	[FieldOffset(Offset = "0xF0")]
	protected Transform ClanDiamondContainer;

	[Token(Token = "0x400D47E")]
	[FieldOffset(Offset = "0xF4")]
	protected UILabel ClanDiamondPriceLabel;

	[Token(Token = "0x400D47F")]
	[FieldOffset(Offset = "0xF8")]
	protected GameObject OverDueTitle;

	[Token(Token = "0x400D480")]
	[FieldOffset(Offset = "0xFC")]
	protected GameObject Default;

	[Token(Token = "0x400D481")]
	[FieldOffset(Offset = "0x100")]
	protected UINetworkTexture NetworkTexture;

	[Token(Token = "0x400D482")]
	[FieldOffset(Offset = "0x104")]
	protected UIGrid PriceContainer;

	[Token(Token = "0x400D483")]
	[FieldOffset(Offset = "0x108")]
	protected UISprite IPTag;

	[Token(Token = "0x400D484")]
	[FieldOffset(Offset = "0x10C")]
	protected GameObject PreviewCommon;

	[Token(Token = "0x400D485")]
	[FieldOffset(Offset = "0x110")]
	protected GameObject GemsAndGoldContainer;

	[Token(Token = "0x400D486")]
	[FieldOffset(Offset = "0x114")]
	protected UILabel DualCurrencyGemsPrice;

	[Token(Token = "0x400D487")]
	[FieldOffset(Offset = "0x118")]
	protected UILabel DualCurrencyGoldPrice;

	[Token(Token = "0x400D488")]
	[FieldOffset(Offset = "0x11C")]
	protected UILabel OriginalGemsPriceLabel;

	[Token(Token = "0x400D489")]
	[FieldOffset(Offset = "0x120")]
	protected UILabel ExpireTime;

	[Token(Token = "0x400D48A")]
	[FieldOffset(Offset = "0x124")]
	protected UILabel OtherChannelTitle;

	[Token(Token = "0x400D48B")]
	[FieldOffset(Offset = "0x128")]
	protected UISprite OtherChannelIcon;

	[Token(Token = "0x600B689")]
	[Address(RVA = "0x225EB94", Offset = "0x225EB94", VA = "0x225EB94")]
	public UIMallItemBaseController()
	{
	}

	[Token(Token = "0x600B68A")]
	[Address(RVA = "0x225EBB0", Offset = "0x225EBB0", VA = "0x225EBB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B68B")]
	[Address(RVA = "0x225EDE4", Offset = "0x225EDE4", VA = "0x225EDE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B68C")]
	[Address(RVA = "0x225EF18", Offset = "0x225EF18", VA = "0x225EF18", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B68D")]
	[Address(RVA = "0x225EF7C", Offset = "0x225EF7C", VA = "0x225EF7C", Slot = "33")]
	public override void OnItemBtnClick2()
	{
	}

	[Token(Token = "0x600B68E")]
	[Address(RVA = "0x225F158", Offset = "0x225F158", VA = "0x225F158", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B68F")]
	[Address(RVA = "0x225F850", Offset = "0x225F850", VA = "0x225F850", Slot = "37")]
	protected virtual void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B690")]
	[Address(RVA = "0x225F8A4", Offset = "0x225F8A4", VA = "0x225F8A4", Slot = "38")]
	protected virtual void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B691")]
	[Address(RVA = "0x225F8F8", Offset = "0x225F8F8", VA = "0x225F8F8", Slot = "39")]
	protected virtual void OnClothItemClick()
	{
	}

	[Token(Token = "0x600B692")]
	[Address(RVA = "0x225FBBC", Offset = "0x225FBBC", VA = "0x225FBBC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B693")]
	[Address(RVA = "0x225FC38", Offset = "0x225FC38", VA = "0x225FC38", Slot = "40")]
	public virtual void SetHighLightBGState(bool show)
	{
	}

	[Token(Token = "0x600B694")]
	[Address(RVA = "0x225FCBC", Offset = "0x225FCBC", VA = "0x225FCBC")]
	public void RefreshTag(EInventory.StoreTag tag_type, uint tag_value, ulong expireTime)
	{
	}

	[Token(Token = "0x600B695")]
	[Address(RVA = "0x2260008", Offset = "0x2260008", VA = "0x2260008")]
	public void HideAllTag()
	{
	}

	[Token(Token = "0x600B696")]
	[Address(RVA = "0x226023C", Offset = "0x226023C", VA = "0x226023C", Slot = "41")]
	protected virtual bool CanShowDiscountTag()
	{
		return default(bool);
	}

	[Token(Token = "0x600B697")]
	[Address(RVA = "0x2260294", Offset = "0x2260294", VA = "0x2260294", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B698")]
	[Address(RVA = "0x22604A0", Offset = "0x22604A0", VA = "0x22604A0", Slot = "42")]
	protected virtual void RefreshItemView()
	{
	}

	[Token(Token = "0x600B699")]
	[Address(RVA = "0x22609C8", Offset = "0x22609C8", VA = "0x22609C8", Slot = "43")]
	protected virtual void ResetState()
	{
	}

	[Token(Token = "0x600B69A")]
	[Address(RVA = "0x22606A8", Offset = "0x22606A8", VA = "0x22606A8")]
	private void SetIPTag()
	{
	}

	[Token(Token = "0x600B69B")]
	[Address(RVA = "0x2260A1C", Offset = "0x2260A1C", VA = "0x2260A1C")]
	protected void InitItemData(uint itemID)
	{
	}

	[Token(Token = "0x600B69C")]
	[Address(RVA = "0x226051C", Offset = "0x226051C", VA = "0x226051C")]
	public void CheckItemABReady()
	{
	}

	[Token(Token = "0x600B69D")]
	[Address(RVA = "0x2260E68", Offset = "0x2260E68", VA = "0x2260E68", Slot = "44")]
	protected virtual void SetLimitedTitleState()
	{
	}

	[Token(Token = "0x600B69E")]
	[Address(RVA = "0x2260F74", Offset = "0x2260F74", VA = "0x2260F74", Slot = "45")]
	protected virtual void SetUniquedTitleState()
	{
	}

	[Token(Token = "0x600B69F")]
	[Address(RVA = "0x22610A0", Offset = "0x22610A0", VA = "0x22610A0", Slot = "46")]
	protected virtual void SetPreviewTitle()
	{
	}

	[Token(Token = "0x600B6A0")]
	[Address(RVA = "0x22612B4", Offset = "0x22612B4", VA = "0x22612B4", Slot = "47")]
	public virtual void RefreshItemBGState()
	{
	}

	[Token(Token = "0x600B6A1")]
	[Address(RVA = "0x22613E0", Offset = "0x22613E0", VA = "0x22613E0")]
	protected void SetOtherChannelState(StoreDesc storeDesc)
	{
	}

	[Token(Token = "0x600B6A2")]
	[Address(RVA = "0x226168C", Offset = "0x226168C", VA = "0x226168C")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600B6A3")]
	[Address(RVA = "0x2261A2C", Offset = "0x2261A2C", VA = "0x2261A2C", Slot = "48")]
	protected virtual void OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B6A4")]
	[Address(RVA = "0x2261A80", Offset = "0x2261A80", VA = "0x2261A80", Slot = "49")]
	protected virtual void OnFinishToggleMove()
	{
	}

	[Token(Token = "0x600B6A5")]
	[Address(RVA = "0x2261AD4", Offset = "0x2261AD4", VA = "0x2261AD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B6A6")]
	[Address(RVA = "0x2261ADC", Offset = "0x2261ADC", VA = "0x2261ADC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B6A7")]
	[Address(RVA = "0x2261AE4", Offset = "0x2261AE4", VA = "0x2261AE4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B6A8")]
	[Address(RVA = "0x2261AEC", Offset = "0x2261AEC", VA = "0x2261AEC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B6A9")]
	[Address(RVA = "0x2261AF4", Offset = "0x2261AF4", VA = "0x2261AF4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600B6AA")]
	[Address(RVA = "0x2261AFC", Offset = "0x2261AFC", VA = "0x2261AFC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}
}
