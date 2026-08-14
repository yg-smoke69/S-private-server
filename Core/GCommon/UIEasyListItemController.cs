using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004141")]
public abstract class UIEasyListItemController : UIBaseController
{
	[Token(Token = "0x2004142")]
	public delegate void ItemClickCallBack(int data_index);

	[Token(Token = "0x401B644")]
	[FieldOffset(Offset = "0x28")]
	private int m_Index;

	[Token(Token = "0x401B645")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsSelected;

	[Token(Token = "0x401B646")]
	[FieldOffset(Offset = "0x30")]
	public ItemClickCallBack m_SelectCallBack;

	[Token(Token = "0x401B647")]
	[FieldOffset(Offset = "0x34")]
	public ItemClickCallBack m_ClickCallBack;

	[Token(Token = "0x17001D60")]
	public int Index
	{
		[Token(Token = "0x601AAAA")]
		[Address(RVA = "0x2CA17FC", Offset = "0x2CA17FC", VA = "0x2CA17FC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601AAA9")]
	[Address(RVA = "0x2CA2210", Offset = "0x2CA2210", VA = "0x2CA2210")]
	protected UIEasyListItemController()
	{
	}

	[Token(Token = "0x601AAAB")]
	public abstract void SetViewData(object data, int data_index);

	[Token(Token = "0x601AAAC")]
	[Address(RVA = "0x2C9FB54", Offset = "0x2C9FB54", VA = "0x2C9FB54")]
	public void SetItemSelectCallBack(ItemClickCallBack item_SelectCallBack)
	{
	}

	[Token(Token = "0x601AAAD")]
	[Address(RVA = "0x2C9FB5C", Offset = "0x2C9FB5C", VA = "0x2C9FB5C")]
	public void SetItemClickCallBack(ItemClickCallBack item_ClickCallBack)
	{
	}

	[Token(Token = "0x601AAAE")]
	[Address(RVA = "0x2CA1ADC", Offset = "0x2CA1ADC", VA = "0x2CA1ADC")]
	public void EasyListSelectItem()
	{
	}

	[Token(Token = "0x601AAAF")]
	[Address(RVA = "0x2CA24C0", Offset = "0x2CA24C0", VA = "0x2CA24C0")]
	public void EasyListClickItem()
	{
	}

	[Token(Token = "0x601AAB0")]
	[Address(RVA = "0x2CA24DC", Offset = "0x2CA24DC", VA = "0x2CA24DC")]
	public bool GetSelectState()
	{
		return default(bool);
	}

	[Token(Token = "0x601AAB1")]
	[Address(RVA = "0x2CA24E4", Offset = "0x2CA24E4", VA = "0x2CA24E4", Slot = "32")]
	public virtual void OnItemBtnClick()
	{
	}

	[Token(Token = "0x601AAB2")]
	[Address(RVA = "0x2CA24E8", Offset = "0x2CA24E8", VA = "0x2CA24E8", Slot = "33")]
	public virtual void OnItemBtnClick2()
	{
	}

	[Token(Token = "0x601AAB3")]
	[Address(RVA = "0x2CA24EC", Offset = "0x2CA24EC", VA = "0x2CA24EC", Slot = "34")]
	public virtual void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x601AAB4")]
	[Address(RVA = "0x2CA24F8", Offset = "0x2CA24F8", VA = "0x2CA24F8", Slot = "35")]
	public virtual void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x601AAB5")]
	[Address(RVA = "0x2CA2504", Offset = "0x2CA2504", VA = "0x2CA2504", Slot = "36")]
	public virtual void OnItemBtnCancelSelect()
	{
	}

	[Token(Token = "0x601AAB6")]
	[Address(RVA = "0x2CA08D4", Offset = "0x2CA08D4", VA = "0x2CA08D4")]
	public void SetEasyListData(int wrapIndex, int realIndex)
	{
	}
}
