using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FFA")]
public class UIChampionshipChannelItemController : UIBaseController
{
	[Token(Token = "0x400C8EF")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipChannelItemView m_View;

	[Token(Token = "0x400C8F0")]
	[FieldOffset(Offset = "0x2C")]
	private ChampionshipChannelData m_ChannelData;

	[Token(Token = "0x600A159")]
	[Address(RVA = "0x145D2D8", Offset = "0x145D2D8", VA = "0x145D2D8")]
	public UIChampionshipChannelItemController()
	{
	}

	[Token(Token = "0x600A15A")]
	[Address(RVA = "0x145D35C", Offset = "0x145D35C", VA = "0x145D35C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A15B")]
	[Address(RVA = "0x145D404", Offset = "0x145D404", VA = "0x145D404", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A15C")]
	[Address(RVA = "0x145D560", Offset = "0x145D560", VA = "0x145D560")]
	public void SetData(ChampionshipChannelData data)
	{
	}

	[Token(Token = "0x600A15D")]
	[Address(RVA = "0x145D5CC", Offset = "0x145D5CC", VA = "0x145D5CC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A15E")]
	[Address(RVA = "0x145D684", Offset = "0x145D684", VA = "0x145D684")]
	private void SelectChannel()
	{
	}

	[Token(Token = "0x600A15F")]
	[Address(RVA = "0x145D840", Offset = "0x145D840", VA = "0x145D840")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
