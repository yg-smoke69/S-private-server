using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200201C")]
public class UIChampionshipTeamApplyItemController : UIEasyListItemController
{
	[Token(Token = "0x200201D")]
	public enum ViewType
	{
		[Token(Token = "0x400C9A9")]
		Apply,
		[Token(Token = "0x400C9AA")]
		Invite
	}

	[Token(Token = "0x400C9A2")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipTeamApplyItemView m_View;

	[Token(Token = "0x400C9A3")]
	[FieldOffset(Offset = "0x3C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400C9A4")]
	[FieldOffset(Offset = "0x40")]
	private AccountInfoBasic m_ApplicantData;

	[Token(Token = "0x400C9A5")]
	[FieldOffset(Offset = "0x44")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9A6")]
	[FieldOffset(Offset = "0x48")]
	public ViewType m_ViewType;

	[Token(Token = "0x400C9A7")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_ChampionshipType;

	[Token(Token = "0x600A28E")]
	[Address(RVA = "0x283AB34", Offset = "0x283AB34", VA = "0x283AB34")]
	public UIChampionshipTeamApplyItemController()
	{
	}

	[Token(Token = "0x600A28F")]
	[Address(RVA = "0x283AB3C", Offset = "0x283AB3C", VA = "0x283AB3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A290")]
	[Address(RVA = "0x283ABE0", Offset = "0x283ABE0", VA = "0x283ABE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A291")]
	[Address(RVA = "0x283AF2C", Offset = "0x283AF2C", VA = "0x283AF2C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A292")]
	[Address(RVA = "0x2832B40", Offset = "0x2832B40", VA = "0x2832B40")]
	public void SetChampionshipType(uint championshipType)
	{
	}

	[Token(Token = "0x600A293")]
	[Address(RVA = "0x283B0C8", Offset = "0x283B0C8", VA = "0x283B0C8")]
	private void View()
	{
	}

	[Token(Token = "0x600A294")]
	[Address(RVA = "0x283B208", Offset = "0x283B208", VA = "0x283B208")]
	private void Reject()
	{
	}

	[Token(Token = "0x600A295")]
	[Address(RVA = "0x283B3E4", Offset = "0x283B3E4", VA = "0x283B3E4")]
	private void Accept()
	{
	}

	[Token(Token = "0x600A296")]
	[Address(RVA = "0x283B9D8", Offset = "0x283B9D8", VA = "0x283B9D8")]
	private void _003CAccept_003Em__0()
	{
	}

	[Token(Token = "0x600A297")]
	[Address(RVA = "0x283BAB4", Offset = "0x283BAB4", VA = "0x283BAB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
