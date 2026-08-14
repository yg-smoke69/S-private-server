using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B68")]
public class UIToggleSpriteItemController : UIBaseController
{
	[Token(Token = "0x40109F4")]
	[FieldOffset(Offset = "0x28")]
	private UIToggleSpriteItemView m_View;

	[Token(Token = "0x40109F5")]
	[FieldOffset(Offset = "0x2C")]
	private PopMenuData m_Data;

	[Token(Token = "0x6011E1D")]
	[Address(RVA = "0x201CEAC", Offset = "0x201CEAC", VA = "0x201CEAC")]
	public UIToggleSpriteItemController()
	{
	}

	[Token(Token = "0x6011E1E")]
	[Address(RVA = "0x201CF30", Offset = "0x201CF30", VA = "0x201CF30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E1F")]
	[Address(RVA = "0x201CFD4", Offset = "0x201CFD4", VA = "0x201CFD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E20")]
	[Address(RVA = "0x201D130", Offset = "0x201D130", VA = "0x201D130", Slot = "31")]
	public virtual void SetData(PopMenuData data, int groupID)
	{
	}

	[Token(Token = "0x6011E21")]
	[Address(RVA = "0x201D230", Offset = "0x201D230", VA = "0x201D230")]
	public void SetSprite(string name)
	{
	}

	[Token(Token = "0x6011E22")]
	[Address(RVA = "0x201D300", Offset = "0x201D300", VA = "0x201D300", Slot = "32")]
	public virtual void RefreshToggleValue()
	{
	}

	[Token(Token = "0x6011E23")]
	[Address(RVA = "0x201D444", Offset = "0x201D444", VA = "0x201D444")]
	private void OnChange()
	{
	}

	[Token(Token = "0x6011E24")]
	[Address(RVA = "0x201D5E4", Offset = "0x201D5E4", VA = "0x201D5E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
