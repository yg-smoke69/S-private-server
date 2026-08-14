using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021D2")]
public class UIMallBoxItemController : UIMallCDNItemController
{
	[Token(Token = "0x400D370")]
	[FieldOffset(Offset = "0x138")]
	private UIMallBoxItemView m_View;

	[Token(Token = "0x400D371")]
	[FieldOffset(Offset = "0x13C")]
	private StoreDesc m_Info;

	[Token(Token = "0x600B51D")]
	[Address(RVA = "0x2396C90", Offset = "0x2396C90", VA = "0x2396C90")]
	public UIMallBoxItemController()
	{
	}

	[Token(Token = "0x600B51E")]
	[Address(RVA = "0x2396CC0", Offset = "0x2396CC0", VA = "0x2396CC0", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B51F")]
	[Address(RVA = "0x2396D1C", Offset = "0x2396D1C", VA = "0x2396D1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B520")]
	[Address(RVA = "0x2396DC0", Offset = "0x2396DC0", VA = "0x2396DC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B521")]
	[Address(RVA = "0x2396E80", Offset = "0x2396E80", VA = "0x2396E80")]
	private void InitCommonWidget()
	{
	}

	[Token(Token = "0x600B522")]
	[Address(RVA = "0x2397114", Offset = "0x2397114", VA = "0x2397114", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B523")]
	[Address(RVA = "0x2397D60", Offset = "0x2397D60", VA = "0x2397D60", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B524")]
	[Address(RVA = "0x23980B4", Offset = "0x23980B4", VA = "0x23980B4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B525")]
	[Address(RVA = "0x23982A8", Offset = "0x23982A8", VA = "0x23982A8", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B526")]
	[Address(RVA = "0x23984F8", Offset = "0x23984F8", VA = "0x23984F8", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B527")]
	[Address(RVA = "0x2398774", Offset = "0x2398774", VA = "0x2398774", Slot = "48")]
	protected override void OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B528")]
	[Address(RVA = "0x2398810", Offset = "0x2398810", VA = "0x2398810", Slot = "49")]
	protected override void OnFinishToggleMove()
	{
	}

	[Token(Token = "0x600B529")]
	[Address(RVA = "0x23988AC", Offset = "0x23988AC", VA = "0x23988AC")]
	public void HideEffect()
	{
	}

	[Token(Token = "0x600B52A")]
	[Address(RVA = "0x239893C", Offset = "0x239893C", VA = "0x239893C")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B52B")]
	[Address(RVA = "0x2398944", Offset = "0x2398944", VA = "0x2398944")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B52C")]
	[Address(RVA = "0x2398948", Offset = "0x2398948", VA = "0x2398948")]
	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B52D")]
	[Address(RVA = "0x239894C", Offset = "0x239894C", VA = "0x239894C")]
	public new void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B52E")]
	[Address(RVA = "0x2398950", Offset = "0x2398950", VA = "0x2398950")]
	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B52F")]
	[Address(RVA = "0x2398954", Offset = "0x2398954", VA = "0x2398954")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B530")]
	[Address(RVA = "0x239895C", Offset = "0x239895C", VA = "0x239895C")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B531")]
	[Address(RVA = "0x2398964", Offset = "0x2398964", VA = "0x2398964")]
	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B532")]
	[Address(RVA = "0x239896C", Offset = "0x239896C", VA = "0x239896C")]
	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
