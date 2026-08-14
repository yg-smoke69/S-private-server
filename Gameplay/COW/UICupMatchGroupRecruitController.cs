using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200206F")]
public class UICupMatchGroupRecruitController : UIPopupWindowController
{
	[Token(Token = "0x400CB64")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipChatRecruitView m_View;

	[Token(Token = "0x400CB65")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x400CB66")]
	[FieldOffset(Offset = "0x50")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB67")]
	[FieldOffset(Offset = "0x54")]
	private StringBuilder m_Builder;

	[Token(Token = "0x400CB68")]
	[FieldOffset(Offset = "0x58")]
	private bool m_LastInCDState;

	[Token(Token = "0x400CB69")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_WorldDelayCallID;

	[Token(Token = "0x400CB6A")]
	[FieldOffset(Offset = "0x60")]
	private readonly float GREY_ALPHA;

	[Token(Token = "0x400CB6B")]
	[FieldOffset(Offset = "0x64")]
	private uint m_CupMatchType;

	[Token(Token = "0x400CB6C")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CupMatchID;

	[Token(Token = "0x600A657")]
	[Address(RVA = "0x2AA33A0", Offset = "0x2AA33A0", VA = "0x2AA33A0")]
	public UICupMatchGroupRecruitController()
	{
	}

	[Token(Token = "0x600A658")]
	[Address(RVA = "0x2AA3428", Offset = "0x2AA3428", VA = "0x2AA3428")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A659")]
	[Address(RVA = "0x2AA34CC", Offset = "0x2AA34CC", VA = "0x2AA34CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A65A")]
	[Address(RVA = "0x2AA4554", Offset = "0x2AA4554", VA = "0x2AA4554", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600A65B")]
	[Address(RVA = "0x2AA45B8", Offset = "0x2AA45B8", VA = "0x2AA45B8")]
	public void SetCupMatchInfo(uint type, uint id)
	{
	}

	[Token(Token = "0x600A65C")]
	[Address(RVA = "0x2AA47A0", Offset = "0x2AA47A0", VA = "0x2AA47A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A65D")]
	[Address(RVA = "0x2AA3B80", Offset = "0x2AA3B80", VA = "0x2AA3B80")]
	private void DefaultWorldState()
	{
	}

	[Token(Token = "0x600A65E")]
	[Address(RVA = "0x2AA3D94", Offset = "0x2AA3D94", VA = "0x2AA3D94")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600A65F")]
	[Address(RVA = "0x2AA48BC", Offset = "0x2AA48BC", VA = "0x2AA48BC")]
	private void OnSendClick()
	{
	}

	[Token(Token = "0x600A660")]
	[Address(RVA = "0x2AA4240", Offset = "0x2AA4240", VA = "0x2AA4240")]
	private void OnChannelToggleChange()
	{
	}

	[Token(Token = "0x600A661")]
	[Address(RVA = "0x2AA4D60", Offset = "0x2AA4D60", VA = "0x2AA4D60")]
	private bool CheckSendToValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600A662")]
	[Address(RVA = "0x2AA4E2C", Offset = "0x2AA4E2C", VA = "0x2AA4E2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A663")]
	[Address(RVA = "0x2AA4E34", Offset = "0x2AA4E34", VA = "0x2AA4E34")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600A664")]
	[Address(RVA = "0x2AA4E3C", Offset = "0x2AA4E3C", VA = "0x2AA4E3C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
