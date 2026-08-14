using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200252A")]
public class UIClanAreaItemController : UIPopMenuItemBaseController
{
	[Token(Token = "0x400E66F")]
	[FieldOffset(Offset = "0x2C")]
	private UIClanAreaItemView m_View;

	[Token(Token = "0x400E670")]
	[FieldOffset(Offset = "0x30")]
	private PopMenuData m_Data;

	[Token(Token = "0x400E671")]
	[FieldOffset(Offset = "0x34")]
	private ClanAreaItemVO m_VO;

	[Token(Token = "0x600D81F")]
	[Address(RVA = "0x2F20C30", Offset = "0x2F20C30", VA = "0x2F20C30")]
	public UIClanAreaItemController()
	{
	}

	[Token(Token = "0x600D820")]
	[Address(RVA = "0x2F20C38", Offset = "0x2F20C38", VA = "0x2F20C38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D821")]
	[Address(RVA = "0x2F20CDC", Offset = "0x2F20CDC", VA = "0x2F20CDC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D822")]
	[Address(RVA = "0x2F20E38", Offset = "0x2F20E38", VA = "0x2F20E38", Slot = "31")]
	public override void SetItemData(PopMenuData data)
	{
	}

	[Token(Token = "0x600D823")]
	[Address(RVA = "0x2F21038", Offset = "0x2F21038", VA = "0x2F21038")]
	private void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x600D824")]
	[Address(RVA = "0x2F2119C", Offset = "0x2F2119C", VA = "0x2F2119C")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x600D825")]
	[Address(RVA = "0x2F21298", Offset = "0x2F21298", VA = "0x2F21298")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D826")]
	[Address(RVA = "0x2F212A0", Offset = "0x2F212A0", VA = "0x2F212A0")]
	public void _003C_003EiFixBaseProxy_SetItemData(PopMenuData P0)
	{
	}
}
