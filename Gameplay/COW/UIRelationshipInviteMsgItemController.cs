using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AC6")]
internal class UIRelationshipInviteMsgItemController : UIEasyListItemController
{
	[Token(Token = "0x40106D4")]
	[FieldOffset(Offset = "0x38")]
	private UIRelationshipInviteMsgItemView m_View;

	[Token(Token = "0x40106D5")]
	[FieldOffset(Offset = "0x3C")]
	private RelationshipMessageInfo m_info;

	[Token(Token = "0x40106D6")]
	[FieldOffset(Offset = "0x40")]
	private UIBaseProfileInfoController m_baseInfo;

	[Token(Token = "0x601185B")]
	[Address(RVA = "0x1E49F58", Offset = "0x1E49F58", VA = "0x1E49F58")]
	public UIRelationshipInviteMsgItemController()
	{
	}

	[Token(Token = "0x601185C")]
	[Address(RVA = "0x1E49F60", Offset = "0x1E49F60", VA = "0x1E49F60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601185D")]
	[Address(RVA = "0x1E4A0BC", Offset = "0x1E4A0BC", VA = "0x1E4A0BC", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x601185E")]
	[Address(RVA = "0x1E4A120", Offset = "0x1E4A120", VA = "0x1E4A120")]
	private void Update()
	{
	}

	[Token(Token = "0x601185F")]
	[Address(RVA = "0x1E4A378", Offset = "0x1E4A378", VA = "0x1E4A378")]
	private void ShowMsgDetailWindow()
	{
	}

	[Token(Token = "0x6011860")]
	[Address(RVA = "0x1E4AB80", Offset = "0x1E4AB80", VA = "0x1E4AB80")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011861")]
	[Address(RVA = "0x1E4AC24", Offset = "0x1E4AC24", VA = "0x1E4AC24", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011862")]
	[Address(RVA = "0x1E4AE9C", Offset = "0x1E4AE9C", VA = "0x1E4AE9C")]
	private void RefreshMsgInfo()
	{
	}

	[Token(Token = "0x6011863")]
	[Address(RVA = "0x1E4B730", Offset = "0x1E4B730", VA = "0x1E4B730")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011864")]
	[Address(RVA = "0x1E4B738", Offset = "0x1E4B738", VA = "0x1E4B738")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
