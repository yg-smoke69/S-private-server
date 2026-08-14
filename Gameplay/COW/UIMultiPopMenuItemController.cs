using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029D5")]
public class UIMultiPopMenuItemController : UIPopMenuItemBaseController
{
	[Token(Token = "0x4010139")]
	[FieldOffset(Offset = "0x2C")]
	private UIMultiPopMenuItemView m_View;

	[Token(Token = "0x401013A")]
	[FieldOffset(Offset = "0x30")]
	private PopMenuData m_Data;

	[Token(Token = "0x401013B")]
	[FieldOffset(Offset = "0x34")]
	private MultiPopMenuItemVO m_VO;

	[Token(Token = "0x6010D3C")]
	[Address(RVA = "0x195211C", Offset = "0x195211C", VA = "0x195211C")]
	public UIMultiPopMenuItemController()
	{
	}

	[Token(Token = "0x6010D3D")]
	[Address(RVA = "0x1952124", Offset = "0x1952124", VA = "0x1952124")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D3E")]
	[Address(RVA = "0x19521C8", Offset = "0x19521C8", VA = "0x19521C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D3F")]
	[Address(RVA = "0x1952324", Offset = "0x1952324", VA = "0x1952324", Slot = "32")]
	public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
	{
	}

	[Token(Token = "0x6010D40")]
	[Address(RVA = "0x1952758", Offset = "0x1952758", VA = "0x1952758")]
	public void SetDisableState(bool CanSelect)
	{
	}

	[Token(Token = "0x6010D41")]
	[Address(RVA = "0x1952578", Offset = "0x1952578", VA = "0x1952578")]
	public void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x6010D42")]
	[Address(RVA = "0x1952884", Offset = "0x1952884", VA = "0x1952884")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x6010D43")]
	[Address(RVA = "0x1952BDC", Offset = "0x1952BDC", VA = "0x1952BDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D44")]
	[Address(RVA = "0x1952BE4", Offset = "0x1952BE4", VA = "0x1952BE4")]
	public void _003C_003EiFixBaseProxy_SetItemData(PopMenuData P0, int P1, int P2)
	{
	}
}
