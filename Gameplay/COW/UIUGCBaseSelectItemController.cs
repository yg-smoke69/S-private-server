using GCommon;
using Il2CppDummyDll;
using ReactUI;

namespace COW;

[Token(Token = "0x2002B90")]
internal class UIUGCBaseSelectItemController : UIBindItemListItemController
{
	[Token(Token = "0x4010AB1")]
	[FieldOffset(Offset = "0x40")]
	private UIVariable var_ItemIndex;

	[Token(Token = "0x4010AB2")]
	[FieldOffset(Offset = "0x44")]
	private UIVariable var_NameKey;

	[Token(Token = "0x4010AB3")]
	[FieldOffset(Offset = "0x48")]
	private UIVariable var_ResourceId;

	[Token(Token = "0x4010AB4")]
	[FieldOffset(Offset = "0x4C")]
	private UIVariable var_ShowSpriteName;

	[Token(Token = "0x4010AB5")]
	[FieldOffset(Offset = "0x50")]
	private UIVariable var_ShowCDNImage;

	[Token(Token = "0x4010AB6")]
	[FieldOffset(Offset = "0x54")]
	private UIVariable var_IsUseCDNImage;

	[Token(Token = "0x6012014")]
	[Address(RVA = "0x2B7E9F0", Offset = "0x2B7E9F0", VA = "0x2B7E9F0")]
	public UIUGCBaseSelectItemController()
	{
	}

	[Token(Token = "0x6012015")]
	[Address(RVA = "0x2B7E9F8", Offset = "0x2B7E9F8", VA = "0x2B7E9F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012016")]
	[Address(RVA = "0x2B7EAC8", Offset = "0x2B7EAC8", VA = "0x2B7EAC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012017")]
	[Address(RVA = "0x2B7EBB8", Offset = "0x2B7EBB8", VA = "0x2B7EBB8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012018")]
	[Address(RVA = "0x2B7EC1C", Offset = "0x2B7EC1C", VA = "0x2B7EC1C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6012019")]
	[Address(RVA = "0x2B7EEC8", Offset = "0x2B7EEC8", VA = "0x2B7EEC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601201A")]
	[Address(RVA = "0x2B7EED0", Offset = "0x2B7EED0", VA = "0x2B7EED0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x601201B")]
	[Address(RVA = "0x2B7EED8", Offset = "0x2B7EED8", VA = "0x2B7EED8")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
