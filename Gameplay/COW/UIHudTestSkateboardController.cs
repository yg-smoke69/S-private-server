using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200287C")]
public class UIHudTestSkateboardController : UIBaseController
{
	[Token(Token = "0x400F97D")]
	[FieldOffset(Offset = "0x28")]
	public UIHudTestSkateBoardView m_View;

	[Token(Token = "0x400F97E")]
	[FieldOffset(Offset = "0x2C")]
	public UIHudTestSkateboardEasyList EasyListCallback;

	[Token(Token = "0x400F97F")]
	[FieldOffset(Offset = "0x30")]
	public UIHudTestSkateboardEasyList SearchEasyListCallback;

	[Token(Token = "0x400F980")]
	[FieldOffset(Offset = "0x34")]
	private UIHudTestSkateboardBtn mLastSelectedItem;

	[Token(Token = "0x600FDDC")]
	[Address(RVA = "0x157AE90", Offset = "0x157AE90", VA = "0x157AE90")]
	public UIHudTestSkateboardController()
	{
	}

	[Token(Token = "0x600FDDD")]
	[Address(RVA = "0x157AF14", Offset = "0x157AF14", VA = "0x157AF14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FDDE")]
	[Address(RVA = "0x157AFBC", Offset = "0x157AFBC", VA = "0x157AFBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FDDF")]
	[Address(RVA = "0x157B894", Offset = "0x157B894", VA = "0x157B894", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FDE0")]
	[Address(RVA = "0x157B484", Offset = "0x157B484", VA = "0x157B484")]
	private void InitAvatarGrid()
	{
	}

	[Token(Token = "0x600FDE1")]
	[Address(RVA = "0x157B9C8", Offset = "0x157B9C8", VA = "0x157B9C8")]
	private void OnDeubgToggle()
	{
	}

	[Token(Token = "0x600FDE2")]
	[Address(RVA = "0x157B774", Offset = "0x157B774", VA = "0x157B774")]
	private void OnShowDebugUI(object[] param)
	{
	}

	[Token(Token = "0x600FDE3")]
	[Address(RVA = "0x157BA98", Offset = "0x157BA98", VA = "0x157BA98")]
	private void OnSearchInputChanged()
	{
	}

	[Token(Token = "0x600FDE4")]
	[Address(RVA = "0x157A9F4", Offset = "0x157A9F4", VA = "0x157A9F4")]
	public void OnItemBtnClicked(UIHudTestSkateboardBtn itemBtn, bool isSearch)
	{
	}

	[Token(Token = "0x600FDE5")]
	[Address(RVA = "0x157C0D4", Offset = "0x157C0D4", VA = "0x157C0D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FDE6")]
	[Address(RVA = "0x157C0DC", Offset = "0x157C0DC", VA = "0x157C0DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
