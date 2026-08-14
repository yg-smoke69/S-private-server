using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002915")]
internal class UILoadoutItemControllerUnified : UIBaseController
{
	[Token(Token = "0x400FCFC")]
	[FieldOffset(Offset = "0x28")]
	private UILoadOutItemUnifiedView m_View;

	[Token(Token = "0x400FCFD")]
	[FieldOffset(Offset = "0x2C")]
	public Item PlayCardData;

	[Token(Token = "0x400FCFE")]
	[FieldOffset(Offset = "0x30")]
	public int ItemIdex;

	[Token(Token = "0x400FCFF")]
	[FieldOffset(Offset = "0x34")]
	public BaseItemInfo LoadOutData;

	[Token(Token = "0x400FD00")]
	[FieldOffset(Offset = "0x38")]
	public CSSharedItemDataManager.LoadoutSubType LoadOutType;

	[Token(Token = "0x400FD01")]
	[FieldOffset(Offset = "0x3C")]
	private UIStandardItemMiniController m_ItemCtrl;

	[Token(Token = "0x400FD02")]
	[FieldOffset(Offset = "0x40")]
	protected bool m_selected;

	[Token(Token = "0x400FD03")]
	[FieldOffset(Offset = "0x41")]
	private bool m_Purchase;

	[Token(Token = "0x400FD04")]
	[FieldOffset(Offset = "0x44")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400FD05")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Isbanned;

	[Token(Token = "0x60104BE")]
	[Address(RVA = "0x2164138", Offset = "0x2164138", VA = "0x2164138")]
	public UILoadoutItemControllerUnified()
	{
	}

	[Token(Token = "0x60104BF")]
	[Address(RVA = "0x21641BC", Offset = "0x21641BC", VA = "0x21641BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60104C0")]
	[Address(RVA = "0x2164260", Offset = "0x2164260", VA = "0x2164260", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104C1")]
	[Address(RVA = "0x2164444", Offset = "0x2164444", VA = "0x2164444")]
	private void InitView()
	{
	}

	[Token(Token = "0x60104C2")]
	[Address(RVA = "0x2155198", Offset = "0x2155198", VA = "0x2155198")]
	public void SetSelected(bool v)
	{
	}

	[Token(Token = "0x60104C3")]
	[Address(RVA = "0x21643AC", Offset = "0x21643AC", VA = "0x21643AC")]
	protected void ShowPlayCardInfo(bool val)
	{
	}

	[Token(Token = "0x60104C4")]
	[Address(RVA = "0x2153610", Offset = "0x2153610", VA = "0x2153610")]
	public void SetData(BaseItemInfo item, int index)
	{
	}

	[Token(Token = "0x60104C5")]
	[Address(RVA = "0x2151EA4", Offset = "0x2151EA4", VA = "0x2151EA4")]
	public void SetBanned(bool isBanned)
	{
	}

	[Token(Token = "0x60104C6")]
	[Address(RVA = "0x2152048", Offset = "0x2152048", VA = "0x2152048")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x60104C7")]
	[Address(RVA = "0x2151F04", Offset = "0x2151F04", VA = "0x2151F04")]
	public void SetItemEnable(bool isEnable, bool isPurchase = false)
	{
	}

	[Token(Token = "0x60104C8")]
	[Address(RVA = "0x2164624", Offset = "0x2164624", VA = "0x2164624")]
	protected void RefreshPlayCardTime()
	{
	}

	[Token(Token = "0x60104C9")]
	[Address(RVA = "0x2164800", Offset = "0x2164800", VA = "0x2164800")]
	private void OnBtnClicked()
	{
	}

	[Token(Token = "0x60104CA")]
	[Address(RVA = "0x2165714", Offset = "0x2165714", VA = "0x2165714")]
	public void Update()
	{
	}

	[Token(Token = "0x60104CB")]
	[Address(RVA = "0x2165894", Offset = "0x2165894", VA = "0x2165894")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
