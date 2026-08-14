using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029C2")]
public class UIMemberShipReissueMiniItemController : UIBaseController
{
	[Token(Token = "0x40100F1")]
	[FieldOffset(Offset = "0x28")]
	private UIStandardItemMiniController m_MiniCtrl;

	[Token(Token = "0x40100F2")]
	[FieldOffset(Offset = "0x2C")]
	private UIMemberShipReissueMiniItemView m_View;

	[Token(Token = "0x40100F3")]
	[FieldOffset(Offset = "0x30")]
	private ClientReissueAward m_Data;

	[Token(Token = "0x6010CAE")]
	[Address(RVA = "0x12FF054", Offset = "0x12FF054", VA = "0x12FF054")]
	public UIMemberShipReissueMiniItemController()
	{
	}

	[Token(Token = "0x6010CAF")]
	[Address(RVA = "0x12FF0D8", Offset = "0x12FF0D8", VA = "0x12FF0D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CB0")]
	[Address(RVA = "0x12FF17C", Offset = "0x12FF17C", VA = "0x12FF17C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CB1")]
	[Address(RVA = "0x12FEA10", Offset = "0x12FEA10", VA = "0x12FEA10")]
	public void SetViewData(ClientReissueAward award)
	{
	}

	[Token(Token = "0x6010CB2")]
	[Address(RVA = "0x12FF2D4", Offset = "0x12FF2D4", VA = "0x12FF2D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
