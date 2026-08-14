using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002675")]
public class UIGachaShowRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400ED6C")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaShowRewardItemView m_View;

	[Token(Token = "0x400ED6D")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x400ED6E")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsTokenTowerTempBag;

	[Token(Token = "0x400ED6F")]
	[FieldOffset(Offset = "0x0")]
	private static bool m_IsShowDropUp;

	[Token(Token = "0x400ED70")]
	[FieldOffset(Offset = "0x4")]
	private static uint m_CurrentGachaID;

	[Token(Token = "0x17001188")]
	public static uint CurrentGachaID
	{
		[Token(Token = "0x600E662")]
		[Address(RVA = "0x2A2134C", Offset = "0x2A2134C", VA = "0x2A2134C")]
		set
		{
		}
	}

	[Token(Token = "0x17001189")]
	public static bool IsShowDropUp
	{
		[Token(Token = "0x600E663")]
		[Address(RVA = "0x2A21274", Offset = "0x2A21274", VA = "0x2A21274")]
		set
		{
		}
	}

	[Token(Token = "0x600E661")]
	[Address(RVA = "0x2A2A2EC", Offset = "0x2A2A2EC", VA = "0x2A2A2EC")]
	public UIGachaShowRewardItemController()
	{
	}

	[Token(Token = "0x600E664")]
	[Address(RVA = "0x2A2A2F4", Offset = "0x2A2A2F4", VA = "0x2A2A2F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E665")]
	[Address(RVA = "0x2A2A398", Offset = "0x2A2A398", VA = "0x2A2A398", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E666")]
	[Address(RVA = "0x2A2A52C", Offset = "0x2A2A52C", VA = "0x2A2A52C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E667")]
	[Address(RVA = "0x2A2A5C8", Offset = "0x2A2A5C8", VA = "0x2A2A5C8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E668")]
	[Address(RVA = "0x2A2A7D0", Offset = "0x2A2A7D0", VA = "0x2A2A7D0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E669")]
	[Address(RVA = "0x2A2A91C", Offset = "0x2A2A91C", VA = "0x2A2A91C")]
	private void RefreshDataItem(BaseItemInfo data)
	{
	}

	[Token(Token = "0x600E66A")]
	[Address(RVA = "0x2A2B404", Offset = "0x2A2B404", VA = "0x2A2B404")]
	public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
	{
	}

	[Token(Token = "0x600E66B")]
	[Address(RVA = "0x2A2B948", Offset = "0x2A2B948", VA = "0x2A2B948")]
	public void SetVfxDisable()
	{
	}

	[Token(Token = "0x600E66C")]
	[Address(RVA = "0x2A2BA48", Offset = "0x2A2BA48", VA = "0x2A2BA48")]
	public void SetItemBtnDisable()
	{
	}

	[Token(Token = "0x600E66D")]
	[Address(RVA = "0x2A2BAD8", Offset = "0x2A2BAD8", VA = "0x2A2BAD8")]
	public void SetIsLegendRewardPool()
	{
	}

	[Token(Token = "0x600E66E")]
	[Address(RVA = "0x2A2BC0C", Offset = "0x2A2BC0C", VA = "0x2A2BC0C")]
	public void OnLegendItemBtnClick()
	{
	}

	[Token(Token = "0x600E66F")]
	[Address(RVA = "0x2A2BE90", Offset = "0x2A2BE90", VA = "0x2A2BE90")]
	public void SetTokenTowerTempBag()
	{
	}

	[Token(Token = "0x600E671")]
	[Address(RVA = "0x2A2BEF0", Offset = "0x2A2BEF0", VA = "0x2A2BEF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E672")]
	[Address(RVA = "0x2A2BEF8", Offset = "0x2A2BEF8", VA = "0x2A2BEF8")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E673")]
	[Address(RVA = "0x2A2BF00", Offset = "0x2A2BF00", VA = "0x2A2BF00")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
