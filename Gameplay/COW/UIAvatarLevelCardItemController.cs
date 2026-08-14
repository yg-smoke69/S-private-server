using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A8")]
public class UIAvatarLevelCardItemController : UIBaseController
{
	[Token(Token = "0x400E325")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarLevelCardItemView m_View;

	[Token(Token = "0x400E326")]
	[FieldOffset(Offset = "0x2C")]
	private AvatarLevelUpCard m_CardItem;

	[Token(Token = "0x600D1D0")]
	[Address(RVA = "0x2A802B0", Offset = "0x2A802B0", VA = "0x2A802B0")]
	public UIAvatarLevelCardItemController()
	{
	}

	[Token(Token = "0x600D1D1")]
	[Address(RVA = "0x2A80334", Offset = "0x2A80334", VA = "0x2A80334")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1D2")]
	[Address(RVA = "0x2A803DC", Offset = "0x2A803DC", VA = "0x2A803DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1D3")]
	[Address(RVA = "0x2A805FC", Offset = "0x2A805FC", VA = "0x2A805FC")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x600D1D4")]
	[Address(RVA = "0x2A80544", Offset = "0x2A80544", VA = "0x2A80544")]
	public void SetSelect(bool _b)
	{
	}

	[Token(Token = "0x600D1D5")]
	[Address(RVA = "0x2A807AC", Offset = "0x2A807AC", VA = "0x2A807AC")]
	public void SetData(AvatarLevelUpCard data, bool usable)
	{
	}

	[Token(Token = "0x600D1D6")]
	[Address(RVA = "0x2A80AF4", Offset = "0x2A80AF4", VA = "0x2A80AF4")]
	public int GetID()
	{
		return default(int);
	}

	[Token(Token = "0x600D1D7")]
	[Address(RVA = "0x2A80B60", Offset = "0x2A80B60", VA = "0x2A80B60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
