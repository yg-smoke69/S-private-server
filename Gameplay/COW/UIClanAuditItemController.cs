using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200252B")]
public class UIClanAuditItemController : UIPopMenuItemBaseController
{
	[Token(Token = "0x400E672")]
	[FieldOffset(Offset = "0x2C")]
	private UIClanAuditItemView m_View;

	[Token(Token = "0x400E673")]
	[FieldOffset(Offset = "0x30")]
	private PopMenuData m_Data;

	[Token(Token = "0x600D827")]
	[Address(RVA = "0x2F214FC", Offset = "0x2F214FC", VA = "0x2F214FC")]
	public UIClanAuditItemController()
	{
	}

	[Token(Token = "0x600D828")]
	[Address(RVA = "0x2F21504", Offset = "0x2F21504", VA = "0x2F21504")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D829")]
	[Address(RVA = "0x2F215A8", Offset = "0x2F215A8", VA = "0x2F215A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D82A")]
	[Address(RVA = "0x2F21704", Offset = "0x2F21704", VA = "0x2F21704", Slot = "31")]
	public override void SetItemData(PopMenuData data)
	{
	}

	[Token(Token = "0x600D82B")]
	[Address(RVA = "0x2F217C0", Offset = "0x2F217C0", VA = "0x2F217C0")]
	private void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x600D82C")]
	[Address(RVA = "0x2F21924", Offset = "0x2F21924", VA = "0x2F21924")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x600D82D")]
	[Address(RVA = "0x2F21AB4", Offset = "0x2F21AB4", VA = "0x2F21AB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D82E")]
	[Address(RVA = "0x2F21ABC", Offset = "0x2F21ABC", VA = "0x2F21ABC")]
	public void _003C_003EiFixBaseProxy_SetItemData(PopMenuData P0)
	{
	}
}
