using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F9D")]
public class UIHudArmsItemController : UIBaseController
{
	[Token(Token = "0x400C656")]
	[FieldOffset(Offset = "0x28")]
	private UIHudArmsItemView m_View;

	[Token(Token = "0x400C657")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string m_SpriteNamePrefix;

	[Token(Token = "0x400C658")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCall;

	[Token(Token = "0x6009D6A")]
	[Address(RVA = "0x17035A8", Offset = "0x17035A8", VA = "0x17035A8")]
	public UIHudArmsItemController()
	{
	}

	[Token(Token = "0x6009D6B")]
	[Address(RVA = "0x170362C", Offset = "0x170362C", VA = "0x170362C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D6C")]
	[Address(RVA = "0x17036D4", Offset = "0x17036D4", VA = "0x17036D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D6D")]
	[Address(RVA = "0x1703790", Offset = "0x1703790", VA = "0x1703790")]
	public void SetData(IJKEMPEMMDN armsInfo)
	{
	}

	[Token(Token = "0x6009D6E")]
	[Address(RVA = "0x1703BA0", Offset = "0x1703BA0", VA = "0x1703BA0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009D70")]
	[Address(RVA = "0x1703D30", Offset = "0x1703D30", VA = "0x1703D30")]
	private void _003CSetData_003Em__0()
	{
	}

	[Token(Token = "0x6009D71")]
	[Address(RVA = "0x1703E50", Offset = "0x1703E50", VA = "0x1703E50")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009D72")]
	[Address(RVA = "0x1703E58", Offset = "0x1703E58", VA = "0x1703E58")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
