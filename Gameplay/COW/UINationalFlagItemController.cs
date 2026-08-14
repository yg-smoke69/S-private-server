using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029D9")]
public class UINationalFlagItemController : UIEasyListItemController
{
	[Token(Token = "0x4010156")]
	[FieldOffset(Offset = "0x38")]
	private UINationalFlagItemView m_View;

	[Token(Token = "0x4010157")]
	[FieldOffset(Offset = "0x3C")]
	private NationFlagData m_FlagInfo;

	[Token(Token = "0x6010D63")]
	[Address(RVA = "0x1B300F0", Offset = "0x1B300F0", VA = "0x1B300F0")]
	public UINationalFlagItemController()
	{
	}

	[Token(Token = "0x6010D64")]
	[Address(RVA = "0x1B300F8", Offset = "0x1B300F8", VA = "0x1B300F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D65")]
	[Address(RVA = "0x1B301A0", Offset = "0x1B301A0", VA = "0x1B301A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D66")]
	[Address(RVA = "0x1B302FC", Offset = "0x1B302FC", VA = "0x1B302FC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010D67")]
	[Address(RVA = "0x1B304A0", Offset = "0x1B304A0", VA = "0x1B304A0")]
	private void SelectFlag()
	{
	}

	[Token(Token = "0x6010D68")]
	[Address(RVA = "0x1B3061C", Offset = "0x1B3061C", VA = "0x1B3061C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
