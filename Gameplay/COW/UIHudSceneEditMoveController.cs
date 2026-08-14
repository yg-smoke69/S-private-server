using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200233E")]
internal class UIHudSceneEditMoveController : UIBaseController
{
	[Token(Token = "0x400DB90")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditMoveView m_View;

	[Token(Token = "0x400DB91")]
	[FieldOffset(Offset = "0x2C")]
	private SceneEditAgent m_TargetAgent;

	[Token(Token = "0x400DB92")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasPushBtton;

	[Token(Token = "0x400DB93")]
	[FieldOffset(Offset = "0x34")]
	private float m_PushButtonTime;

	[Token(Token = "0x600C3DA")]
	[Address(RVA = "0x24E63A0", Offset = "0x24E63A0", VA = "0x24E63A0")]
	public UIHudSceneEditMoveController()
	{
	}

	[Token(Token = "0x600C3DB")]
	[Address(RVA = "0x24E6424", Offset = "0x24E6424", VA = "0x24E6424")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C3DC")]
	[Address(RVA = "0x24E64CC", Offset = "0x24E64CC", VA = "0x24E64CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C3DD")]
	[Address(RVA = "0x24E6A38", Offset = "0x24E6A38", VA = "0x24E6A38", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C3DE")]
	[Address(RVA = "0x24E6B94", Offset = "0x24E6B94", VA = "0x24E6B94")]
	public void Update()
	{
	}

	[Token(Token = "0x600C3DF")]
	[Address(RVA = "0x24E6E70", Offset = "0x24E6E70", VA = "0x24E6E70")]
	private void OnHandleAgentCreate(object[] data)
	{
	}

	[Token(Token = "0x600C3E0")]
	[Address(RVA = "0x24E6F44", Offset = "0x24E6F44", VA = "0x24E6F44")]
	private void OnShowMove(object[] data)
	{
	}

	[Token(Token = "0x600C3E1")]
	[Address(RVA = "0x24E70D8", Offset = "0x24E70D8", VA = "0x24E70D8")]
	private void OnBtnUpClick()
	{
	}

	[Token(Token = "0x600C3E2")]
	[Address(RVA = "0x24E71E8", Offset = "0x24E71E8", VA = "0x24E71E8")]
	private void OnBtnLeftClick()
	{
	}

	[Token(Token = "0x600C3E3")]
	[Address(RVA = "0x24E72F8", Offset = "0x24E72F8", VA = "0x24E72F8")]
	private void OnBtnRightClick()
	{
	}

	[Token(Token = "0x600C3E4")]
	[Address(RVA = "0x24E7408", Offset = "0x24E7408", VA = "0x24E7408")]
	private void OnBtnDownClick()
	{
	}

	[Token(Token = "0x600C3E5")]
	[Address(RVA = "0x24E7518", Offset = "0x24E7518", VA = "0x24E7518")]
	private void _003COnUIInit_003Em__0(bool press)
	{
	}

	[Token(Token = "0x600C3E6")]
	[Address(RVA = "0x24E7528", Offset = "0x24E7528", VA = "0x24E7528")]
	private void _003COnUIInit_003Em__1(bool press)
	{
	}

	[Token(Token = "0x600C3E7")]
	[Address(RVA = "0x24E7538", Offset = "0x24E7538", VA = "0x24E7538")]
	private void _003COnUIInit_003Em__2(bool press)
	{
	}

	[Token(Token = "0x600C3E8")]
	[Address(RVA = "0x24E7548", Offset = "0x24E7548", VA = "0x24E7548")]
	private void _003COnUIInit_003Em__3(bool press)
	{
	}

	[Token(Token = "0x600C3E9")]
	[Address(RVA = "0x24E7558", Offset = "0x24E7558", VA = "0x24E7558")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C3EA")]
	[Address(RVA = "0x24E7560", Offset = "0x24E7560", VA = "0x24E7560")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
