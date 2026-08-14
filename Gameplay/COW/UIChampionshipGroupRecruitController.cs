using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200200A")]
public class UIChampionshipGroupRecruitController : UIPopupWindowController
{
	[Token(Token = "0x400C94D")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipChatRecruitView m_View;

	[Token(Token = "0x400C94E")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x400C94F")]
	[FieldOffset(Offset = "0x50")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C950")]
	[FieldOffset(Offset = "0x54")]
	private StringBuilder m_Builder;

	[Token(Token = "0x400C951")]
	[FieldOffset(Offset = "0x58")]
	private bool m_LastInCDState;

	[Token(Token = "0x400C952")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_WorldDelayCallID;

	[Token(Token = "0x400C953")]
	[FieldOffset(Offset = "0x60")]
	private readonly float GREY_ALPHA;

	[Token(Token = "0x400C954")]
	[FieldOffset(Offset = "0x64")]
	private uint m_ChampionshipType;

	[Token(Token = "0x400C955")]
	[FieldOffset(Offset = "0x68")]
	private uint m_ChampionshipID;

	[Token(Token = "0x600A1FE")]
	[Address(RVA = "0x282C938", Offset = "0x282C938", VA = "0x282C938")]
	public UIChampionshipGroupRecruitController()
	{
	}

	[Token(Token = "0x600A1FF")]
	[Address(RVA = "0x282C9C0", Offset = "0x282C9C0", VA = "0x282C9C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A200")]
	[Address(RVA = "0x282CA64", Offset = "0x282CA64", VA = "0x282CA64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A201")]
	[Address(RVA = "0x282DAEC", Offset = "0x282DAEC", VA = "0x282DAEC")]
	public void SetChampionshipInfo(uint type, uint id)
	{
	}

	[Token(Token = "0x600A202")]
	[Address(RVA = "0x282DCD8", Offset = "0x282DCD8", VA = "0x282DCD8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A203")]
	[Address(RVA = "0x282D118", Offset = "0x282D118", VA = "0x282D118")]
	private void DefaultWorldState()
	{
	}

	[Token(Token = "0x600A204")]
	[Address(RVA = "0x282D32C", Offset = "0x282D32C", VA = "0x282D32C")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600A205")]
	[Address(RVA = "0x282DDF4", Offset = "0x282DDF4", VA = "0x282DDF4")]
	private void OnSendClick()
	{
	}

	[Token(Token = "0x600A206")]
	[Address(RVA = "0x282D7D8", Offset = "0x282D7D8", VA = "0x282D7D8")]
	private void OnChannelToggleChange()
	{
	}

	[Token(Token = "0x600A207")]
	[Address(RVA = "0x282E298", Offset = "0x282E298", VA = "0x282E298")]
	private bool CheckSendToValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600A208")]
	[Address(RVA = "0x282E364", Offset = "0x282E364", VA = "0x282E364")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A209")]
	[Address(RVA = "0x282E36C", Offset = "0x282E36C", VA = "0x282E36C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
