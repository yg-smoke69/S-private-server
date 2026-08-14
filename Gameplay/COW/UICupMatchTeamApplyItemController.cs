using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200207F")]
public class UICupMatchTeamApplyItemController : UIEasyListItemController
{
	[Token(Token = "0x2002080")]
	public enum ViewType
	{
		[Token(Token = "0x400CBC2")]
		Apply,
		[Token(Token = "0x400CBC3")]
		Invite
	}

	[Token(Token = "0x400CBBB")]
	[FieldOffset(Offset = "0x38")]
	private UICupMatchTeamApplyItemView m_View;

	[Token(Token = "0x400CBBC")]
	[FieldOffset(Offset = "0x3C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400CBBD")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCupMatch.AccountInfoBasicWithCupInfo m_ApplicantData;

	[Token(Token = "0x400CBBE")]
	[FieldOffset(Offset = "0x44")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBBF")]
	[FieldOffset(Offset = "0x48")]
	public ViewType m_ViewType;

	[Token(Token = "0x400CBC0")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CupMatchKey;

	[Token(Token = "0x600A6F0")]
	[Address(RVA = "0x2AB69A0", Offset = "0x2AB69A0", VA = "0x2AB69A0")]
	public UICupMatchTeamApplyItemController()
	{
	}

	[Token(Token = "0x600A6F1")]
	[Address(RVA = "0x2AB69A8", Offset = "0x2AB69A8", VA = "0x2AB69A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6F2")]
	[Address(RVA = "0x2AB6A50", Offset = "0x2AB6A50", VA = "0x2AB6A50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A6F3")]
	[Address(RVA = "0x2AB6DCC", Offset = "0x2AB6DCC", VA = "0x2AB6DCC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A6F4")]
	[Address(RVA = "0x2AA8880", Offset = "0x2AA8880", VA = "0x2AA8880")]
	public void SetCupMatchType(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A6F5")]
	[Address(RVA = "0x2AB7158", Offset = "0x2AB7158", VA = "0x2AB7158")]
	private void View()
	{
	}

	[Token(Token = "0x600A6F6")]
	[Address(RVA = "0x2AB736C", Offset = "0x2AB736C", VA = "0x2AB736C")]
	private void Reject()
	{
	}

	[Token(Token = "0x600A6F7")]
	[Address(RVA = "0x2AB76F4", Offset = "0x2AB76F4", VA = "0x2AB76F4")]
	private void Accept()
	{
	}

	[Token(Token = "0x600A6F8")]
	[Address(RVA = "0x2AB7E10", Offset = "0x2AB7E10", VA = "0x2AB7E10")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600A6F9")]
	[Address(RVA = "0x2AB7F1C", Offset = "0x2AB7F1C", VA = "0x2AB7F1C")]
	private void _003CAccept_003Em__0()
	{
	}

	[Token(Token = "0x600A6FA")]
	[Address(RVA = "0x2AB8018", Offset = "0x2AB8018", VA = "0x2AB8018")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
