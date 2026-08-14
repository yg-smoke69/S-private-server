using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002007")]
internal class UIChampionshipGameResultItemController : UIEasyListItemController
{
	[Token(Token = "0x400C942")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipGameResultItemView m_View;

	[Token(Token = "0x600A1DF")]
	[Address(RVA = "0x2829730", Offset = "0x2829730", VA = "0x2829730")]
	public UIChampionshipGameResultItemController()
	{
	}

	[Token(Token = "0x600A1E0")]
	[Address(RVA = "0x2829738", Offset = "0x2829738", VA = "0x2829738")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A1E1")]
	[Address(RVA = "0x28297E0", Offset = "0x28297E0", VA = "0x28297E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A1E2")]
	[Address(RVA = "0x282989C", Offset = "0x282989C", VA = "0x282989C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A1E3")]
	[Address(RVA = "0x282990C", Offset = "0x282990C", VA = "0x282990C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
