using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002652")]
internal class UIGachaLimitChestBuyBtnController : UIGachaBuyBtnController
{
	[Token(Token = "0x400EC98")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaLimitChestBuyBtnView m_chestView;

	[Token(Token = "0x600E4B0")]
	[Address(RVA = "0x2E769F4", Offset = "0x2E769F4", VA = "0x2E769F4")]
	public UIGachaLimitChestBuyBtnController()
	{
	}

	[Token(Token = "0x600E4B1")]
	[Address(RVA = "0x2E769FC", Offset = "0x2E769FC", VA = "0x2E769FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E4B2")]
	[Address(RVA = "0x2E76AA4", Offset = "0x2E76AA4", VA = "0x2E76AA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E4B3")]
	[Address(RVA = "0x2E76B60", Offset = "0x2E76B60", VA = "0x2E76B60", Slot = "31")]
	protected override void InitBuyBtnBaseView()
	{
	}

	[Token(Token = "0x600E4B4")]
	[Address(RVA = "0x2E76BD4", Offset = "0x2E76BD4", VA = "0x2E76BD4", Slot = "38")]
	protected override void OnRefreshBuyBtn()
	{
	}

	[Token(Token = "0x600E4B5")]
	[Address(RVA = "0x2E76F14", Offset = "0x2E76F14", VA = "0x2E76F14", Slot = "35")]
	protected override Color GetLimitLabelColor(uint chestID)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600E4B6")]
	[Address(RVA = "0x2E7700C", Offset = "0x2E7700C", VA = "0x2E7700C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E4B7")]
	[Address(RVA = "0x2E77014", Offset = "0x2E77014", VA = "0x2E77014")]
	public void _003C_003EiFixBaseProxy_OnRefreshBuyBtn()
	{
	}

	[Token(Token = "0x600E4B8")]
	[Address(RVA = "0x2E7701C", Offset = "0x2E7701C", VA = "0x2E7701C")]
	public Color _003C_003EiFixBaseProxy_GetLimitLabelColor(uint P0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}
}
