using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002781")]
internal class UIHudInGameShopItemController : UIBaseController
{
	[Token(Token = "0x400F3F3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInGameShopItemViewExt m_View;

	[Token(Token = "0x400F3F4")]
	[FieldOffset(Offset = "0x2C")]
	private MCOMKOKDDHE m_ItemInfo;

	[Token(Token = "0x400F3F5")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Selected;

	[Token(Token = "0x600F282")]
	[Address(RVA = "0x229FF24", Offset = "0x229FF24", VA = "0x229FF24")]
	public UIHudInGameShopItemController()
	{
	}

	[Token(Token = "0x600F283")]
	[Address(RVA = "0x229FFA8", Offset = "0x229FFA8", VA = "0x229FFA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F284")]
	[Address(RVA = "0x22A0050", Offset = "0x22A0050", VA = "0x22A0050", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F285")]
	[Address(RVA = "0x22A09EC", Offset = "0x22A09EC", VA = "0x22A09EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F286")]
	[Address(RVA = "0x22A0DF8", Offset = "0x22A0DF8", VA = "0x22A0DF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600F287")]
	[Address(RVA = "0x229C074", Offset = "0x229C074", VA = "0x229C074")]
	public int GetSortOrder()
	{
		return default(int);
	}

	[Token(Token = "0x600F288")]
	[Address(RVA = "0x22A1088", Offset = "0x22A1088", VA = "0x22A1088")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600F289")]
	[Address(RVA = "0x229BB38", Offset = "0x229BB38", VA = "0x229BB38")]
	public void SetUIData(MCOMKOKDDHE data)
	{
	}

	[Token(Token = "0x600F28A")]
	[Address(RVA = "0x22A2168", Offset = "0x22A2168", VA = "0x22A2168")]
	private void OnClearSelectedItem(object[] data)
	{
	}

	[Token(Token = "0x600F28B")]
	[Address(RVA = "0x22A21E0", Offset = "0x22A21E0", VA = "0x22A21E0")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600F28C")]
	[Address(RVA = "0x22A1210", Offset = "0x22A1210", VA = "0x22A1210")]
	private void SetSelected(bool v)
	{
	}

	[Token(Token = "0x600F28D")]
	[Address(RVA = "0x22A2384", Offset = "0x22A2384", VA = "0x22A2384")]
	private void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600F28E")]
	[Address(RVA = "0x22A2768", Offset = "0x22A2768", VA = "0x22A2768")]
	private void OnBagCapacityLeftChanged(object[] data)
	{
	}

	[Token(Token = "0x600F28F")]
	[Address(RVA = "0x22A2888", Offset = "0x22A2888", VA = "0x22A2888")]
	private bool IsBagCapacityLack(int capacityLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x600F290")]
	[Address(RVA = "0x22A2940", Offset = "0x22A2940", VA = "0x22A2940")]
	private void OnGlobalAvailableNumChanged(object[] data)
	{
	}

	[Token(Token = "0x600F291")]
	[Address(RVA = "0x22A2AF4", Offset = "0x22A2AF4", VA = "0x22A2AF4")]
	private void OnRefreshShopAvaiable(object[] data)
	{
	}

	[Token(Token = "0x600F292")]
	[Address(RVA = "0x22A2F54", Offset = "0x22A2F54", VA = "0x22A2F54")]
	private void OnPersonalBoughtCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600F293")]
	[Address(RVA = "0x22A3150", Offset = "0x22A3150", VA = "0x22A3150")]
	private void OnShopHudInited(object[] data)
	{
	}

	[Token(Token = "0x600F294")]
	[Address(RVA = "0x22A1E20", Offset = "0x22A1E20", VA = "0x22A1E20")]
	private void UpdateLimitationLabelByGlobalLimit(int available)
	{
	}

	[Token(Token = "0x600F295")]
	[Address(RVA = "0x22A1FF8", Offset = "0x22A1FF8", VA = "0x22A1FF8")]
	private void UpdateLimitationLabelByPersonalLimit(int haveBoughtCount, int totalLimit)
	{
	}

	[Token(Token = "0x600F296")]
	[Address(RVA = "0x22A3340", Offset = "0x22A3340", VA = "0x22A3340")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F297")]
	[Address(RVA = "0x22A3348", Offset = "0x22A3348", VA = "0x22A3348")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
