using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B67")]
public class UIToggleItemController : UIBaseController
{
	[Token(Token = "0x40109F2")]
	[FieldOffset(Offset = "0x28")]
	private UIToggleItemView m_View;

	[Token(Token = "0x40109F3")]
	[FieldOffset(Offset = "0x2C")]
	private PopMenuData m_Data;

	[Token(Token = "0x170012E6")]
	protected UILabel m_SelectLabel
	{
		[Token(Token = "0x6011E15")]
		[Address(RVA = "0x201C55C", Offset = "0x201C55C", VA = "0x201C55C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E7")]
	protected UILabel m_UnSelectLabel
	{
		[Token(Token = "0x6011E16")]
		[Address(RVA = "0x201C5CC", Offset = "0x201C5CC", VA = "0x201C5CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6011E14")]
	[Address(RVA = "0x201C4D8", Offset = "0x201C4D8", VA = "0x201C4D8")]
	public UIToggleItemController()
	{
	}

	[Token(Token = "0x6011E17")]
	[Address(RVA = "0x201C63C", Offset = "0x201C63C", VA = "0x201C63C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E18")]
	[Address(RVA = "0x201C6E0", Offset = "0x201C6E0", VA = "0x201C6E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E19")]
	[Address(RVA = "0x201C83C", Offset = "0x201C83C", VA = "0x201C83C", Slot = "31")]
	public virtual void SetData(PopMenuData data, int groupID)
	{
	}

	[Token(Token = "0x6011E1A")]
	[Address(RVA = "0x201C9DC", Offset = "0x201C9DC", VA = "0x201C9DC")]
	public void RefreshToggleValue()
	{
	}

	[Token(Token = "0x6011E1B")]
	[Address(RVA = "0x201CA8C", Offset = "0x201CA8C", VA = "0x201CA8C")]
	private void OnChange()
	{
	}

	[Token(Token = "0x6011E1C")]
	[Address(RVA = "0x201CC2C", Offset = "0x201CC2C", VA = "0x201CC2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
