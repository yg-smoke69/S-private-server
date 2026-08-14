using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025B3")]
public class UICreateRoomCoolDownContoller : UIPopupWindowController
{
	[Token(Token = "0x400E95F")]
	[FieldOffset(Offset = "0x48")]
	private UICreateRoomCoolDownView m_View;

	[Token(Token = "0x400E960")]
	[FieldOffset(Offset = "0x4C")]
	private float m_NextUpdateTime;

	[Token(Token = "0x400E961")]
	[FieldOffset(Offset = "0x50")]
	private int m_RestTime;

	[Token(Token = "0x400E962")]
	[FieldOffset(Offset = "0x54")]
	private string m_BaseString;

	[Token(Token = "0x600DD4B")]
	[Address(RVA = "0x27307C0", Offset = "0x27307C0", VA = "0x27307C0")]
	public UICreateRoomCoolDownContoller()
	{
	}

	[Token(Token = "0x600DD4C")]
	[Address(RVA = "0x27307C8", Offset = "0x27307C8", VA = "0x27307C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DD4D")]
	[Address(RVA = "0x273086C", Offset = "0x273086C", VA = "0x273086C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DD4E")]
	[Address(RVA = "0x2730A98", Offset = "0x2730A98", VA = "0x2730A98")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600DD4F")]
	[Address(RVA = "0x2730AFC", Offset = "0x2730AFC", VA = "0x2730AFC")]
	private void Update()
	{
	}

	[Token(Token = "0x600DD50")]
	[Address(RVA = "0x2730CF4", Offset = "0x2730CF4", VA = "0x2730CF4")]
	public void SetCoolDownTime(ulong endTime)
	{
	}

	[Token(Token = "0x600DD51")]
	[Address(RVA = "0x2730DE4", Offset = "0x2730DE4", VA = "0x2730DE4", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x600DD52")]
	[Address(RVA = "0x2730F44", Offset = "0x2730F44", VA = "0x2730F44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DD53")]
	[Address(RVA = "0x2730F4C", Offset = "0x2730F4C", VA = "0x2730F4C")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
