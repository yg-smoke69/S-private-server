using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200299A")]
internal class UIMapMarkController : UIBaseController
{
	[Token(Token = "0x401000A")]
	[FieldOffset(Offset = "0x28")]
	private UIMapMarkView m_View;

	[Token(Token = "0x6010B57")]
	[Address(RVA = "0x28019AC", Offset = "0x28019AC", VA = "0x28019AC")]
	public UIMapMarkController()
	{
	}

	[Token(Token = "0x6010B58")]
	[Address(RVA = "0x2801A30", Offset = "0x2801A30", VA = "0x2801A30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B59")]
	[Address(RVA = "0x2801AD4", Offset = "0x2801AD4", VA = "0x2801AD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B5A")]
	[Address(RVA = "0x2801B90", Offset = "0x2801B90", VA = "0x2801B90", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010B5B")]
	[Address(RVA = "0x2801BF4", Offset = "0x2801BF4", VA = "0x2801BF4")]
	public void SetMarkColor(int teamIndex)
	{
	}

	[Token(Token = "0x6010B5C")]
	[Address(RVA = "0x2801D1C", Offset = "0x2801D1C", VA = "0x2801D1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B5D")]
	[Address(RVA = "0x2801D24", Offset = "0x2801D24", VA = "0x2801D24")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
