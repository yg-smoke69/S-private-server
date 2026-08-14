using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002ACA")]
internal class UIRelationshipMsgDetailWndController : UIPopupWindowController
{
	[Token(Token = "0x40106DD")]
	[FieldOffset(Offset = "0x48")]
	private UIRelationshipMsgDetailWndView m_View;

	[Token(Token = "0x40106DE")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelRelationShip modelRelationShip;

	[Token(Token = "0x40106DF")]
	[FieldOffset(Offset = "0x50")]
	private RelationshipMessageInfo m_RelationMsgInfo;

	[Token(Token = "0x40106E0")]
	[FieldOffset(Offset = "0x54")]
	private uint m_delayCall;

	[Token(Token = "0x40106E1")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_SendMsgAccountId;

	[Token(Token = "0x6011886")]
	[Address(RVA = "0x1E4EA5C", Offset = "0x1E4EA5C", VA = "0x1E4EA5C")]
	public UIRelationshipMsgDetailWndController()
	{
	}

	[Token(Token = "0x6011887")]
	[Address(RVA = "0x1E4EA64", Offset = "0x1E4EA64", VA = "0x1E4EA64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011888")]
	[Address(RVA = "0x1E4ED64", Offset = "0x1E4ED64", VA = "0x1E4ED64")]
	private void CloseMsgDetailWnd(object[] param)
	{
	}

	[Token(Token = "0x6011889")]
	[Address(RVA = "0x1E4EEE8", Offset = "0x1E4EEE8", VA = "0x1E4EEE8", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x601188A")]
	[Address(RVA = "0x1E4EF4C", Offset = "0x1E4EF4C", VA = "0x1E4EF4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601188B")]
	[Address(RVA = "0x1E4A738", Offset = "0x1E4A738", VA = "0x1E4A738")]
	public void SetUIData(RelationshipMessageInfo reInfo, string CDNUrl)
	{
	}

	[Token(Token = "0x601188C")]
	[Address(RVA = "0x1E4EFF0", Offset = "0x1E4EFF0", VA = "0x1E4EFF0")]
	public void SetUIData(RelationshipInfo reInfo, string CDNUrl)
	{
	}

	[Token(Token = "0x601188D")]
	[Address(RVA = "0x1E4F5B4", Offset = "0x1E4F5B4", VA = "0x1E4F5B4")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x601188E")]
	[Address(RVA = "0x1E4F618", Offset = "0x1E4F618", VA = "0x1E4F618", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601188F")]
	[Address(RVA = "0x1E4F720", Offset = "0x1E4F720", VA = "0x1E4F720")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x6011890")]
	[Address(RVA = "0x1E4F83C", Offset = "0x1E4F83C", VA = "0x1E4F83C")]
	private void OnClickRefuce()
	{
	}

	[Token(Token = "0x6011891")]
	[Address(RVA = "0x1E4F958", Offset = "0x1E4F958", VA = "0x1E4F958")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011892")]
	[Address(RVA = "0x1E4F960", Offset = "0x1E4F960", VA = "0x1E4F960")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6011893")]
	[Address(RVA = "0x1E4F968", Offset = "0x1E4F968", VA = "0x1E4F968")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
