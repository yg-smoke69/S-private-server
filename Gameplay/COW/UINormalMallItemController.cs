using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002211")]
public class UINormalMallItemController : UIMallItemWidgetController
{
	[Token(Token = "0x400D509")]
	[FieldOffset(Offset = "0x130")]
	private StoreDesc m_StoreItem;

	[Token(Token = "0x400D50A")]
	[FieldOffset(Offset = "0x134")]
	private bool m_NeedPlay;

	[Token(Token = "0x600B823")]
	[Address(RVA = "0x26E1784", Offset = "0x26E1784", VA = "0x26E1784")]
	public UINormalMallItemController()
	{
	}

	[Token(Token = "0x600B824")]
	[Address(RVA = "0x26E178C", Offset = "0x26E178C", VA = "0x26E178C", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B825")]
	[Address(RVA = "0x26E17E8", Offset = "0x26E17E8", VA = "0x26E17E8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B826")]
	[Address(RVA = "0x26E188C", Offset = "0x26E188C", VA = "0x26E188C", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B827")]
	[Address(RVA = "0x26E1FC8", Offset = "0x26E1FC8", VA = "0x26E1FC8", Slot = "50")]
	protected virtual void SetPriceLabel()
	{
	}

	[Token(Token = "0x600B828")]
	[Address(RVA = "0x26E2788", Offset = "0x26E2788", VA = "0x26E2788", Slot = "41")]
	protected override bool CanShowDiscountTag()
	{
		return default(bool);
	}

	[Token(Token = "0x600B829")]
	[Address(RVA = "0x26E2850", Offset = "0x26E2850", VA = "0x26E2850", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B82A")]
	[Address(RVA = "0x26E2AA0", Offset = "0x26E2AA0", VA = "0x26E2AA0", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B82B")]
	[Address(RVA = "0x26E2CF0", Offset = "0x26E2CF0", VA = "0x26E2CF0", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B82C")]
	[Address(RVA = "0x26E2EF4", Offset = "0x26E2EF4", VA = "0x26E2EF4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B82D")]
	[Address(RVA = "0x26E30BC", Offset = "0x26E30BC", VA = "0x26E30BC", Slot = "48")]
	protected override void OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B82E")]
	[Address(RVA = "0x26E3158", Offset = "0x26E3158", VA = "0x26E3158", Slot = "49")]
	protected override void OnFinishToggleMove()
	{
	}

	[Token(Token = "0x600B82F")]
	[Address(RVA = "0x26E15BC", Offset = "0x26E15BC", VA = "0x26E15BC")]
	public void HideEffect()
	{
	}

	[Token(Token = "0x600B830")]
	[Address(RVA = "0x26E1BE4", Offset = "0x26E1BE4", VA = "0x26E1BE4")]
	public void ShowNotReadyLabel(uint id)
	{
	}

	[Token(Token = "0x600B831")]
	[Address(RVA = "0x26E32C4", Offset = "0x26E32C4", VA = "0x26E32C4")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600B832")]
	[Address(RVA = "0x26E3378", Offset = "0x26E3378", VA = "0x26E3378")]
	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B833")]
	[Address(RVA = "0x26E3380", Offset = "0x26E3380", VA = "0x26E3380")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B834")]
	[Address(RVA = "0x26E3388", Offset = "0x26E3388", VA = "0x26E3388")]
	public bool _003C_003EiFixBaseProxy_CanShowDiscountTag()
	{
		return default(bool);
	}

	[Token(Token = "0x600B835")]
	[Address(RVA = "0x26E3390", Offset = "0x26E3390", VA = "0x26E3390")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B836")]
	[Address(RVA = "0x26E3398", Offset = "0x26E3398", VA = "0x26E3398")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B837")]
	[Address(RVA = "0x26E33A0", Offset = "0x26E33A0", VA = "0x26E33A0")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B838")]
	[Address(RVA = "0x26E33A8", Offset = "0x26E33A8", VA = "0x26E33A8")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B839")]
	[Address(RVA = "0x26E33B0", Offset = "0x26E33B0", VA = "0x26E33B0")]
	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B83A")]
	[Address(RVA = "0x26E33B8", Offset = "0x26E33B8", VA = "0x26E33B8")]
	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
