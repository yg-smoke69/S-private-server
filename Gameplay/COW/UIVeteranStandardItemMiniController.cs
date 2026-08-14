using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BF3")]
internal class UIVeteranStandardItemMiniController : UIBaseController
{
	[Token(Token = "0x4010C7E")]
	[FieldOffset(Offset = "0x28")]
	public UIVeteranStandardItemMiniView m_View;

	[Token(Token = "0x4010C7F")]
	[FieldOffset(Offset = "0x2C")]
	public UIStandardItemMiniController m_Ctrl;

	[Token(Token = "0x6012386")]
	[Address(RVA = "0x2CC5AB8", Offset = "0x2CC5AB8", VA = "0x2CC5AB8")]
	public UIVeteranStandardItemMiniController()
	{
	}

	[Token(Token = "0x6012387")]
	[Address(RVA = "0x2CC5B3C", Offset = "0x2CC5B3C", VA = "0x2CC5B3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012388")]
	[Address(RVA = "0x2CC5BE0", Offset = "0x2CC5BE0", VA = "0x2CC5BE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012389")]
	[Address(RVA = "0x2CC5D28", Offset = "0x2CC5D28", VA = "0x2CC5D28", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601238A")]
	[Address(RVA = "0x2CC5D8C", Offset = "0x2CC5D8C", VA = "0x2CC5D8C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601238B")]
	[Address(RVA = "0x2CC5DF0", Offset = "0x2CC5DF0", VA = "0x2CC5DF0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601238C")]
	[Address(RVA = "0x2CC5E54", Offset = "0x2CC5E54", VA = "0x2CC5E54")]
	public void ShowChoosedItem(bool flag)
	{
	}

	[Token(Token = "0x601238D")]
	[Address(RVA = "0x2CC5EEC", Offset = "0x2CC5EEC", VA = "0x2CC5EEC")]
	public void SetHighLight(bool flag)
	{
	}

	[Token(Token = "0x601238E")]
	[Address(RVA = "0x2CC5F98", Offset = "0x2CC5F98", VA = "0x2CC5F98")]
	public void SetGreyBG(bool flag)
	{
	}

	[Token(Token = "0x601238F")]
	[Address(RVA = "0x2CC6044", Offset = "0x2CC6044", VA = "0x2CC6044")]
	public void SetData(Callback action)
	{
	}

	[Token(Token = "0x6012390")]
	[Address(RVA = "0x2CC6110", Offset = "0x2CC6110", VA = "0x2CC6110")]
	public void SetItemData(StatndardItemMiniData item)
	{
	}

	[Token(Token = "0x6012391")]
	[Address(RVA = "0x2CC6198", Offset = "0x2CC6198", VA = "0x2CC6198")]
	public void SetItemBtnEnable(bool enable)
	{
	}

	[Token(Token = "0x6012392")]
	[Address(RVA = "0x2CC6228", Offset = "0x2CC6228", VA = "0x2CC6228")]
	public void SetCanNotEquip(bool show)
	{
	}

	[Token(Token = "0x6012393")]
	[Address(RVA = "0x2CC62AC", Offset = "0x2CC62AC", VA = "0x2CC62AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012394")]
	[Address(RVA = "0x2CC62B4", Offset = "0x2CC62B4", VA = "0x2CC62B4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6012395")]
	[Address(RVA = "0x2CC62BC", Offset = "0x2CC62BC", VA = "0x2CC62BC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012396")]
	[Address(RVA = "0x2CC62C4", Offset = "0x2CC62C4", VA = "0x2CC62C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
