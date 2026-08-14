using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200259D")]
internal class UICommonSettingItemBaseController : UIBaseController
{
	[Token(Token = "0x400E8BD")]
	[FieldOffset(Offset = "0x28")]
	private int m_Type;

	[Token(Token = "0x600DC21")]
	[Address(RVA = "0x1EB4FD0", Offset = "0x1EB4FD0", VA = "0x1EB4FD0")]
	public UICommonSettingItemBaseController()
	{
	}

	[Token(Token = "0x600DC22")]
	[Address(RVA = "0x1EB505C", Offset = "0x1EB505C", VA = "0x1EB505C", Slot = "31")]
	public virtual void SetViewData(CommonSettingItemDataBase data, int type)
	{
	}

	[Token(Token = "0x600DC23")]
	[Address(RVA = "0x1EB50D8", Offset = "0x1EB50D8", VA = "0x1EB50D8", Slot = "32")]
	public virtual void RefreshContent()
	{
	}

	[Token(Token = "0x600DC24")]
	[Address(RVA = "0x1EB512C", Offset = "0x1EB512C", VA = "0x1EB512C", Slot = "33")]
	public virtual void RefreshTips()
	{
	}

	[Token(Token = "0x600DC25")]
	[Address(RVA = "0x1EB4B98", Offset = "0x1EB4B98", VA = "0x1EB4B98")]
	public int GetType()
	{
		return default(int);
	}
}
