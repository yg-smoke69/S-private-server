using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FFB")]
public class UIChampionshipChannelPopupController : UIPopupWindowController
{
	[Token(Token = "0x400C8F1")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipChannelPopupView m_View;

	[Token(Token = "0x600A160")]
	[Address(RVA = "0x145DA60", Offset = "0x145DA60", VA = "0x145DA60")]
	public UIChampionshipChannelPopupController()
	{
	}

	[Token(Token = "0x600A161")]
	[Address(RVA = "0x145DA68", Offset = "0x145DA68", VA = "0x145DA68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A162")]
	[Address(RVA = "0x145DB10", Offset = "0x145DB10", VA = "0x145DB10", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A163")]
	[Address(RVA = "0x145DF8C", Offset = "0x145DF8C", VA = "0x145DF8C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A164")]
	[Address(RVA = "0x145DC68", Offset = "0x145DC68", VA = "0x145DC68")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A165")]
	[Address(RVA = "0x145E0C0", Offset = "0x145E0C0", VA = "0x145E0C0")]
	private void ChannelSelectHandler(object[] param)
	{
	}

	[Token(Token = "0x600A166")]
	[Address(RVA = "0x145E12C", Offset = "0x145E12C", VA = "0x145E12C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A167")]
	[Address(RVA = "0x145E134", Offset = "0x145E134", VA = "0x145E134")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
