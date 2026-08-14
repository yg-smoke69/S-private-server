using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021FB")]
internal class UIMysteryMallItemController : UIBaseController
{
	[Token(Token = "0x400D4BB")]
	[FieldOffset(Offset = "0x28")]
	private UIMysteryMallItemView m_View;

	[Token(Token = "0x400D4BC")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x400D4BD")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_IsUniqueAndOwned;

	[Token(Token = "0x400D4BE")]
	[FieldOffset(Offset = "0x34")]
	private MysteryPoolStoreItem m_PoolItemInfo;

	[Token(Token = "0x600B731")]
	[Address(RVA = "0x1B23F6C", Offset = "0x1B23F6C", VA = "0x1B23F6C")]
	public UIMysteryMallItemController()
	{
	}

	[Token(Token = "0x600B732")]
	[Address(RVA = "0x1B23FF0", Offset = "0x1B23FF0", VA = "0x1B23FF0")]
	public BaseItemInfo GetBaseInfo()
	{
		return null;
	}

	[Token(Token = "0x600B733")]
	[Address(RVA = "0x1B24048", Offset = "0x1B24048", VA = "0x1B24048")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B734")]
	[Address(RVA = "0x1B240F0", Offset = "0x1B240F0", VA = "0x1B240F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B735")]
	[Address(RVA = "0x1B244D0", Offset = "0x1B244D0", VA = "0x1B244D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B736")]
	[Address(RVA = "0x1B24524", Offset = "0x1B24524", VA = "0x1B24524")]
	public void SetViewData(MysteryPoolStoreItem poolItem, bool isSuperReward, uint discount)
	{
	}

	[Token(Token = "0x600B737")]
	[Address(RVA = "0x1B264AC", Offset = "0x1B264AC", VA = "0x1B264AC")]
	private void SetPriceLabel(uint gemsPrice, uint discountPrice)
	{
	}

	[Token(Token = "0x600B738")]
	[Address(RVA = "0x1B267A0", Offset = "0x1B267A0", VA = "0x1B267A0")]
	private void OnBtnPurchaseClick()
	{
	}

	[Token(Token = "0x600B739")]
	[Address(RVA = "0x1B26B48", Offset = "0x1B26B48", VA = "0x1B26B48")]
	private void OnBtnPreviewClick()
	{
	}

	[Token(Token = "0x600B73A")]
	[Address(RVA = "0x1B26DC4", Offset = "0x1B26DC4", VA = "0x1B26DC4")]
	public void SetBtnState(bool enable)
	{
	}

	[Token(Token = "0x600B73B")]
	[Address(RVA = "0x1B26E5C", Offset = "0x1B26E5C", VA = "0x1B26E5C")]
	public void SetNew(bool show)
	{
	}

	[Token(Token = "0x600B73C")]
	[Address(RVA = "0x1B243A0", Offset = "0x1B243A0", VA = "0x1B243A0")]
	public void SetLimitTitleState(bool show)
	{
	}

	[Token(Token = "0x600B73D")]
	[Address(RVA = "0x1B24438", Offset = "0x1B24438", VA = "0x1B24438")]
	public void SetClaimedState(bool show)
	{
	}

	[Token(Token = "0x600B73E")]
	[Address(RVA = "0x1B26EF4", Offset = "0x1B26EF4", VA = "0x1B26EF4")]
	public void SetLockState(bool value)
	{
	}

	[Token(Token = "0x600B73F")]
	[Address(RVA = "0x1B26190", Offset = "0x1B26190", VA = "0x1B26190")]
	private void SetIPTag()
	{
	}

	[Token(Token = "0x600B740")]
	[Address(RVA = "0x1B26F8C", Offset = "0x1B26F8C", VA = "0x1B26F8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B741")]
	[Address(RVA = "0x1B26F94", Offset = "0x1B26F94", VA = "0x1B26F94")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
