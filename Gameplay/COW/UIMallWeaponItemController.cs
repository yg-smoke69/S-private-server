using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021F5")]
public class UIMallWeaponItemController : UIMallCDNItemController
{
	[Token(Token = "0x400D4A1")]
	[FieldOffset(Offset = "0x138")]
	private UIMallWeaponItemView m_View;

	[Token(Token = "0x400D4A2")]
	[FieldOffset(Offset = "0x13C")]
	private StoreDesc m_Info;

	[Token(Token = "0x600B6FD")]
	[Address(RVA = "0x226EE2C", Offset = "0x226EE2C", VA = "0x226EE2C")]
	public UIMallWeaponItemController()
	{
	}

	[Token(Token = "0x600B6FE")]
	[Address(RVA = "0x226EE34", Offset = "0x226EE34", VA = "0x226EE34", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6FF")]
	[Address(RVA = "0x226EE90", Offset = "0x226EE90", VA = "0x226EE90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B700")]
	[Address(RVA = "0x226EF34", Offset = "0x226EF34", VA = "0x226EF34", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B701")]
	[Address(RVA = "0x226EFF8", Offset = "0x226EFF8", VA = "0x226EFF8")]
	private void InitCommonWidget()
	{
	}

	[Token(Token = "0x600B702")]
	[Address(RVA = "0x226F160", Offset = "0x226F160", VA = "0x226F160", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B703")]
	[Address(RVA = "0x226F2CC", Offset = "0x226F2CC", VA = "0x226F2CC", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B704")]
	[Address(RVA = "0x226F8CC", Offset = "0x226F8CC", VA = "0x226F8CC", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B705")]
	[Address(RVA = "0x226FB18", Offset = "0x226FB18", VA = "0x226FB18", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B706")]
	[Address(RVA = "0x226FD90", Offset = "0x226FD90", VA = "0x226FD90", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B707")]
	[Address(RVA = "0x227001C", Offset = "0x227001C", VA = "0x227001C", Slot = "48")]
	protected override void OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B708")]
	[Address(RVA = "0x227010C", Offset = "0x227010C", VA = "0x227010C", Slot = "49")]
	protected override void OnFinishToggleMove()
	{
	}

	[Token(Token = "0x600B709")]
	[Address(RVA = "0x227021C", Offset = "0x227021C", VA = "0x227021C")]
	public void HideEffect()
	{
	}

	[Token(Token = "0x600B70A")]
	[Address(RVA = "0x2270304", Offset = "0x2270304", VA = "0x2270304")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B70B")]
	[Address(RVA = "0x227030C", Offset = "0x227030C", VA = "0x227030C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B70C")]
	[Address(RVA = "0x2270314", Offset = "0x2270314", VA = "0x2270314")]
	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B70D")]
	[Address(RVA = "0x227031C", Offset = "0x227031C", VA = "0x227031C")]
	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B70E")]
	[Address(RVA = "0x2270324", Offset = "0x2270324", VA = "0x2270324")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B70F")]
	[Address(RVA = "0x2270328", Offset = "0x2270328", VA = "0x2270328")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B710")]
	[Address(RVA = "0x227032C", Offset = "0x227032C", VA = "0x227032C")]
	public new void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B711")]
	[Address(RVA = "0x2270334", Offset = "0x2270334", VA = "0x2270334")]
	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B712")]
	[Address(RVA = "0x2270338", Offset = "0x2270338", VA = "0x2270338")]
	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
