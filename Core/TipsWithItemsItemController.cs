using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20023D1")]
public class TipsWithItemsItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DEB1")]
	[FieldOffset(Offset = "0x28")]
	private TipsWithItemsItemView m_View;

	[Token(Token = "0x400DEB2")]
	[FieldOffset(Offset = "0x2C")]
	private int _003Cm_Height_003Ek__BackingField;

	[Token(Token = "0x400DEB3")]
	[FieldOffset(Offset = "0x30")]
	private int m_TitleHeight;

	[Token(Token = "0x400DEB4")]
	[FieldOffset(Offset = "0x34")]
	private int m_ContentHeight;

	[Token(Token = "0x170010E6")]
	public int m_Height
	{
		[Token(Token = "0x600C9FC")]
		[Address(RVA = "0x263ADE8", Offset = "0x263ADE8", VA = "0x263ADE8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600C9FB")]
		[Address(RVA = "0x263AE8C", Offset = "0x263AE8C", VA = "0x263AE8C")]
		private set
		{
		}
	}

	[Token(Token = "0x600C9FA")]
	[Address(RVA = "0x263ADF8", Offset = "0x263ADF8", VA = "0x263ADF8")]
	public TipsWithItemsItemController()
	{
	}

	[Token(Token = "0x600C9FD")]
	[Address(RVA = "0x263AE94", Offset = "0x263AE94", VA = "0x263AE94")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9FE")]
	[Address(RVA = "0x263AEF8", Offset = "0x263AEF8", VA = "0x263AEF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9FF")]
	[Address(RVA = "0x263AF6C", Offset = "0x263AF6C", VA = "0x263AF6C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600CA00")]
	[Address(RVA = "0x263ABE4", Offset = "0x263ABE4", VA = "0x263ABE4", Slot = "31")]
	public void SetData(TipsWithItemsItemVO vo)
	{
	}
}
