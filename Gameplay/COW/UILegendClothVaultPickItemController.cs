using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002906")]
public class UILegendClothVaultPickItemController : UIBaseController
{
	[Token(Token = "0x400FCA1")]
	[FieldOffset(Offset = "0x28")]
	private UIModelAvatarProfile m_AvatarProfileModel;

	[Token(Token = "0x400FCA2")]
	[FieldOffset(Offset = "0x2C")]
	private UILegendClothVaultPickItemView m_View;

	[Token(Token = "0x400FCA3")]
	[FieldOffset(Offset = "0x30")]
	private uint m_LegendId;

	[Token(Token = "0x400FCA4")]
	[FieldOffset(Offset = "0x34")]
	private GoPos goPosData;

	[Token(Token = "0x6010405")]
	[Address(RVA = "0x2540758", Offset = "0x2540758", VA = "0x2540758")]
	public UILegendClothVaultPickItemController()
	{
	}

	[Token(Token = "0x6010406")]
	[Address(RVA = "0x25407DC", Offset = "0x25407DC", VA = "0x25407DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010407")]
	[Address(RVA = "0x2540880", Offset = "0x2540880", VA = "0x2540880", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010408")]
	[Address(RVA = "0x253FF44", Offset = "0x253FF44", VA = "0x253FF44")]
	public void SetData(uint legendId)
	{
	}

	[Token(Token = "0x6010409")]
	[Address(RVA = "0x2540AC0", Offset = "0x2540AC0", VA = "0x2540AC0")]
	private void OnClickBtnGoPos()
	{
	}

	[Token(Token = "0x601040A")]
	[Address(RVA = "0x2540C34", Offset = "0x2540C34", VA = "0x2540C34")]
	private void OnClickBtnPick()
	{
	}

	[Token(Token = "0x601040B")]
	[Address(RVA = "0x2540F80", Offset = "0x2540F80", VA = "0x2540F80")]
	private bool _003CSetData_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x601040C")]
	[Address(RVA = "0x2540FB8", Offset = "0x2540FB8", VA = "0x2540FB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
