using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B8F")]
public class UITutorRecruitPopWndController : UIPopupWindowController
{
	[Token(Token = "0x4010AA1")]
	[FieldOffset(Offset = "0x48")]
	private UITutorRecruitView m_View;

	[Token(Token = "0x4010AA2")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x4010AA3")]
	[FieldOffset(Offset = "0x50")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010AA4")]
	[FieldOffset(Offset = "0x54")]
	private StringBuilder m_Builder;

	[Token(Token = "0x4010AA5")]
	[FieldOffset(Offset = "0x58")]
	private StringBuilder m_TutorBuilder;

	[Token(Token = "0x4010AA6")]
	[FieldOffset(Offset = "0x5C")]
	private string m_Declaration;

	[Token(Token = "0x4010AA7")]
	[FieldOffset(Offset = "0x60")]
	private uint m_WorldDelayCallID;

	[Token(Token = "0x4010AA8")]
	[FieldOffset(Offset = "0x64")]
	private readonly float GREY_ALPHA;

	[Token(Token = "0x4010AA9")]
	[FieldOffset(Offset = "0x68")]
	private bool m_LastWorldInCDState;

	[Token(Token = "0x4010AAA")]
	[FieldOffset(Offset = "0x69")]
	private bool m_LastTutorInCDState;

	[Token(Token = "0x4010AAB")]
	[FieldOffset(Offset = "0x6A")]
	private bool m_IsWorldChannelJoined;

	[Token(Token = "0x4010AAC")]
	[FieldOffset(Offset = "0x6B")]
	private bool m_IsMentoringChannelJoined;

	[Token(Token = "0x4010AAD")]
	[FieldOffset(Offset = "0x70")]
	private ulong m_MentorUnlockTimeStamp;

	[Token(Token = "0x4010AAE")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_WorldUnlockTimeStamp;

	[Token(Token = "0x4010AAF")]
	[FieldOffset(Offset = "0x80")]
	private ulong m_CurrentTimeStamp;

	[Token(Token = "0x4010AB0")]
	[FieldOffset(Offset = "0x88")]
	private string m_SendBtnLabelText;

	[Token(Token = "0x6011FFF")]
	[Address(RVA = "0x1C35F0C", Offset = "0x1C35F0C", VA = "0x1C35F0C")]
	public UITutorRecruitPopWndController()
	{
	}

	[Token(Token = "0x6012000")]
	[Address(RVA = "0x1C35FAC", Offset = "0x1C35FAC", VA = "0x1C35FAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012001")]
	[Address(RVA = "0x1C36050", Offset = "0x1C36050", VA = "0x1C36050", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012002")]
	[Address(RVA = "0x1C36950", Offset = "0x1C36950", VA = "0x1C36950")]
	private void InitWorldToggle()
	{
	}

	[Token(Token = "0x6012003")]
	[Address(RVA = "0x1C36C54", Offset = "0x1C36C54", VA = "0x1C36C54")]
	private void InitClanToggle()
	{
	}

	[Token(Token = "0x6012004")]
	[Address(RVA = "0x1C36EC4", Offset = "0x1C36EC4", VA = "0x1C36EC4")]
	private void InitTutorToggle()
	{
	}

	[Token(Token = "0x6012005")]
	[Address(RVA = "0x1C37E50", Offset = "0x1C37E50", VA = "0x1C37E50")]
	private void DefaultWorldState()
	{
	}

	[Token(Token = "0x6012006")]
	[Address(RVA = "0x1C380B8", Offset = "0x1C380B8", VA = "0x1C380B8")]
	private void DefaultTutorState()
	{
	}

	[Token(Token = "0x6012007")]
	[Address(RVA = "0x1C370A4", Offset = "0x1C370A4", VA = "0x1C370A4")]
	private void UpdateSendChannelView()
	{
	}

	[Token(Token = "0x6012008")]
	[Address(RVA = "0x1C38410", Offset = "0x1C38410", VA = "0x1C38410")]
	private void OnEditBtnClick()
	{
	}

	[Token(Token = "0x6012009")]
	[Address(RVA = "0x1C38464", Offset = "0x1C38464", VA = "0x1C38464", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601200A")]
	[Address(RVA = "0x1C38580", Offset = "0x1C38580", VA = "0x1C38580")]
	private void OnGreyButtonClick()
	{
	}

	[Token(Token = "0x601200B")]
	[Address(RVA = "0x1C38890", Offset = "0x1C38890", VA = "0x1C38890")]
	private void OnSendClick()
	{
	}

	[Token(Token = "0x601200C")]
	[Address(RVA = "0x1C39594", Offset = "0x1C39594", VA = "0x1C39594")]
	private void OnChannelWorldToggleChange()
	{
	}

	[Token(Token = "0x601200D")]
	[Address(RVA = "0x1C39654", Offset = "0x1C39654", VA = "0x1C39654")]
	private void OnChannelClanToggleChange()
	{
	}

	[Token(Token = "0x601200E")]
	[Address(RVA = "0x1C396B4", Offset = "0x1C396B4", VA = "0x1C396B4")]
	private void OnTutorToggleChange()
	{
	}

	[Token(Token = "0x601200F")]
	[Address(RVA = "0x1C38304", Offset = "0x1C38304", VA = "0x1C38304")]
	private bool CheckSendToValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6012010")]
	[Address(RVA = "0x1C39714", Offset = "0x1C39714", VA = "0x1C39714")]
	private void OnChannelMentorToggleChangeWithTips()
	{
	}

	[Token(Token = "0x6012011")]
	[Address(RVA = "0x1C395F4", Offset = "0x1C395F4", VA = "0x1C395F4")]
	private void OnChannelWorldToggleChangeWithTips()
	{
	}

	[Token(Token = "0x6012012")]
	[Address(RVA = "0x1C39774", Offset = "0x1C39774", VA = "0x1C39774")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012013")]
	[Address(RVA = "0x1C3977C", Offset = "0x1C3977C", VA = "0x1C3977C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
